// import Employee from './components/Employee';
// import Priority from './components/Priority';
// import Status from './components/Status';
import apiActions from './api/apiActions';
import ReleaseTasks from './components/ReleaseTasks';
import ReleaseTask from './components/ReleaseTask';
// import ReleaseTaskEdit from './components/ReleaseTaskEdit';
// import ReleaseTaskPostSection from './components/ReleaseTaskPostSection';
import Header from './components/Header';
// import Footer from './components/Footer';


const appDiv = document.querySelector('.app');
const appDivLeft = document.querySelector('.appLeft');
const appDivRight = document.querySelector('.appRight');

export default function pagebuild(){
    header()
    // footer()
    //navHome()
    showReleaseTasks();
    // showStatus()
    // showPriority()    
}

function header() {
    const header = document.querySelector('.header');
    header.innerHTML = Header();
}
// function footer() {
//     const footerElement = document.querySelector('.footer');
//     footerElement.innerHTML = Footer();
// }

function navHome() {
    const homeButton = document.querySelector('.nav__home');
    homeButton.addEventListener('click', function () {
        console.log('navhome');
        appDiv.innerHTML = showReleaseTasks();
    })
}

function showReleaseTasks() {
    fetch("https://localhost:44302/api/releaseTask")
        .then(response => response.json())
        .then(releaseTasks => {
            //appDiv.innerHTML = ReleaseTasks(releaseTasks);
            appDivLeft.innerHTML = ReleaseTasks(releaseTasks);
            releaseTaskNameButton();
        })
        .catch(err => console.log(err))
}
function releaseTaskNameButton() {
    const releaseTaskItem = document.querySelectorAll('.releaseTask__info');
    releaseTaskItem.forEach(element => {
        element.addEventListener('click', function () {
            const releaseTaskId = element.id;
            const releaseTaskEndpoint = `https://localhost:44302/api/releaseTask/${releaseTaskId}`;
            const releaseTaskCallback = releaseTask => {

                 let statusName = 'ron';
                 console.log('1-before fetch statusName='+statusName);
                 fetch(`https://localhost:44302/api/status/${releaseTask.currentStatusID}`)
                 .then(response => response.json())
                 .then(console.log('2-second then'))
                 .then(stname => {
                     console.log('3-third then');
                     console.log(stname.name);
                     statusName = stname.name;
                     console.log("4=statusName="+statusName);
                 })
                 .then(console.log('5-fourth then, statusName='+statusName))
                 .catch(err => console.log(err))
                 console.log('6-after fetch, statusName='+statusName);

                // console.log('2-before request declaration');
                // const request = async () => {
                //     console.log('4-in request function');
                //     const response1 = await fetch(`https://localhost:44302/api/status/${releaseTask.currentStatusID}`);
                //     const json1 = await response1.json();
                //     console.log('5json1.name='+json1.name);
                //     statusName = json1.name;
                //     console.log('6statusName1='+statusName);
                // }
                // console.log('3-after request declaration, before request call');
                // let test1 = request();
                // console.log('7-after request call, test1='+test1);
                // console.log(test1);
                
                // console.log('8-before getStatusName2 call');
                // let test2 = getStatusName2(releaseTask.currentStatusID);
                // console.log('12-after getStatusName2 call');
                // console.log('13-StatusName2='+statusName);
                // console.log('14-test2='+test2);
                // console.log(test2);
                // console.log('15-test2.name='+test2.name);

                // console.log('100-before promise declaration');
                // const test3 = new Promise((resolve, reject) => {
                //     console.log('101-in promise');
                //     let test33 = getStatusName2(releaseTask.currentStatusID);
                //     console.log('102-after getStatusName2 call');
                //     console.log('103-StatusName2='+statusName);
                //     console.log('104-test2='+test33);
                //     console.log(test33);
                //     console.log('105-test2.name='+test33.name);
    
                // })
                // console.log('106-before promise call');
                // let stname3 = test3();
                // console.log('107-after promise call');
                // console.log('108-stname3='+stname3);

                appDivRight.innerHTML = ReleaseTask(releaseTask);
                console.log('after ReleaseTask display call');

            };
            apiActions.getRequest(releaseTaskEndpoint, releaseTaskCallback);
        })
    })
}
//const request = async () => {
 async function getStatusName2(statusId){
     console.log('9-in get statusnmae');
     const response1 =  await fetch(`https://localhost:44302/api/status/${statusId}`);
     const json1 =   await response1.json();
     console.log('10 - json1.name='+json1.name);
     console.log(json1);
     let statusName = json1.name;
     console.log('11 - statusName='+statusName);
     return statusName;
 }


async function getStatusName(statusId){
    const response = await fetch(`https://localhost:44302/api/status/${statusId}`, {});
    const json = await response.json();
    console.log(json.name);
    return json.name;
}


// function showEmployeeList() {
//     fetch()
//         .then(response => response.json())
//         .then(employees => {
//             appDiv.innerHTML = Employees(employees);
//         })
//         .catch(err => console.log(err))
// }
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
