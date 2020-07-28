export default function ReleaseTasks(releaseTasks) {
    return `
<h1 class="releaseTasks"> Release Tasks </h1>
<section class="releaseTask__list">
    ${releaseTasks.map(releaseTask => {
            <ul>
                <li class="releaseTask__id" id="${releaseTask.Id}">${releaseTask.name}</li>
                <li class="releaseTask__currentStatusID" id="${releaseTask.currentStatusID}">${releaseTask.currentStatusID}</li>
                <li class="releaseTask__currentPriorityId" id="${releaseTask.currentPriorityId}">${releaseTask.currentPriorityId}</li>
                <li class="releaseTask__assignedEmployeeId" id="${releaseTask.employeeId}">${releaseTask.employeeId}</li>
                <li class="releaseTask__isVisible" id="${releaseTask.isVisible}">${releaseTask.isVisible}</li>
                <li class="releaseTask__currentDueTime" id="${releaseTask.currentDueTime}">${releaseTask.currentDueTime}</li>
                <li class="releaseTask__createdTime" id="${releaseTask.createdTime}">${releaseTask.createdTime}</li>
                <li class="releaseTask__lastModifiedTime" id="${releaseTask.lastModifiedTime}">${releaseTask.lastModifiedTime}</li>
            </ul>

    }).join("")}
    </section>
`
}