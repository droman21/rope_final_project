import ReleaseTasks from './ReleaseTasks';

const appDivLeft = document.querySelector('.appLeft');

function HighlightSortedColumn(colID){

    document.querySelector('.table_header__ID').style.color = 'black';
    document.querySelector('.table_header__Name').style.color = 'black';
    document.querySelector('.table_header__Status').style.color = 'black';
    document.querySelector('.table_header__Priority').style.color = 'black';
    document.querySelector('.table_header__DueTime').style.color = 'black';
    document.querySelector('.table_header__AssignedTo').style.color = 'black';
    switch (colID)
    {
        case 1:
            document.querySelector('.table_header__ID').style.color = 'blue';
            break;
        case 2:
            document.querySelector('.table_header__Name').style.color = 'blue';
            break;
        case 3:
            document.querySelector('.table_header__Status').style.color = 'blue';
            break;
        case 4:
            document.querySelector('.table_header__Priority').style.color = 'blue';
            break;
        case 5:
            document.querySelector('.table_header__DueTime').style.color = 'blue';
            break;
        case 6:
            document.querySelector('.table_header__AssignedTo').style.color = 'blue';
            break;
    }
}

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
    HighlightSortedColumn(1);
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
    HighlightSortedColumn(2);
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
    HighlightSortedColumn(3);
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
    HighlightSortedColumn(4);
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
    HighlightSortedColumn(6);
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
    HighlightSortedColumn(5);
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