import ReleaseTasks from './ReleaseTasks';
import ActiveTasks from './ActiveTasks';
import ReleaseTask from './ReleaseTask';

const appDivLeft = document.querySelector('.appLeft');


function ID(sortorder) {
    console.log('in sort ID table');
    const activeTasks = ActiveTasks.ActiveTasksArray();
    console.log('activeTasks');
    console.log(activeTasks);
    const ReloadActiveTasks = ActiveTasks.ReloadActiveTasksArray();
    console.log('reloadActiveTasks');
    console.log(ReloadActiveTasks);
    
    if (sortorder == "ascending"){
        ReloadActiveTasks.sort((a,b) => (a.id > b.id) ? 1: -1);
        sortorder = "descending";
    }
    else {
        activeTasks.sort((a,b) => (a.id < b.id) ? 1: -1);
        sortorder = "ascending";
    }

    appDivLeft.innerHTML = ReleaseTasks(activeTasks);

    console.log('sortorder to return='+ sortorder);
    return sortorder;
}

function Name(sortorder) {
    const activeTasks = ActiveTasks.ActiveTasksArray();

    if (sortorder == "ascending"){
        activeTasks.sort((a,b) => (a.name > b.name) ? 1: -1);
        sortorder = "descending";
    }
    else {
        activeTasks.sort((a,b) => (a.name < b.name) ? 1: -1);
        sortorder = "ascending";
    }

    appDivLeft.innerHTML = ReleaseTasks(activeTasks);
    return sortorder;
}

function Status(sortorder){
    const activeTasks = ActiveTasks.ActiveTasksArray();
        
    if (sortorder == "ascending"){
        activeTasks.sort((a,b) => (a.currentStatusID > b.currentStatusID) ? 1: -1);
        sortorder = "descending";
    }
    else {
        activeTasks.sort((a,b) => (a.currentStatusID < b.currentStatusID) ? 1: -1);
        sortorder = "ascending";
    }

    appDivLeft.innerHTML = ReleaseTasks(activeTasks);
    return sortorder;

}

function Priority(sortorder){
    const activeTasks = ActiveTasks.ActiveTasksArray();
        
    if (sortorder == "ascending"){
        activeTasks.sort((a,b) => (a.currentPriorityID > b.currentPriorityID) ? 1: -1);
        sortorder = "descending";
    }
    else {
        activeTasks.sort((a,b) => (a.currentPriorityID < b.currentPriorityID) ? 1: -1);
        sortorder = "ascending";
    }

    appDivLeft.innerHTML = ReleaseTasks(activeTasks);
    return sortorder;
}

function Employee (sortorder){
    const activeTasks = ActiveTasks.ActiveTasksArray();
        
    if (sortorder == "ascending"){
        activeTasks.sort((a,b) => (a.employee.name > b.employee.name) ? 1: -1);
        sortorder = "descending";
    }
    else {
        activeTasks.sort((a,b) => (a.employee.name < b.employee.name) ? 1: -1);
        sortorder = "ascending";
    }

    appDivLeft.innerHTML = ReleaseTasks(activeTasks);
    return sortorder;
}

function DueTime (sortorder){
    const activeTasks = ActiveTasks.ActiveTasksArray();
        
    if (sortorder == "ascending"){
        activeTasks.sort((a,b) => (a.currentDueTime > b.currentDueTime) ? 1: -1);
        sortorder = "descending";
    }
    else {
        activeTasks.sort((a,b) => (a.currentDueTime < b.currentDueTime) ? 1: -1);
        sortorder = "ascending";
    }

    appDivLeft.innerHTML = ReleaseTasks(activeTasks);
    return sortorder;
}

export default {
    ID,
    Name,
    Status,
    Priority,
    Employee,
    DueTime
}