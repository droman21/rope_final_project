import ReleaseTasks from './ReleaseTasks';

const appDivLeft = document.querySelector('.appLeft');

function ID(sortorder, activeTasks) {
    
    if (sortorder == "ascending"){
        activeTasks.sort((a,b) => (a.id > b.id) ? 1: -1);
        sortorder = "descending";
    }
    else {
        activeTasks.sort((a,b) => (a.id < b.id) ? 1: -1);
        sortorder = "ascending";
    }

    appDivLeft.innerHTML = ReleaseTasks(activeTasks);
    return sortorder;
}

function Name(sortorder, activeTasks) {

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

function Status(sortorder, activeTasks){
        
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

function Priority(sortorder, activeTasks){
        
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

function Employee (sortorder, activeTasks){
        
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

function DueTime (sortorder, activeTasks){
        
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