import apiActions from './api/apiActions';
import SelectDropDownID from './components/SelectDropDownID';
import HandleTaskRows from './components/HandleTaskRows';
import HandleDropDowns from './components/HandleDropDowns';
//import Reminders from './components/Reminders';
import ReleaseTasks from './components/ReleaseTasks';
import ReleaseTask from './components/ReleaseTask';
import ReleaseTaskEdit from './components/ReleaseTaskEdit';
import ReleaseTaskPostSection from './components/ReleaseTaskPostSection';
import Header from './components/Header';
import Footer from './components/Footer';
import CommentPost from './components/CommentPost';
import HomePageLeft from './components/HomePageLeft';
import HomePageRight from './components/HomePageRight';
import Sort from './components/Sort';
import moment from "moment";
//import swal from 'sweetalert';

const appDiv = document.querySelector('.app');
const appDivLeft = document.querySelector('.appLeft');
const appDivRight = document.querySelector('.appRight');
let currentSelectedRowTaskID = 1;
var AppTimer = null;
let nameSortOrder = "ascending";
let statusSortOrder = "ascending";
let prioritySortOrder = "ascending";
let employeeSortOrder = "ascending";
let dueTimeSortOrder = "ascending";
let idSortOrder = "descending";

let currActiveReleaseTasks = null;
let newReleaseTaskID = null;

export default function pagebuild() {
    header()
    footer()
    //navHome()
    //showReleaseTasks();
    StartApp();

    //TODO:  Uncomment the following line before demos and final release
    //AppTimer = setInterval(ExecuteTimer,15000);    
}

function header() {
    const header = document.querySelector('.header');
    console.log(header);
    header.innerHTML = Header();
}
function footer() {
    const footer = document.querySelector('.footer');
    console.log(footer);
    //footerElement.innerHTML = Footer();
    footer.innerHTML = Footer();
}

// function navHome() {
//     const homeButton = document.querySelector('.nav__home');
//     homeButton.addEventListener('click', function () {
//         console.log('navhome');
//         appDiv.innerHTML = showReleaseTasks();
//     })
// }

function StartApp() {

    appDivLeft.innerHTML = HomePageLeft();
    appDivRight.innerHTML = HomePageRight();
}

appDivLeft.addEventListener('click', function () {
    if (event.target.parentElement != null && event.target.parentElement.classList.contains('startapp')){
        showReleaseTasks();
    }
})

appDivLeft.addEventListener('click', function () {

    if (event.target.classList.contains('table_header__ID')) {
        idSortOrder = Sort.ID(idSortOrder, currActiveReleaseTasks);
        console.log('tableheaderID='+currentSelectedRowTaskID);
        currentSelectedRowTaskID = HandleTaskRows.highlightSelectedRow();
        console.log('tableheaderIDa='+currentSelectedRowTaskID);
        HandleTaskRows.highlightSpecificRow(1);
    }
})

appDivLeft.addEventListener('click', function () {

    if (event.target.classList.contains('table_header__Name')) {
        nameSortOrder = Sort.Name(nameSortOrder, currActiveReleaseTasks);
        console.log('tableheaderName='+currentSelectedRowTaskID);
        currentSelectedRowTaskID = HandleTaskRows.highlightSelectedRow();
        console.log('tableheaderNameB='+currentSelectedRowTaskID);
        HandleTaskRows.highlightSpecificRow(1);
    }
})

appDivLeft.addEventListener('click', function () {
    if (event.target.classList.contains('table_header__Status')) {
        statusSortOrder = Sort.Status(statusSortOrder, currActiveReleaseTasks);
        console.log('tableheaderStatus='+currentSelectedRowTaskID);
        currentSelectedRowTaskID = HandleTaskRows.highlightSelectedRow();
        console.log('tableheaderStatusB='+currentSelectedRowTaskID);
        HandleTaskRows.highlightSpecificRow(1);
    }
})



appDivLeft.addEventListener('click', function () {
    if (event.target.classList.contains('table_header__Priority')) {
        prioritySortOrder = Sort.Priority(prioritySortOrder, currActiveReleaseTasks);
        currentSelectedRowTaskID = HandleTaskRows.highlightSelectedRow();
        HandleTaskRows.highlightSpecificRow(1);
    }
})

appDivLeft.addEventListener('click', function () {
    if (event.target.classList.contains('table_header__AssignedTo')) {
        employeeSortOrder = Sort.Employee(employeeSortOrder, currActiveReleaseTasks);
        console.log('tableheaderAssigned='+currentSelectedRowTaskID);
        currentSelectedRowTaskID = HandleTaskRows.highlightSelectedRow();
        console.log('tableheaderAssignedB='+currentSelectedRowTaskID);
        HandleTaskRows.highlightSpecificRow(1);
    }
})

appDivLeft.addEventListener('click', function () {
    if (event.target.classList.contains('table_header__DueTime')) {
        dueTimeSortOrder = Sort.DueTime(dueTimeSortOrder, currActiveReleaseTasks);
        console.log('tableheaderDue='+currentSelectedRowTaskID);
        currentSelectedRowTaskID = HandleTaskRows.highlightSelectedRow();
        console.log('tableheaderDueB='+currentSelectedRowTaskID);
        HandleTaskRows.highlightSpecificRow(1);
    }
})

function showReleaseTasks() {

    fetch("https://localhost:44302/api/releaseTask")
        .then(response => response.json())
        .then(releaseTasks => {
            releaseTasks = releaseTasks.filter(task => task.isVisisble == true);
            appDivLeft.innerHTML = ReleaseTasks(releaseTasks);
            console.log('showtasks='+currentSelectedRowTaskID);
            currentSelectedRowTaskID = HandleTaskRows.highlightSelectedRow();
            console.log('showtasksB='+currentSelectedRowTaskID);
            HandleTaskRows.highlightSpecificRow(1);
            currActiveReleaseTasks = releaseTasks;
        })
        .catch(err => console.log(err))

    const releaseTaskEndpoint = `https://localhost:44302/api/releaseTask/1`;
    const releaseTaskCallback = releaseTask => {
        appDivRight.innerHTML = ReleaseTask(releaseTask);
    };
    apiActions.getRequest(releaseTaskEndpoint, releaseTaskCallback);
}


appDivRight.addEventListener('click', function () {
    if (event.target.classList.contains('delete_releaseTaskButton')) {
        const releaseTaskId = event.target.parentElement.querySelector('.delete_releaseTaskButton').id;
        const releaseTaskEndpoint = `https://localhost:44302/api/releaseTask/${releaseTaskId}`;
        //var response = swal("Click OK to delete this task?", "", "warning");

        if (event.shiftKey) {
            var response = confirm("Click OK to PERMANENTLY delete this task?");
            if (response == true) {
                apiActions.deleteRequest2(
                    releaseTaskEndpoint
                )
                alert('Task Deleted');
                //TODO:  The next 20 lines are repeated elsewhere in main.js
                //without the alert the page reposts with old data, even though it did save
                //TODO:  Convert this to a Popup?  or add more detail to the alert popup

                //Reload the Left Table
                fetch("https://localhost:44302/api/releaseTask")
                .then(response => response.json())
                .then(releaseTasks => {
                    releaseTasks = releaseTasks.filter(task => task.isVisisble == true);
                    appDivLeft.innerHTML = ReleaseTasks(releaseTasks);
                    console.log('Delete='+currentSelectedRowTaskID);
                    currentSelectedRowTaskID = HandleTaskRows.highlightSelectedRow();
                    console.log('DeleteB='+currentSelectedRowTaskID);
                    HandleTaskRows.highlightSpecificRow(1);
                    currActiveReleaseTasks = releaseTasks;
                })
                .catch(err => console.log(err))

            //Reload the Right Table
            const releaseTaskEndpoint2 = `https://localhost:44302/api/releaseTask/1`;

            const releaseTaskCallback = releaseTask => {
                appDivRight.innerHTML = ReleaseTask(releaseTask);
            };
            apiActions.getRequest(releaseTaskEndpoint2, releaseTaskCallback);

            }
        }
        else {

            const releaseEdit = {
                id: releaseTaskId,
                IsVisisble: false
            };

            //TODO:  The next 20 lines are repeated elsewhere in main.js
            //without the alert the page reposts with old data, even though it did save
            //TODO:  Convert this to a Popup?  or add more detail to the alert popup
            //alert("Task Deleted");
            var response = confirm("Click OK to delete this task?");

            if (response == true) {

                apiActions.patchRequest(
                    releaseTaskEndpoint,
                    releaseEdit
                )
                alert('Task Deleted');
                //TODO:  The next 20 lines are repeated elsewhere in main.js
                //without the alert the page reposts with old data, even though it did save
                //TODO:  Convert this to a Popup?  or add more detail to the alert popup

                //Reload the Left Table
                fetch("https://localhost:44302/api/releaseTask")
                .then(response => response.json())
                .then(releaseTasks => {
                    releaseTasks = releaseTasks.filter(task => task.isVisisble == true);
                    appDivLeft.innerHTML = ReleaseTasks(releaseTasks);
                    console.log('Delete='+currentSelectedRowTaskID);
                    currentSelectedRowTaskID = HandleTaskRows.highlightSelectedRow();
                    console.log('DeleteB='+currentSelectedRowTaskID);
                    HandleTaskRows.highlightSpecificRow(1);
                    currActiveReleaseTasks = releaseTasks;
                })
                .catch(err => console.log(err))

            //Reload the Right Table
            const releaseTaskEndpoint2 = `https://localhost:44302/api/releaseTask/1`;

            const releaseTaskCallback = releaseTask => {
                appDivRight.innerHTML = ReleaseTask(releaseTask);
            };
            apiActions.getRequest(releaseTaskEndpoint2, releaseTaskCallback);

            }
        }

        // //TODO:  The next 20 lines are repeated elsewhere in main.js
        // //without the alert the page reposts with old data, even though it did save
        // //TODO:  Convert this to a Popup?  or add more detail to the alert popup

        // //Reload the Left Table
        // fetch("https://localhost:44302/api/releaseTask")
        //     .then(response => response.json())
        //     .then(releaseTasks => {
        //         releaseTasks = releaseTasks.filter(task => task.isVisisble == true);
        //         appDivLeft.innerHTML = ReleaseTasks(releaseTasks);
        //         console.log('Delete='+currentSelectedRowTaskID);
        //         currentSelectedRowTaskID = HandleTaskRows.highlightSelectedRow();
        //         console.log('DeleteB='+currentSelectedRowTaskID);
        //         HandleTaskRows.highlightSpecificRow(1);
        //         currActiveReleaseTasks = releaseTasks;
        //     })
        //     .catch(err => console.log(err))

        // //Reload the Right Table
        // const releaseTaskEndpoint2 = `https://localhost:44302/api/releaseTask/1`;

        // const releaseTaskCallback = releaseTask => {
        //     appDivRight.innerHTML = ReleaseTask(releaseTask);
        // };
        // apiActions.getRequest(releaseTaskEndpoint2, releaseTaskCallback);
    }
})


appDivRight.addEventListener('click', function () {
    if (event.target.classList.contains('edit__releaseTaskButton')) {
        const ReleaseTaskEditSection = document.querySelector('.releaseTask__detailsInfo');
        const releaseTaskId = event.target.parentElement.querySelector('.edit__releaseTaskButton').id;
        const statusDrop = HandleDropDowns.StatusDropDown();
        const priorityDrop = HandleDropDowns.PriorityDropDown();
        const employeeDrop = HandleDropDowns.EmployeeDropDown();

        apiActions.getRequest(
            `https://localhost:44302/api/releaseTask/${releaseTaskId}`,
            releaseTaskEdit => {
                ReleaseTaskEditSection.innerHTML = ReleaseTaskEdit(releaseTaskEdit, statusDrop, priorityDrop, employeeDrop);
                SelectDropDownID.selectElement('statusDropID', releaseTaskEdit.currentStatusID);
                SelectDropDownID.selectElement('priorityDropID', releaseTaskEdit.currentPriorityID);
                SelectDropDownID.selectElement('employeeDropID', releaseTaskEdit.assignedEmployeeID);
            }
        )
    }
})

appDivRight.addEventListener('click', function () {
    if (event.target.classList.contains('edit-releaseTask__submit')) {
        console.log('edit submit clicked');
        let name = event.target.parentElement.querySelector('.edit-releaseTask__name').value;
        const description = event.target.parentElement.querySelector('.new').value;
        const createdDate = event.target.parentElement.querySelector('.edit-releaseTask__createdDate').value;
        const currentDueTime = event.target.parentElement.querySelector('.edit-releaseTask__currentDueTime').value;
        const newStatusID = event.target.parentElement.querySelector('.edit-releaseTask__Status').value;
        const newPriorityID = event.target.parentElement.querySelector('.edit-releaseTask__Priority').value;
        const newEmployeeID = event.target.parentElement.querySelector('.edit-releaseTask__Employee').value;
        const releaseTaskId = event.target.parentElement.querySelector('.edit-releaseTask__id').value;
        var lastModifiedDate = new Date();
        const formatedDate = lastModifiedDate.toLocaleDateString() + " " + lastModifiedDate.toLocaleTimeString();
        name = name.charAt(0).toUpperCase() + name.slice(1);
        const releaseEdit = {
            id: releaseTaskId,
            Name: name,
            Description: description,
            CurrentDueTime: currentDueTime,
            IsVisisble: true,
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
        alert("Changes Saved");

        //Reload the Left Table
        fetch("https://localhost:44302/api/releaseTask")
            .then(response => response.json())
            .then(releaseTasks => {
                releaseTasks = releaseTasks.filter(task => task.isVisisble == true);
                appDivLeft.innerHTML = ReleaseTasks(releaseTasks);
                console.log('Edit='+currentSelectedRowTaskID);
                currentSelectedRowTaskID = HandleTaskRows.highlightSelectedRow();
                console.log('EditB='+currentSelectedRowTaskID);
                HandleTaskRows.highlightSpecificRow(currentSelectedRowTaskID);
                currActiveReleaseTasks = releaseTasks;
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
    if (event.target.parentElement != null && event.target.parentElement.classList.contains('add__releaseTaskButton')) {
        const statusDrop = HandleDropDowns.StatusDropDown();
        const priorityDrop = HandleDropDowns.PriorityDropDown();
        const employeeDrop = HandleDropDowns.EmployeeDropDown();
        const currentDate = new Date();
        console.log(currentDate);
        //const formatedDate = moment(currentDate).format('yyyy-MM-ddThh:mm');
        //console.log(formatedDate);
        console.log('Add='+currentSelectedRowTaskID);
        appDivRight.innerHTML = ReleaseTaskPostSection(statusDrop, priorityDrop, employeeDrop, currentSelectedRowTaskID, currentDate);
    }
})

appDivRight.addEventListener('click', function () {
    if (event.target.classList.contains('create-releaseTask__submit')) {
        let name = event.target.parentElement.querySelector('.create-releaseTask__name').value;
        const description = event.target.parentElement.querySelector('.create-releaseTask__description').value;
        const currentDueTime = event.target.parentElement.querySelector('.create-releaseTask__currentDueTime').value;
        const currentStatusID = event.target.parentElement.querySelector('.create-releaseTask__Status').value;
        const currentPriorityID = event.target.parentElement.querySelector('.create-releaseTask__Priority').value;
        const assignedEmployeeID = event.target.parentElement.querySelector('.create-releaseTask__Employee').value;
        var lastModifiedDate = new Date();
        const formatedCurrentDate = lastModifiedDate.toLocaleDateString() + " " + lastModifiedDate.toLocaleTimeString();
        name = name.charAt(0).toUpperCase() + name.slice(1);
        var requestBody = {
            Name: name,
            Description: description,
            CreatedDate: formatedCurrentDate,
            IsVisisble: true,
            CurrentDueTime: currentDueTime,
            LastModifiedDate: formatedCurrentDate,
            CurrentStatusID: currentStatusID,
            CurrentPriorityID: currentPriorityID,
            AssignedEmployeeID: assignedEmployeeID,
        }
        // apiActions.postRequest(
        //     "https://localhost:44302/api/releaseTask",
        //     requestBody,
        //     newReleaseTasks => {
        //         appDivLeft.innerHTML = ReleaseTasks(newReleaseTasks);
        //     }
        // )
        fetch("https://localhost:44302/api/releaseTask", {
            method: 'POST',
            headers: {
                "Content-Type": "application/json"
            },
            body: JSON.stringify(requestBody),
        })
            .then(response => response.json())
            .then(
                data => newReleaseTaskID = data)
//                data => console.log(data))
            .catch(err => console.log(err))

            //TODO:  The next 20 lines are repeated elsewhere in main.js
            //without the alert the page reposts with old data, even though it did save
            //TODO:  Convert this to a Popup?  or add more detail to the alert popup
            alert("Task Added");
            console.log('new task ID='+newReleaseTaskID);

        //Reload the Left Table
        fetch("https://localhost:44302/api/releaseTask")
            .then(response => response.json())
            .then(releaseTasks => {
                releaseTasks = releaseTasks.filter(task => task.isVisisble == true);
                appDivLeft.innerHTML = ReleaseTasks(releaseTasks);
                console.log('AddSave='+currentSelectedRowTaskID);
                currentSelectedRowTaskID = HandleTaskRows.highlightSelectedRow();
                console.log('AddSaveB='+currentSelectedRowTaskID);
                HandleTaskRows.highlightSpecificRow(newReleaseTaskID);
                currActiveReleaseTasks = releaseTasks;
            })
            .catch(err => console.log(err))

        //Reload the Right Table
        //TODO:  Since we don't have an ID (from SQL) for this add we need to default it to 1
        //          so that the display still works with the table row highlighted with the
        //          task details being displayed.  If we have time to conver to a 'Release Task Number'
        //          instead of the SQL ID we could then highlight the newly added row
        //const releaseTaskEndpoint = `https://localhost:44302/api/releaseTask/${releaseTaskId}`;
        const releaseTaskEndpoint = `https://localhost:44302/api/releaseTask/1`;
        const releaseTaskCallback = releaseTask => {
            appDivRight.innerHTML = ReleaseTask(releaseTask);
        };
        apiActions.getRequest(releaseTaskEndpoint, releaseTaskCallback);
    }
})

appDivRight.addEventListener('click', function (releaseTask) {
    if (event.target.classList.contains('edit__releaseTaskButton__back')) {
        const releaseTaskId = event.target.parentElement.querySelector('.edit__releaseTaskButton__back').id;
        apiActions.getRequest(
            `https://localhost:44302/api/releaseTask/${releaseTaskId}`,
            releaseTask => {
                appDivRight.innerHTML = ReleaseTask(releaseTask);
            }
        )
    }
    if (event.target.classList.contains('edit__releaseTaskButton__back')) {
        apiActions.getRequest(`https://localhost:44302/api/releaseTask/1`,
            releaseTask => {
                appDivRight.innerHTML = ReleaseTask(releaseTask);
                //ADD IN HIGHLIGHTED SELECTED ROW TO REQUEST
                //THIS LINE OF CODE HIGHLIGHTS ROW ID
                 //HandleTaskRows.highlightSpecificRow(1);
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
        const releaseTaskId = event.target.parentElement.querySelector('.add-comment__submit').id;
        const isVisible = true;
        const commentDetails = event.target.parentElement.querySelector('.add-comment__details').value;

        const newCommentBody = {
            Details: commentDetails,
            IsVisible: isVisible,
            ReleaseTaskID: releaseTaskId
        }

        apiActions.postRequest2(
            "https://localhost:44302/api/comment",
            newCommentBody
        )

        const releaseTaskEndpoint = `https://localhost:44302/api/releaseTask/${releaseTaskId}`;

        //TODO:  The next 20 lines are repeated elsewhere in main.js
        //without the alert the page reposts with old data, even though it did save
        //TODO:  Convert this to a Popup?  or add more detail to the alert popup
        alert("Changes Saved");

        //Reload the Left Table
        fetch("https://localhost:44302/api/releaseTask")
            .then(response => response.json())
            .then(releaseTasks => {
                releaseTasks = releaseTasks.filter(task => task.isVisisble == true);
                appDivLeft.innerHTML = ReleaseTasks(releaseTasks);
                console.log('EditSave='+currentSelectedRowTaskID);
                currentSelectedRowTaskID = HandleTaskRows.highlightSelectedRow();
                console.log('EditSaveB='+currentSelectedRowTaskID);
                HandleTaskRows.highlightSpecificRow(currentSelectedRowTaskID);
                currActiveReleaseTasks = releaseTasks;
            })
            .catch(err => console.log(err))

        //Reload the Right Table
        const releaseTaskCallback = releaseTask => {
            appDivRight.innerHTML = ReleaseTask(releaseTask);
        };
        apiActions.getRequest(releaseTaskEndpoint, releaseTaskCallback);
    }
})

function ExecuteTimer() {

    currActiveReleaseTasks.sort((a, b) => (a.currentDueTime > b.currentDueTime) ? 1 : -1);
    currActiveReleaseTasks.forEach(rt => {
        let curr = (new Date(rt.currentDueTime));
        let now = (new Date());
        if (curr < now) {
            alert('Warning.  The following task is overdue\n\n' + rt.name);
        }
    });
}

appDivLeft.addEventListener('click', function () {

    if (event.target.parentElement != null && event.target.parentElement.classList.contains('reminders__button')) {
        if (event.shiftKey){
            fetch("https://localhost:44302/api/releaseTask")
                .then(response => response.json())
                .then(releaseTasks => {
                    //releaseTasks = releaseTasks.filter(task => task.isVisisble == true);
                    appDivRight.innerHTML = ReleaseTasks(releaseTasks);
                    //currentSelectedRowTaskID = HandleTaskRows.highlightSelectedRow();
                    //HandleTaskRows.highlightSpecificRow(1);
                })
                .catch(err => console.log(err))
        }
        else {
            ExecuteTimer();
        }
    }
})
