export default function ReleaseTask(releaseTask) {
    return `
    <h1 class="table-2__header"  id="${releaseTask.id}">${releaseTask.name}</h1>
    <section class="releaseTask__detailsInfo">
        <ul class="releaseTask__detailsInfolist">
            <li class="releaseTask__currentDueTime"><b>DUE-TIME:</b> ${releaseTask.currentDueTime}</li>
            <br>
            <li class="releaseTask__id" ><b>ID:</b> ${releaseTask.id}</li>
            <br>
            <li class="releaseTask__name" id="${releaseTask.id}"><b>NAME:</b> ${releaseTask.name}</li>
            <br>
            <li class="releaseTask__description"><b>DESCRIPTION:</b> ${releaseTask.description}</li>
            <br>
            <li class="releaseTask__currentStatusName"><b>STATUS-NAME:</b> ${releaseTask.status.name}</li>   
            <br>
            <li class="releaseTask__currentPriorityName"><b>PRIORITY-NAME:</b> ${releaseTask.priority.name}</li>
            <br>
            <li class="releaseTask__createdDate"><b>CREATED:</b> ${releaseTask.createdDate}</li>
            <br>
            <li class="releaseTask__lastModifiedDate"><b>LAST-MODIFIED:</b> ${releaseTask.lastModifiedDate}</li>
            <br>
            <li class="releaseTask__assignedEmployeeName"><b>ASSIGNED-TO:</b> ${releaseTask.employee.name}</li>
            <br>
        </ul>
        <div class="edit-button">
            <button class="edit__releaseTaskButton" id="${releaseTask.id}">Edit</button>
        </div>
    </section>

    `
}