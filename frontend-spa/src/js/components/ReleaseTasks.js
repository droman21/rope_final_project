export default function ReleaseTasks(releaseTasks) {
    return `
        <h1>Release Tasks</h1>
        <br>
        <section class="releaseTask__buttons">
        <button class="add__releaseTaskButton"><b>New Task</b></a></button>
        </section>
        <section>
            <div class="floatLeft-container">
                <table class="table1" id="table1Id" style="width:100%; float:left">        
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
        return `
            <tr id="table1__rowHighlight" class="table1__rowFont">
                <td>${releaseTask.id}</td>
                <td class="releaseTask__info" id="${releaseTask.id}">${releaseTask.name}</td>
                <td>${releaseTask.currentStatusID}</td>
                <td class="priorityLevel">${releaseTask.currentPriorityID}</td>
                <td>${dueTime}</td>
                <td>${releaseTask.assignedEmployeeID}</td>
            </tr>
                `
            }).join("")}
                </table>
            </div>    
        </section>
    `
}

function FormatTime(time){
    var date = new Date(time);
    return (date.getHours()<10?'0':'') + date.getHours() + ":" +  (date.getMinutes()<10?'0':'') + date.getMinutes() + ":" + (date.getSeconds()<10?'0':'') + date.getSeconds();
}
