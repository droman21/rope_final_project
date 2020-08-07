import ReleaseTasks from './ReleaseTasks';
import ActiveTasks from './ActiveTasks';

const appDivLeft = document.querySelector('.appLeft');


function SortTable(sortorder, property) {
    console.log('in sort table');
    const activeTasks = ActiveTasks.ActiveTasksArray();
    let a = 'a.' + property;
    let b = 'b.' + property;
    console.log(a);
    console.log(b);

    if (sortorder == "ascending"){
        activeTasks.sort((a,b) => (a.id > b.id) ? 1: -1);
        sortorder = "descending";
    }
    else {
        activeTasks.sort((a,b) => (a.id < b.id) ? 1: -1);
        sortorder = "ascending";
    }

    appDivLeft.innerHTML = ReleaseTasks(activeTasks);
    //currentSelectedRowID = HandleTaskRows.highlightSelectedRow();
    //HandleTaskRows.highlightSpecificRow(1);

    console.log('sortorder to return='+ sortorder);
    return sortorder;

}

export default {
    SortTable
}