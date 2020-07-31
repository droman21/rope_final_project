export default function ReleaseTask(releaseTask) {

    
    return `
    <h1 class="table-2__header"><a href="#" class="edit__releaseTask" id="${releaseTask.id}">${releaseTask.name}</a></h1>
    <ul class="releaseTask__info">
        <li class="releaseTask__currentDueTime"><u><b>DUE-TIME:</b></u> ${releaseTask.currentDueTime}</li>
        <br>
        <br>
        <li class="releaseTask__id" ><u><b>ID:</b></u> ${releaseTask.id}</li>
        <br>
        <br>
        <li class="releaseTask__name" id="${releaseTask.id}"><u><b>NAME:</b></u> ${releaseTask.name}</li>
        <br>
        <br>
        <li class="releaseTask__description"><u><b>DESCRIPTION:</b></u> ${releaseTask.description}</li>
        <br>
        <br>
        <li class="releaseTask__currentStatusId"><u><b>STATUS-ID:</b></u> ${releaseTask.currentStatusID}</li>   
        <br>
        <br>
        <li class="releaseTask__currentPriorityId"><u><b>PRIORITY-ID:</b></u> ${releaseTask.currentPriorityID}</li>
        <br>
        <br>
        <li class="releaseTask__createdDate"><u><b>CREATED:</b></u> ${releaseTask.createdDate}</li>
        <br>
        <br>
        <li class="releaseTask__lastModifiedDate"><u><b>LAST-MODIFIED:</b></u> ${releaseTask.lastModifiedDate}</li>
        <br>
        <br>
        <li class="releaseTask__assignedEmployeeId"><u><b>ASSIGNED-TO:</b></u> ${releaseTask.assignedEmployeeID}</li>
    </ul>
<button class="edit__releaseTaskButton" id="${releaseTask.id}">Edit</button>

    `
}