export default function ReleaseTasks(releaseTasks) {

    return `
        <h1><u>Release Tasks123</h1></u>
        <section>
        <div class="container">
            <div class="floatLeft">
                <table class="table-1" style="width:100%; float:left">        
                    <tr class="table_header">
                        <th class="table_headerFont">ID</th>
                        <th>Task Name</th>
                        <th>Status</th>
                        <th>Priority</th>
                        <th>DueTime</th>
                        <th>Assigned To</th>
                    </tr>
        ${releaseTasks.map(releaseTask => {
        const currStatus=GetStatusName(releaseTask.currentStatusID);
        console.log('currStatus='+currStatus);
        return `
            <tr class="table1__rowFont">
                <td>${releaseTask.id}</td>
                <td><a href="#" class="releaseTask__info" id="${releaseTask.id}">${releaseTask.name}</a></td>
                <td class="releastTask__currentStatusID" id="${releaseTask.currentStatusID}">${releaseTask.currentStatusID}</td>
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

function GetStatusName(currentStatusID){
    console.log('100-statusID='+ currentStatusID);
    let statusName = 'ron';
    console.log('101-before fetch statusName='+statusName);
    fetch(`https://localhost:44302/api/status/${currentStatusID}`)
    .then(response => response.json())
    .then(console.log('102-second then'))
    .then(stname => {
        console.log('103-third then');
        console.log('104-stname='+stname.name);
        statusName = stname.name;
        console.log("105=statusName="+statusName);
    })
    .then(console.log('105-fourth then, statusName='+statusName))
    .catch(err => console.log(err))
    console.log('106-after fetch, statusName='+statusName);
    return statusName;

}