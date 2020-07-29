import Employee from './components/Employee';
import Employees from './components/Employees';
import Priority from './components/Priority';
import Status from './components/Status';
import ReleaseTasks from './components/ReleaseTasks';
// import ReleaseTask from './components/ReleaseTask';
// import ReleaseTaskEdit from './components/ReleaseTaskEdit';
// import ReleaseTaskPostSection from './components/ReleaseTaskPostSection';
// import Header from './components/Header';
// import Footer from './components/Footer';

const appDiv = document.querySelector('.app');

export default function pagebuild(){
    // header()
    // footer()
    // home()
    showReleaseTasks();

    //showEmployeeList()
    // showStatus()
    // showPriority()    
}

// function header() {
//     const header = document.querySelector('.header');
//     header.innerHTML = Header();
// }
// function footer() {
//     const footerElement = document.querySelector('.footer');
//     footerElement.innerHTML = Footer();
// }
function showReleaseTasks() {
    console.log(appDiv);
    fetch("https://localhost:44302/api/ReleaseTask")
        .then(response => response.json())
        .then(releaseTasks => {
            appDiv.innerHTML = ReleaseTasks(releaseTasks);
            releaseTaskName__Button();
        })
        .catch(err => console.log(err))
}

// function showEmployeeList() {
//     fetch("https://localhost:44302/api/employee")
//         .then(response => response.json())
//         .then(employees => {
//             appDiv.innerHTML = Employees(employees);
//         })
//         .catch(err => console.log(err))
// }

function releaseTaskNameButton() {
    const releaseTask = document.querySelectorAll('.releaseTask');
    releaseTask.forEach(element => {
        element.addEventListener('click', function () {
            const releaseTaskID = element.id;
            const releaseTaskEndpoint = `https://localhost:44302/api/releaseTask/${releaseTaskID}`;
            const releaseTaskCallback = () => {
                apiActions.getRequest(
                    `https://localhost:44302/api/releaseTask/${releaseTaskID}`,
                    releaseTask => {
                        appDiv.innerHTML = ReleaseTask(releaseTask);
                    }
                )
            }            
            // const releaseTaskCallback = releaseTask => {
            //     appDiv.innerHTML = ReleaseTask(releaseTask);
            // };
            // apiActions.getRequest(releaseTaskCallback, releaseTaskEndpoint);
        })
    })
}

// function showReleaseTask_ByPriority() {
//     const priorityReleaseTask = document.querySelectorAll(".releaseTask__item");
//     priorityReleaseTask.forEach(element => {
//         element.addEventListener('click', function () {
//             const priorityReleaseTaskId = element.id;
//             fetch()
//                 .then(response => response.json())
//                 .then( => appDiv.innerHTML = )
//                 .catch(err => console.log(err))
//         })
//     })

// }

