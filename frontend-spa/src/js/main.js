// import Employee from './components/Employee';
// import Priority from './components/Priority';
// import Status from './components/Status';
import apiActions from './api/apiActions';
import ReleaseTasks from './components/ReleaseTasks';
import ReleaseTask from './components/ReleaseTask';
import ReleaseTaskEdit from './components/ReleaseTaskEdit';
import ReleaseTaskPostSection from './components/ReleaseTaskPostSection';
import Header from './components/Header';
// import Footer from './components/Footer';
import CommentPost from './components/CommentPost';


const appDiv = document.querySelector('.app');
const appDivLeft = document.querySelector('.appLeft');
const appDivRight = document.querySelector('.appRight');
let currentSelectedRowID = 0;
let statusData = fetch("https://localhost:44302/api/status")
.then(response => response.json())
.then(data => {
    statusData = data;
    return statusData;
})
.catch(err => console.log(err));

let priorityData = fetch("https://localhost:44302/api/priority")
.then(response => response.json())
.then(data => {
    priorityData = data;
    return priorityData;
})
.catch(err => console.log(err));

let employeeData = fetch("https://localhost:44302/api/employee")
.then(response => response.json())
.then(data => {
    employeeData = data;
    return employeeData;
})
.catch(err => console.log(err));


export default function pagebuild() {
    header()
    // footer()
    //navHome()
    showReleaseTasks();
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
            highlightSelectedRow();
            highlightSpecificRow(1);
        })
        .catch(err => console.log(err))

        const releaseTaskEndpoint = `https://localhost:44302/api/releaseTask/1`;
        const releaseTaskCallback = releaseTask => {
            appDivRight.innerHTML = ReleaseTask(releaseTask);
        };
        apiActions.getRequest(releaseTaskEndpoint, releaseTaskCallback);
}

// function releaseTaskNameButton() {
//     //THIS CODE SHOULD NO LONGER BE NEEDED.  TO BE DELETED DURING FINAL CODE CLEANUP PHASE
//     const releaseTaskItem = document.querySelectorAll('.releaseTask__info');
//     releaseTaskItem.forEach(element => {
//         element.addEventListener('click', function () {
//             const releaseTaskId = element.id;
//             const releaseTaskEndpoint = `https://localhost:44302/api/releaseTask/${releaseTaskId}`;
//             const releaseTaskCallback = releaseTask => {
//                 appDivRight.innerHTML = ReleaseTask(releaseTask);
//             };
//             apiActions.getRequest(releaseTaskEndpoint, releaseTaskCallback);
//         })
//     })
// }

// function getStatusName(statusId) {
//     //THIS CODE SHOULD NO LONGER BE NEEDED.  TO BE DELETED DURING FINAL CODE CLEANUP PHASE
//     const statusEndpoint = `https://localhost:44302/api/status/${statusId}`;
//     fetch(`https://localhost:44302/api/status/${statusId}`)
//         .then(response => response.json())
//         .then(data => console.log(data))
//         .catch(err => console.log(err))
// }

appDivRight.addEventListener('click', function () {
    if (event.target.classList.contains('edit__releaseTaskButton')) {
        const ReleaseTaskEditSection = document.querySelector('.releaseTask__detailsInfo');
        const releaseTaskId = event.target.parentElement.querySelector('.edit__releaseTaskButton').id;
        const statusDrop = `
            ${statusData.map(sd => {
                return `
                <option class="edit-releaseTask__newStatusID" value="${sd.value}">${sd.name}</option>
                `
            })}
        `
        const priorityDrop = `
            ${priorityData.map(pd => {
                return `
                <option class="edit-releaseTask__newPriorityID" value="${pd.value}">${pd.name}</option>
                `
            })}
        `
        const employeeDrop = `
            ${employeeData.map(ed => {
                return `
                <option class="edit-releaseTask__newEmployeeID" value="${ed.id}">${ed.name}</option>
                `
            })}
        `
        apiActions.getRequest(
            `https://localhost:44302/api/releaseTask/${releaseTaskId}`,
            releaseTaskEdit => {
                ReleaseTaskEditSection.innerHTML = ReleaseTaskEdit(releaseTaskEdit,statusDrop,priorityDrop,employeeDrop);
                console.log('releaseTaskEdit');
                console.log(releaseTaskEdit);
                console.log('releaseTaskEdit='+releaseTaskEdit);
                //var obj = JSON.parse(releaseTaskEdit);
                //var newdata = releaseTaskEdit.data.CurrentStatusID;
                var currStatusID = releaseTaskEdit.currentStatusID;
                var currPriorityID = releaseTaskEdit.currentPriorityID;
                var currAssignedEmployeeID = releaseTaskEdit.assignedEmployeeID;
                console.log('after parse');
                //console.log(newdata);
                //var currStID = obj.CurrentStatusID;
                //console.log(currStID);
                selectElement('statusDropID',currStatusID);
                selectElement('priorityDropID',currPriorityID);
                selectElement('employeeDropID',currAssignedEmployeeID);
            }
        )
        
    }
})

function selectElement(id, valueToSelect){
    console.log(id);
    //let valueToSelect = releaseTaskEdit.CurrentStatusID;
    console.log(valueToSelect);
    let element = document.getElementById(id);
    //let element = document.querySelector('.edit-releaseTask__Status');
    console.log(element);
    element.value = valueToSelect;
}

appDivRight.addEventListener('click', function () {
    if (event.target.classList.contains('edit-releaseTask__submit')) {
        const releaseTaskId = event.target.parentElement.querySelector('.edit-releaseTask__id').value;
        //console.log(releaseTaskId);
        const name = event.target.parentElement.querySelector('.edit-releaseTask__name').value;
        //console.log(name);
        const description = event.target.parentElement.querySelector('.edit-releaseTask__description').value;
        //console.log(description);
        const createdDate = event.target.parentElement.querySelector('.edit-releaseTask__createdDate').value;
        const currentDueTime = event.target.parentElement.querySelector('.edit-releaseTask__currentDueTime').value;
        //const statusID = 1;
        const newStatusID = event.target.parentElement.querySelector('.edit-releaseTask__Status').value;
        //console.log('newstatus='+newStatusID);
        //const priorityID = 1;
        const newPriorityID = event.target.parentElement.querySelector('.edit-releaseTask__Priority').value;
        //console.log('newpriority='+ newPriorityID);
        //const employeeID = 1;
        const newEmployeeID = event.target.parentElement.querySelector('.edit-releaseTask__Employee').value;
        //console.log('newemp='+ newEmployeeID);
        const isVisible = true;
        var lastModifiedDate = new Date();
        const formatedDate = lastModifiedDate.toLocaleDateString() + " " + lastModifiedDate.toLocaleTimeString();
        //console.log(lastModifiedDate);
        //console.log(formatedDate);
        const releaseEdit = {
            id: releaseTaskId,
            Name: name,
            Description: description,
            CurrentDueTime: currentDueTime,
            IsVisible: isVisible,
            LastModifiedDate: formatedDate,
            CreatedDate: createdDate,
            CurrentStatusID: newStatusID,
            CurrentPriorityID: newPriorityID,
            AssignedEmployeeID: newEmployeeID
        };

        const releaseTaskEndpoint = `https://localhost:44302/api/releaseTask/${releaseTaskId}`;
        apiActions.putRequest2(
            releaseTaskEndpoint,
            releaseEdit
        )

        //TODO:  The next 20 lines are repeated elsewhere in main.js
        //without the alert the page reposts with old data, even though it did save
        //TODO:  Convert this to a Popup?  or add more detail to the alert popup
        alert('Changes Saved');

        //Reload the Left Table
        fetch("https://localhost:44302/api/releaseTask")
            .then(response => response.json())
            .then(releaseTasks => {
                appDivLeft.innerHTML = ReleaseTasks(releaseTasks);
                highlightSelectedRow();
                highlightSpecificRow(currentSelectedRowID);
            })
            .catch(err => console.log(err))

        //Reload the Right Table
        const releaseTaskCallback = releaseTask => {
            appDivRight.innerHTML = ReleaseTask(releaseTask);
        };
        apiActions.getRequest(releaseTaskEndpoint, releaseTaskCallback);
    }
})

appDivLeft.addEventListener('click', function () {
    if (event.target.parentElement.classList.contains('add__releaseTaskButton')) {
        console.log("new task clicked")
        appDivRight.innerHTML = ReleaseTaskPostSection();
    }
})

appDivRight.addEventListener('click', function () {
    if (event.target.classList.contains('create-releaseTask__submit')) {
        const name = event.target.parentElement.querySelector('.create-releaseTask__name').value;
        const description = event.target.parentElement.querySelector('.create-releaseTask__description').value;
        const currentDueTime = event.target.parentElement.querySelector('.create-releaseTask__currentDueTime').value;
        const currentStatusID = event.target.parentElement.querySelector('.create-releaseTask__currentStatusId').value;
        const currentPriorityID = event.target.parentElement.querySelector('.create-releaseTask__currentPriorityId').value;
        const assignedEmployeeID = event.target.parentElement.querySelector('.create-releaseTask__assignedEmployeeId').value;
        var lastModifiedDate = new Date();
        const formatedCurrentDate = lastModifiedDate.toLocaleDateString() + " " + lastModifiedDate.toLocaleTimeString();
        var requestBody = {
            Name: name,
            Description: description,
            CreatedDate:formatedCurrentDate,
            IsVisisble: true,
            CurrentDueTime: formatedCurrentDate,
            LastModifiedDate: formatedCurrentDate,
            CurrentStatusID: currentStatusID,
            CurrentPriorityID: currentPriorityID,
            AssignedEmployeeID: assignedEmployeeID,
        }
        console.log(requestBody)
        apiActions.postRequest(
            "https://localhost:44302/api/releaseTask",
            requestBody,
            newReleaseTasks => {
                appDivLeft.innerHTML = ReleaseTasks(newReleaseTasks);
            }
        )
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
            currentSelectedRowID = rowId;
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
            };
            apiActions.getRequest(releaseTaskEndpoint, releaseTaskCallback);
        }
    }
}

function highlightSpecificRow(rowId) {
    var table = document.getElementById('table1Id');
    var rowSelected = table.getElementsByTagName('tr')[rowId];
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

appDivRight.addEventListener('click', function(releaseTask){
    if (event.target.classList.contains('edit__releaseTaskButton__back')){
        const releaseTaskId = event.target.parentElement.querySelector('.edit__releaseTaskButton__back').id;
        apiActions.getRequest(
            `https://localhost:44302/api/releaseTask/${releaseTaskId}`,
            releaseTask => {
                appDivRight.innerHTML = ReleaseTask(releaseTask);
            }
        )
    }           
})

appDivRight.addEventListener('click', function () {
    if (event.target.classList.contains('add__commentButton')) {
        const ReleaseTaskEditSection = document.querySelector('.releaseTask__detailsInfo');
        const releaseTaskId = event.target.parentElement.querySelector('.add__commentButton').id;
        apiActions.getRequest(
            `https://localhost:44302/api/releaseTask/${releaseTaskId}`,
            addComment => {
                ReleaseTaskEditSection.innerHTML = CommentPost(releaseTaskId, addComment);
            }
        )
    }
})

appDivRight.addEventListener('click', function () {
    if (event.target.classList.contains('add-comment__submit')) {
        console.log('in save comment');
        const releaseTaskId = event.target.parentElement.querySelector('.add-comment__submit').id;
        const isVisible = true;
        const commentDetails = event.target.parentElement.querySelector('.add-comment__details').value;
        console.log(releaseTaskId);
        console.log(isVisible);
        console.log(commentDetails);

        const newCommentBody = {
            Details: commentDetails,
            IsVisible: isVisible,
            ReleaseTaskID: releaseTaskId
        }

        console.log(newCommentBody);

        apiActions.postRequest2(
            "https://localhost:44302/api/comment",
            newCommentBody
            )

        const releaseTaskEndpoint = `https://localhost:44302/api/releaseTask/${releaseTaskId}`;

        //TODO:  The next 20 lines are repeated elsewhere in main.js
        //without the alert the page reposts with old data, even though it did save
        //TODO:  Convert this to a Popup?  or add more detail to the alert popup
        alert('Changes Saved');

        //Reload the Left Table
        fetch("https://localhost:44302/api/releaseTask")
            .then(response => response.json())
            .then(releaseTasks => {
                appDivLeft.innerHTML = ReleaseTasks(releaseTasks);
                highlightSelectedRow();
                highlightSpecificRow(currentSelectedRowID);
            })
            .catch(err => console.log(err))

        //Reload the Right Table
        const releaseTaskCallback = releaseTask => {
            appDivRight.innerHTML = ReleaseTask(releaseTask);
        };
        apiActions.getRequest(releaseTaskEndpoint, releaseTaskCallback);


    }
})