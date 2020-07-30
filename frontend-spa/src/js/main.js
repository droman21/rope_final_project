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
                //appDiv.innerHTML = ReleaseTask(releaseTask);
                //getStatusName(releaseTask.currentStatusID);
                appDivRight.innerHTML = ReleaseTask(releaseTask);
            };
            apiActions.getRequest(releaseTaskEndpoint, releaseTaskCallback);
        })
    })
}

function getStatusName(statusId){
    const statusEndpoint = `https://localhost:44302/api/status/${statusId}`;
    fetch(`https://localhost:44302/api/status/${statusId}`)
    .then(response => response.json())
    .then(data => console.log(data))
    .catch(err => console.log(err))
}

appDiv.addEventListener('click', function () {
    if (event.target.classList.contains('.edit-releaseTask')) {
        const ReleaseTaskEdit = document.querySelector('.edit-rleleaseTask');
        const releaseTaskId = event.target.parentElement.querySelector('.edit-album__button').id;
        const artistId = event.target.parentElement.querySelector('.artistId').value;
        apiActions.getRequest(
            `https://localhost:44313/api/album/${albumId}`,
            albumEdit => {
                editAlbumSection.innerHTML = AlbumEditSection(artistId, albumEdit);
            }
        )
    }
})

// appDiv.addEventListener("click", function () {
//     if (event.target.classList.contains('edit-album__submit')) {
//         const albumId = event.target.parentElement.querySelector('.edit-album__albumId').value;
//         const albumName = event.target.parentElement.querySelector('.edit-album__albumName').value;
//         const imageName = event.target.parentElement.querySelector('.edit-album__albumImageName').value;
//         const releaseYear = event.target.parentElement.querySelector('.edit-album__releaseYear').value;
//         const recordLabel = event.target.parentElement.querySelector('.edit-album__recordLabel').value;
//         const genre = event.target.parentElement.querySelector('.edit-album__albumGenre').value;
//         const artistId = event.target.parentElement.querySelector('.edit-album__artistId').value;

//         const albumEdit = {
//             id: albumId,
//             Name: albumName,
//             ImageName: imageName,
//             ReleaseYear: releaseYear,
//             RecordLabel: recordLabel,
//             Genre: genre,
//             ArtistId: artistId
//         };

//         const artistCallback = () => {
//             apiActions.getRequest(
//                 `https://localhost:44313/api/artist/${artistId}`,
//                 artist => {
//                     appDiv.innerHTML = Artist(artist);
//                     albumNameButton();
//                 })
//         }

//         apiActions.putRequest(
//             `https://localhost:44313/api/album/${albumId}`,
//             albumEdit,
//             artistCallback
//         )
//     }
// })


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
