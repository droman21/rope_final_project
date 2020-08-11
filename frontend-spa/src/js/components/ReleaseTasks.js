import moment from "moment";

export default function ReleaseTasks(releaseTasks) {
    return `
    <h1>R.O.P.E. Application</h1>
    <h2>Release Tasks</h2>
    <br>
        <section class="releaseTask__buttons">
        <button class="add__releaseTaskButton"><b>New Task</b></a></button> 
        <button class="reminders__button"><b>Reminders</b></button>
        </section>
        <section>
            <div class="floatLeft-container">
                <table class="table1" id="table1Id" style="width:100%; float:left"> 
                <tbody class="table1__body">       
                    <tr class="table_header">
                        <th class="table_header__ID" style="width: 25px;" class="table_headerFont">ID</th>
                        <th class="table_header__Name" style="width: 250px;">Task Name</th>
                        <th class="table_header__Status" style="width: 120px;">Status</th>
                        <th class="table_header__Priority" style="width: 75px;">Priority</th>
                        <th class="table_header__DueTime" style="width: 150px;">Due Date&Time</th>
                        <th class="table_header__AssignedTo" style="width: 90px;">Assigned</th>
                    </tr>
        ${releaseTasks.map(releaseTask => {
        //var dueTime = FormatTime(releaseTask.currentDueTime);
        //console.log(releaseTask);
        //console.log(releaseTask.status.name);
        return `
            <tr id="${releaseTask.id}" class="table1__rowFont">
                <td>${releaseTask.id}</td>
                <td class="releaseTask__info" id="${releaseTask.id}">${releaseTask.name}</td>
                <td id="${releaseTask.currentStatusID}">${releaseTask.status.name}</td>
                <td class="priority__value" style="background-color:${releaseTask.priority.value}" id="${releaseTask.currentPriorityID}">${releaseTask.priority.name}</td>
                <td>${moment(releaseTask.currentDueTime).format('MMM DD, h:mm a')}</td>
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

