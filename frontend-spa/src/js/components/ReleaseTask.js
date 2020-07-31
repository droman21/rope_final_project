export default function ReleaseTask(releaseTask) {

    
    return `
    <h1 class="table-2__header"><a href="#" class="edit__releaseTask" id="${releaseTask.id}">${releaseTask.name}</a></h1>
    <ul class="releaseTask__info">
        <li class="releaseTask__id" >ID: ${releaseTask.id}</li>
        <li class="releaseTask__name" id="${releaseTask.id}">NAME: ${releaseTask.name}</li>
        <li class="releaseTask__description">DESCRIPTION: ${releaseTask.description}</li>
        <li class="releaseTask__currentStatusId">STATUS-ID ${releaseTask.currentStatusID}</li>
        <li class="releaseTask__currentPriorityId">PRIORITY-ID ${releaseTask.currentPriorityID}</li>
        <li class="releaseTask__currentDueTime">DUE-TIME: ${releaseTask.currentDueTime}</li>
        <li class="releaseTask__createdDate">CREATED: ${releaseTask.createdDate}</li>
        <li class="releaseTask__lastModifiedDate">LAST-MODIFIED: ${releaseTask.lastModifiedDate}</li>
        <li class="releaseTask__assignedEmployeeId">ASSIGNED-TO: ${releaseTask.assignedEmployeeID}</li>
    </ul>
<button class="edit__releaseTaskButton" id="${releaseTask.id}">Edit</button>

    `
}