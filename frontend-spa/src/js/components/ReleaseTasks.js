export default function ReleaseTasks(releaseTasks) {
    return `
        <h1><u>Release Tasks123</h1></u>
        <br>
        <section class="releaseTask__buttons">
        <button><a href="#" class="add-releaseTask__button"><b>New Task</b></a></button>
        <button><a href="#" class="edit-releaseTask__button"><em>Change A Task</em></a></button>
        </section>
        <section>
        <div class="container">
            <div class="floatLeft">
                <table class="table-1" style="width:100%; float:left">        
                    <tr  class="table_header">
                        <th style="width:200px" class="table_headerFont">ID</th>
                        <th style="width:300px">Task Name</th>
                        <th style="width:400px">Status</th>
                        <th style="width:400px">Priority</th>
                        <th style="width:400px">DueTime</th>
                        <th style="width:400px">Assigned To</th>
                    </tr>
        ${releaseTasks.map(releaseTask => {
        return `
             <tr class="table1__rowFont" onclick="document.table1__rowFont.style.backgroundColor = 'yellow';">
                <td>${releaseTask.id}</td>
                <td><a href="#" class="releaseTask__info" id="${releaseTask.id}">${releaseTask.name}</a></td>
                <td>${releaseTask.currentStatusID}</td>
                <td>${releaseTask.currentPriorityID}</td>
                <td>${releaseTask.currentDueTime}</td>
                <td>${releaseTask.assignedEmployeeID}</td>
            </tr>
                `
            }).join("")}
                </table>
            </div>    
        </div>
        </section>
    `
}