export default ReleaseTasks(releaseTasks) {
    return `
<h1 class="releaseTasks"> Release Tasks <h1>
<section class="releaseTask__list">
    ${releaseTasks.map(releaseTask => {
        return `
            <ul>
                <li class="releaseTask__id" id="${releaseTask.Id}>${releaseTask.name}</li>
                <li class=""releaseTask__description>"${releaseTask.description}</li>
                <li class=""releaseTask__currentStatusId id="${releaseTask.currentStatusId}"></li>
                <li class=""releaseTask__currentPriorityId id="${releaseTask.currentpriorityId}"></li>
                <li class=""releaseTask__assignedEmployeeId id="${releaseTask.employeeId}"></li>
                <li class=""releaseTask__isVisible id="${releaseTask.isVisible}"></li>
                <li class=""releaseTask__currentDueTime id="${releaseTask.currentDueTime}"></li>
                <li class=""releaseTask__createdTime id="${releaseTask.createdTime}"></li>
                <li class=""releaseTask__lastModifiedTime id="${releaseTask.lastModifiedTime}"></li>
            </ul>
        `

    }).join("")}


`
}