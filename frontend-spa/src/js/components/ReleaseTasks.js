export default function ReleaseTasks(releaseTasks) {
    return `
        <h1>Release Tasks</h1>
        <br>
        <section class="releaseTask__buttons">
        <button class="add__releaseTaskButton"><b>New Task</b></a></button> <button type="button" name="alertButton" id="alert">Reminders</button>
        </section>
        <section>
            <div class="floatLeft-container">
                <table class="table1" id="table1Id" style="width:100%; float:left"> 
                <tbody class="table1__body">       
                    <tr class="table_header">
                        <th class="table_headerFont">ID</th>
                        <th>Task Name</th>
                        <th>Status</th>
                        <th>Priority</th>
                        <th>DueTime</th>
                        <th>Assigned To</th>
                    </tr>
        ${releaseTasks.map(releaseTask => {
        var dueTime = FormatTime(releaseTask.currentDueTime);
        //console.log(releaseTask);
        //console.log(releaseTask.status.name);
        return `
            <tr id="rowId" class="table1__rowFont">
                <td>${releaseTask.id}</td>
                <td class="releaseTask__info" id="${releaseTask.id}">${releaseTask.name}</td>
                <td id="${releaseTask.currentStatusID}">${releaseTask.status.name}</td>
                <td id="${releaseTask.currentPriorityID}">${releaseTask.priority.name}</td>
                <td>${dueTime}</td>
                <td id="${releaseTask.assignedEmployeeID}">${releaseTask.employee.name}</td>
            </tr>
                `
    }).join("")}
                </tbody>
            </table>
            </div>    
        </section>
    `
}

function FormatTime(time){
    //TODO:  Change this to use Momento package
    var date = new Date(time);
    return (date.getHours()<10?'0':'') + date.getHours() + ":" +  (date.getMinutes()<10?'0':'') + date.getMinutes() + ":" + (date.getSeconds()<10?'0':'') + date.getSeconds();
}
