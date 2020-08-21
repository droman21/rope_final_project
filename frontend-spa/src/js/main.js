import apiActions from './api/apiActions';
import SelectDropDownID from './components/SelectDropDownID';
import HandleTaskRows from './components/HandleTaskRows';
import HandleDropDowns from './components/HandleDropDowns';
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
import swal from 'sweetalert2';

const pause = ms => new Promise (resolve => setTimeout(resolve, ms));

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
    //StartApp();
    showReleaseTasks();


    //TODO: Uncomment the following line to active Popup Reminders
    //AppTimer = setInterval(ExecuteTimer, 180000);
}

function header() {
    const header = document.querySelector('.header');
    header.innerHTML = Header();
}

function footer() {
    const footer = document.querySelector('.footer');
    footer.innerHTML = Footer();
}

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
        currentSelectedRowTaskID = HandleTaskRows.highlightSelectedRow();
        HandleTaskRows.highlightSpecificRow(currentSelectedRowTaskID);
    }
})

appDivLeft.addEventListener('click', function () {

    if (event.target.classList.contains('table_header__Name')) {
        nameSortOrder = Sort.Name(nameSortOrder, currActiveReleaseTasks);
        currentSelectedRowTaskID = HandleTaskRows.highlightSelectedRow();
        HandleTaskRows.highlightSpecificRow(currentSelectedRowTaskID);
    }
})

appDivLeft.addEventListener('click', function () {
    if (event.target.classList.contains('table_header__Status')) {
        statusSortOrder = Sort.Status(statusSortOrder, currActiveReleaseTasks);
        currentSelectedRowTaskID = HandleTaskRows.highlightSelectedRow();
        HandleTaskRows.highlightSpecificRow(currentSelectedRowTaskID);
    }
})

appDivLeft.addEventListener('click', function () {
    if (event.target.classList.contains('table_header__Priority')) {
        prioritySortOrder = Sort.Priority(prioritySortOrder, currActiveReleaseTasks);
        currentSelectedRowTaskID = HandleTaskRows.highlightSelectedRow();
        HandleTaskRows.highlightSpecificRow(currentSelectedRowTaskID);
    }
})

appDivLeft.addEventListener('click', function () {
    if (event.target.classList.contains('table_header__AssignedTo')) {
        employeeSortOrder = Sort.Employee(employeeSortOrder, currActiveReleaseTasks);
        currentSelectedRowTaskID = HandleTaskRows.highlightSelectedRow();
        HandleTaskRows.highlightSpecificRow(currentSelectedRowTaskID);
    }
})

appDivLeft.addEventListener('click', function () {
    if (event.target.classList.contains('table_header__DueTime')) {
        dueTimeSortOrder = Sort.DueTime(dueTimeSortOrder, currActiveReleaseTasks);
        currentSelectedRowTaskID = HandleTaskRows.highlightSelectedRow();
        HandleTaskRows.highlightSpecificRow(currentSelectedRowTaskID);
    }
})

function getReleaseTasksShowFirst(){
    fetch("https://localhost:44302/api/releaseTask")
        .then(response => response.json())
        .then(releaseTasks => {
            releaseTasks = releaseTasks.filter(task => task.isVisisble == true);
            appDivLeft.innerHTML = ReleaseTasks(releaseTasks);
            currentSelectedRowTaskID = HandleTaskRows.highlightSelectedRow();
            var table = document.getElementById('table1Id');
            var rows = table.getElementsByTagName('tr');
            let firstReleaseTaskID = rows[1].cells[0].innerHTML;
            HandleTaskRows.highlightSpecificRow(firstReleaseTaskID);
            const releaseTaskEndpoint = `https://localhost:44302/api/releaseTask/${firstReleaseTaskID}`;
            const releaseTaskCallback = releaseTask => {
                appDivRight.innerHTML = ReleaseTask(releaseTask);
            };
            apiActions.getRequest(releaseTaskEndpoint, releaseTaskCallback);
            currActiveReleaseTasks = releaseTasks;
        })
        .catch(err => console.log(err))
}

function getReleaseTasksShowCurrent(){
    console.log('9-in get rel Show current');
    fetch("https://localhost:44302/api/releaseTask")
    .then(response => response.json())
    .then(releaseTasks => {
        console.log('10-in then');
        releaseTasks = releaseTasks.filter(task => task.isVisisble == true);
        appDivLeft.innerHTML = ReleaseTasks(releaseTasks);
        currentSelectedRowTaskID = HandleTaskRows.highlightSelectedRow();
        HandleTaskRows.highlightSpecificRow(currentSelectedRowTaskID);
        currActiveReleaseTasks = releaseTasks;
    })
    .catch(err => console.log(err))
    console.log('11-end of get show current');
}

function getReleaseTasksShowNew(){
    fetch("https://localhost:44302/api/releaseTask")
    .then(response => response.json())
    .then(releaseTasks => {
        releaseTasks = releaseTasks.filter(task => task.isVisisble == true);
        appDivLeft.innerHTML = ReleaseTasks(releaseTasks);
        currentSelectedRowTaskID = HandleTaskRows.highlightSelectedRow();
        HandleTaskRows.highlightSpecificRow(newReleaseTaskID);
        const releaseTaskEndpoint = `https://localhost:44302/api/releaseTask/${newReleaseTaskID}`;
        const releaseTaskCallback = releaseTask => {
            appDivRight.innerHTML = ReleaseTask(releaseTask);
        };
        apiActions.getRequest(releaseTaskEndpoint, releaseTaskCallback);
        currActiveReleaseTasks = releaseTasks;
    })
    .catch(err => console.log(err))
}

function showReleaseTasks() {
    getReleaseTasksShowFirst();
}

appDivRight.addEventListener('click', function () {
    if (event.target.classList.contains('delete_releaseTaskButton')) {
        const releaseTaskId = event.target.parentElement.querySelector('.delete_releaseTaskButton').id;
        const releaseTaskEndpoint = `https://localhost:44302/api/releaseTask/${releaseTaskId}`;

        if (event.shiftKey) {

            swal.fire({
                title: 'Are you sure?',
                text: "This is a permanent deletion!",
                icon: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#d33',
                confirmButtonText: 'Yes, Delete it'
              }).then((result) => {
                if (result.value) {
                    apiActions.deleteRequest2(
                        releaseTaskEndpoint
                    )
                    swal.fire({
                        icon:'success',
                        title:'Task Delete',
                        text:'Task has been deleted.'
                    });
                    getReleaseTasksShowFirst();
                }
              })
        }
        else {
            swal.fire({
                title: 'Are you sure?',
                text: "",
                icon: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#d33',
                confirmButtonText: 'Yes, delete it!'
              }).then((result) => {
                if (result.value) {
                    const releaseEdit = {
                        id: releaseTaskId,
                        IsVisisble: false
                    };

                    apiActions.patchRequest(
                        releaseTaskEndpoint,
                        releaseEdit
                    )

                    swal.fire({
                        icon:'success',
                        title:'Task Delete',
                        text:'Task has been deleted.'
                    });
                    getReleaseTasksShowFirst();
                }
              })
        }
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

async function work(){
    console.log('pause');
    await pause(2000);
    console.log('end pause');
}

async function saveData(releaseEdit){
    console.log('2-in saveData');
    console.log('3-id='+releaseEdit.id);
    const releaseTaskEndpoint = `https://localhost:44302/api/releaseTask/${releaseEdit.id}`;
    await apiActions.putRequest2(
        releaseTaskEndpoint,
        releaseEdit
    )
    console.log('6-end save data');
}

function test1 () {
    console.log('in test1');
}
function showAlert(){
    console.log('in show alert');
    swal.fire({
        icon:'success',
        title:'Task Edit',
        text:'Task has been edited.'
    },test1());
    console.log('after show alert');

}

function saveData2(location, requestBody){
    console.log('2-inSaveData2');
    fetch(location, {
        method: 'PUT',
        body: JSON.stringify(requestBody),
        headers: {
            "Content-Type": "application/json"
        }
    })
        .then(response => response.json())
        .then(showAlert())
        .catch(err => console.log(err))
    console.log('3-end of save data2');

}


appDivRight.addEventListener('click', function () {
    if (event.target.classList.contains('edit-releaseTask__submit')) {
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
        // apiActions.putRequest2(
        //     releaseTaskEndpoint,
        //     releaseEdit
        // )

        console.log('1-before');
        //saveData(releaseEdit);
        saveData2(releaseTaskEndpoint,releaseEdit);
        swal.fire({
            title: 'swal title',
            text: 'swal text',
            icon: 'success',
            showCancelButton: false,
            confirmButtonColor: '#3085d6',
            confirmButtonText: 'OK'
        }).then((result) => {
            getReleaseTasksShowCurrent();
            console.log('4-after gettasksShowCurrent');
            const releaseTaskCallback = releaseTask => {
                appDivRight.innerHTML = ReleaseTask(releaseTask);
            };
            console.log('5-before get request');
            apiActions.getRequest(releaseTaskEndpoint, releaseTaskCallback);
            console.log('6-after get request');
    
        })
        //work();
        //pause(2000).then(updateDisplay(releaseTaskId))
        console.log('7-after');
        // swal.fire({
        //     icon:'success',
        //     title:'Task Edit',
        //     text:'Task has been edited.'
        // });

        // console.log('8-after swal');
        // getReleaseTasksShowCurrent();
        // console.log('12-after gettasksShowCurrent');
        // const releaseTaskCallback = releaseTask => {
        //     appDivRight.innerHTML = ReleaseTask(releaseTask);
        // };
        // console.log('13-before get request');
        // apiActions.getRequest(releaseTaskEndpoint, releaseTaskCallback);
        // console.log('16-after get request');
    }
})

async function updateDisplay(releaseTaskId){
    console.log('in updateDisplay');
    const releaseTaskEndpoint = await `https://localhost:44302/api/releaseTask/${releaseTaskId}`;

    getReleaseTasksShowCurrent();
    const releaseTaskCallback = releaseTask => {
        console.log('before load specific task');
        appDivRight.innerHTML = ReleaseTask(releaseTask);
        console.log('after load specific task');
    };
    apiActions.getRequest(releaseTaskEndpoint, releaseTaskCallback);
    console.log('end of updateDisplay');

}

appDivLeft.addEventListener('click', function () {
    if (event.target.parentElement != null && event.target.parentElement.classList.contains('add__releaseTaskButton')) {
        const statusDrop = HandleDropDowns.StatusDropDown();
        const priorityDrop = HandleDropDowns.PriorityDropDown();
        const employeeDrop = HandleDropDowns.EmployeeDropDown();
        const currentDate = new Date();
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
        fetch("https://localhost:44302/api/releaseTask", {
            method: 'POST',
            headers: {
                "Content-Type": "application/json"
            },
            body: JSON.stringify(requestBody),
        })
            .then(response => response.json())
            .then(
                data => {
                    newReleaseTaskID = data})
            .catch(err => console.log(err))

            swal.fire({
                icon:'success',
                title:'Task Add',
                text:'Task has been added.'
            });

        getReleaseTasksShowNew();
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

        swal.fire({
            icon:'success',
            title:'Add Comment',
            text:'Comment had been added.'
        });

        getReleaseTasksShowCurrent();
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
        console.log(curr);
        console.log(now);
        console.log(rt.currentStatusID);
        if ((curr < now) && (rt.currentStatusID < 3)) {
                //alert('Warning.  The following task is overdue\n\n' + rt.name);
                swal.fire({
                    icon:'info',
                    title:'Warning. This Task is Due',
                    text: rt.name
                });
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
                    appDiv.innerHTML = ReleaseTasks(releaseTasks);
                    appDivLeft.innerHTML = null;
                    appDivRight.innerHTML = null;
                    //currentSelectedRowTaskID = HandleTaskRows.highlightSelectedRow();
                    //HandleTaskRows.highlightSpecificRow(1);
                })
                .catch(err => console.log(err))
                swal.fire({
                    icon:'info',
                    title:'ALL Tasks View',
                    text:'Warning. This is informational only.  Any click will return to the main program.'
                });
            }
        else {
            ExecuteTimer();
        }
    }
})

appDiv.addEventListener('click', function() {
    appDiv.innerHTML = null;
    showReleaseTasks();
})
