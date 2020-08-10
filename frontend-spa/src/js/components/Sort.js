import ReleaseTasks from './ReleaseTasks';
import ActiveTasks from './ActiveTasks';
import ReleaseTask from './ReleaseTask';

const appDivLeft = document.querySelector('.appLeft');


function ID(sortorder) {
    console.log('in sort ID table');
    //console.log(ActiveTasks.AllActiveTasks);
    const activeTasks = ActiveTasks.ActiveTasksArray();
    const activeTasks1 = ActiveTasks.AllActiveTasks;
    console.log(activeTasks1);
    console.log('activeTasks');
    console.log(activeTasks);
    console.log('after activeTasks log');
    const ReloadActiveTasks = ActiveTasks.ReloadActiveTasksArray();
    console.log('reloadActiveTasks');
    console.log(ReloadActiveTasks);
    
    if (sortorder == "ascending"){
        console.log('in if');
        ReloadActiveTasks.sort((a,b) => (a.id > b.id) ? 1: -1);
        sortorder = "descending";
    }
    else {
        console.log('in else');
        ReloadActiveTasks.sort((a,b) => (a.id < b.id) ? 1: -1);
        sortorder = "ascending";
    }

    console.log('just before ReleaseTasks call');
    appDivLeft.innerHTML = ReleaseTasks(ReloadActiveTasks);

    console.log('After ReleaseTasks call. sortorder to return='+ sortorder);
    return sortorder;
}

async function getNewArray(){
    console.log('in async getnewarray');
    let tasksarray = await ActiveTasks.ReloadActiveTasksArray();
    console.log(tasksarray);
    return tasksarray;
}

function Name(sortorder) {
    const activeTasks = ActiveTasks.ActiveTasksArray();
    //const newActiveTasks = getNewArray();
    console.log('before call to getNewArray');
    //getNewArray(newActiveTasks);
    let newActiveTasks = getNewArray();
    console.log('newactivetasks');
    console.log(newActiveTasks);
    console.log('after newactive tasks');

    if (sortorder == "ascending"){
        newActiveTasks.sort((a,b) => (a.name > b.name) ? 1: -1);
        sortorder = "descending";
    }
    else {
        newActiveTasks.sort((a,b) => (a.name < b.name) ? 1: -1);
        sortorder = "ascending";
    }

    appDivLeft.innerHTML = ReleaseTasks(newActiveTasks);
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