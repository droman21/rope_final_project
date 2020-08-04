// import Employee from './components/Employee';
// import Priority from './components/Priority';
// import Status from './components/Status';
import apiActions from './api/apiActions';
import ReleaseTasks from './components/ReleaseTasks';
import ReleaseTask from './components/ReleaseTask';
import ReleaseTaskEdit from './components/ReleaseTaskEdit';
// import ReleaseTaskPostSection from './components/ReleaseTaskPostSection';
import Header from './components/Header';
// import Footer from './components/Footer';


const appDiv = document.querySelector('.app');
const appDivLeft = document.querySelector('.appLeft');
const appDivRight = document.querySelector('.appRight');


export default function pagebuild() {
    header()
    // footer()
    //navHome()
    showReleaseTasks();
    //highlightSpecificRow(1);
    //showAlert();
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
            appDivLeft.innerHTML = ReleaseTasks(releaseTasks);
            //releaseTaskNameButton();
            highlightSelectedRow();
        })
        .catch(err => console.log(err))

        const releaseTaskEndpoint = `https://localhost:44302/api/releaseTask/1`;
        const releaseTaskCallback = releaseTask => {
            appDivRight.innerHTML = ReleaseTask(releaseTask);
        };
        apiActions.getRequest(releaseTaskEndpoint, releaseTaskCallback);
        
        // console.log('before row highlight');
        // var table = document.getElementById('table1Id');
        // //var cells = table.getElementsByTagName('td');
        // console.log(table);
        // var rowSelected = table.getElementsByTagName('tr')[1];
        // rowSelected.style.backgroundColor = "rgb(173, 204, 209)";
        // rowSelected.className += " selected";
        // console.log('before row highlight');


}
function releaseTaskNameButton() {
    const releaseTaskItem = document.querySelectorAll('.releaseTask__info');
    releaseTaskItem.forEach(element => {
        element.addEventListener('click', function () {
            const releaseTaskId = element.id;
            const releaseTaskEndpoint = `https://localhost:44302/api/releaseTask/${releaseTaskId}`;
            const releaseTaskCallback = releaseTask => {
                appDivRight.innerHTML = ReleaseTask(releaseTask);
            };
            apiActions.getRequest(releaseTaskEndpoint, releaseTaskCallback);
        })
    })
}

function getStatusName(statusId) {
    const statusEndpoint = `https://localhost:44302/api/status/${statusId}`;
    fetch(`https://localhost:44302/api/status/${statusId}`)
        .then(response => response.json())
        .then(data => console.log(data))
        .catch(err => console.log(err))
}

appDivRight.addEventListener('click', function () {
    if (event.target.classList.contains('edit__releaseTaskButton')) {
        const ReleaseTaskEditSection = document.querySelector('.releaseTask__detailsInfo');
        const releaseTaskId = event.target.parentElement.querySelector('.edit__releaseTaskButton').id;
        console.log('edit paage displayed')
        apiActions.getRequest(
            `https://localhost:44302/api/releaseTask/${releaseTaskId}`,
            releaseTaskEdit => {
                ReleaseTaskEditSection.innerHTML = ReleaseTaskEdit(releaseTaskEdit);
            }
        )
    }
})

appDivRight.addEventListener('click', function () {
    if (event.target.classList.contains('edit-releaseTask__submit')) {
        const releaseTaskId = event.target.parentElement.querySelector('.edit-releaseTask__id').value;
        console.log(releaseTaskId);
        const name = event.target.parentElement.querySelector('.edit-releaseTask__name').value;
        console.log(name);
        const description = event.target.parentElement.querySelector('.edit-releaseTask__description').value;
        console.log(description);
        const statusID = 1;
        const priorityID = 1;
        //const dueTime = Date.now();
        const employeeID = 1;
        const isVisible = true;
        var lastModifiedDate = new Date();
        const formatedDate = lastModifiedDate.toISOString().slice(0,19).replace('T', ' ');

        const releaseEdit = {
            id: releaseTaskId,
            Name: name,
            Description: description,
            //CurrentDueTime: formatedDate,
            IsVisible: isVisible,
            LastModifiedDate: formatedDate,
            //CreatedDate: formatedDate,
            CurrentStatusID: statusID,
            CurrentPriorityID: priorityID,
            AssignedEmployeeID: employeeID
        };
        console.log(releaseEdit);

        const releaseTaskEndpoint = `https://localhost:44302/api/releaseTask/${releaseTaskId}`;
        apiActions.putRequest2(
            releaseTaskEndpoint,
            releaseEdit
        )
        console.log('changed saved');
        console.log("alert pop")
        //without the alert the page reposts with old data, even though it did save
        alert('Changes Saved');

        //Reload the Left Table
        fetch("https://localhost:44302/api/releaseTask")
            .then(response => response.json())
            .then(releaseTasks => {
                appDivLeft.innerHTML = ReleaseTasks(releaseTasks);
                //releaseTaskNameButton();
                //highlightSelectedRow();
                // var selectedRowID = document.getElementById(releaseTaskId);
                // console.log('selected row task id');
                // console.log(selectedRowID);
                // highlightSpecificRow(2);
            })
            .catch(err => console.log(err))

        //Reload the Right Table
        const releaseTaskCallback = releaseTask => {
            appDivRight.innerHTML = ReleaseTask(releaseTask);
            console.log("left table reloads")
        };
        apiActions.getRequest(releaseTaskEndpoint, releaseTaskCallback);
        console.log('after get req');



    }
})

// function changePriorityColor() {

//     var priorityThreshold = ${priority.id },
//         priorityColor = document.querySelector('.priorityLevel');

//     function changeColor(val) {
//         var color = "green";

//         if (val = 3) {
//             color = "yellow"
//         }
//         if (val = 2) {
//             color = "orange";
//         }
//         if (val = 1) {
//             color = "red";
//         }

//         priorityColor.style.color = color;
//     }
// }

// changeColor(colorThreshold);

//  function rowHighlightHandler(row){
//      alert('row index='+row.rowIndex);
//  }


function highlightSelectedRow() {
    var table = document.getElementById('table1Id');
    var cells = table.getElementsByTagName('td');

    for (let i = 0; i < cells.length; i++) {
        var cell = cells[i];
        cell.onclick = function () {
            var rowId = this.parentNode.rowIndex;
            var rowsNotSelected = table.getElementsByTagName('tr');
            for (var row = 1; row < rowsNotSelected.length; row++) {
                rowsNotSelected[row].style.backgroundColor = "white";
                rowsNotSelected[row].classList.remove('selected');
            }
            var rowSelected = table.getElementsByTagName('tr')[rowId];
            rowSelected.style.backgroundColor = "rgb(173, 204, 209)";
            rowSelected.className += " selected";

            const releaseTaskId = rowSelected.cells[0].innerHTML;
            const releaseTaskEndpoint = `https://localhost:44302/api/releaseTask/${releaseTaskId}`;
            const releaseTaskCallback = releaseTask => {
                appDivRight.innerHTML = ReleaseTask(releaseTask);
                console.log("new highlight on click")
            };
            apiActions.getRequest(releaseTaskEndpoint, releaseTaskCallback);
        }
    }
}

function highlightSpecificRow(rowId) {
    console.log('highlight undone');
    console.log(rowId);
    var table = document.getElementById('table1Id');
    console.log(table);
    var cells = table.getElementsByTagName('td');
    var rowSelected = table.getElementsByTagName('tr')[rowId];
    console.log(rowSelected);
    rowSelected.style.backgroundColor = "rgb(173, 204, 209)";
    rowSelected.className += " selected";

}

// appDivLeft.addEventListener('click', function(){
//     console.log("in show alert")
//     const alertButton = document.getElementsByName('alertButton');
//     console.log(alertButton);
//     const alertItem = document.getElementsByClassName('releaseTask__currentDueTime', 'releaseTask__name')
//     console.log(alertItem);
// //    alertButton.addEventListener('click', function () {
// //        console.log("in eventlistener")
//         alert("${releaseTask.name}","${releasetask.currentDueTime}")
//     //})

// })
