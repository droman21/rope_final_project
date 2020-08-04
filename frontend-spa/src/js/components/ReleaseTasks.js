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
        //console.log('1');
        //var statusName = getStatusName(releaseTask.currentStatusID);
        //console.log('2');
        //console.log('statusname');
        //console.log(statusName);
        //console.log('3');
        console.log(releaseTask);
        console.log(releaseTask.status.name);
        //var getName = StatusName(releaseTask.currentStatusID);
        //alert('I HATE JAVASCRIPT!');
        //console.log(getName);
        return `
            <tr id="table1__rowHighlight" class="table1__rowFont">
                <td>${releaseTask.id}</td>
                <td class="releaseTask__info" id="${releaseTask.id}">${releaseTask.name}</td>
                <td id="${releaseTask.currentStatusID}">${releaseTask.status.name}</td>
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
    //TODO:  Change this to use Momento package
    var date = new Date(time);
    return (date.getHours()<10?'0':'') + date.getHours() + ":" +  (date.getMinutes()<10?'0':'') + date.getMinutes() + ":" + (date.getSeconds()<10?'0':'') + date.getSeconds();
}

function getStatusName(statusId) {
    console.log(4);
    //const statusEndpoint = `https://localhost:44302/api/status/${statusId}`;
    let statusName='test';
    fetch(`https://localhost:44302/api/status/${statusId}`)
        .then((response) => response.json())
        //.then(data => console.log(data))
        //.then(data => console.log(data.name))
        .then((data) => {
            console.log(5);
            console.log(data.name);
            statusName=data.name;
            console.log(statusName);
            console.log(6);
            //return data.name;})
            //return "test";
        })
        .catch(err => console.log(err))
        console.log(7);

        return statusName;
}
