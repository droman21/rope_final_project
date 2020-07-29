export default function ReleaseTask(releaseTask) {
    return `
    <h1>${releaseTask.name}</h1>
    ${releaseTask.map(releaseTask => {
        return `
            <ul class="releaseTask__info">
                <li class="releaseTask__id" > ${releaseTask.id}</li>
                <li class="releaseTask__name" id="${releaseTask.id}"> ${releaseTask.name}</li>
                <li class="releaseTask__description"> ${releaseTask.description}</li>
                <li class="releaseTask__currentStatusId"> ${releaseTask.currentStatusId}</li>
                <li class="releaseTask__currentPriorityId"> ${releaseTask.currentPriorityId}</li>
                <li class="releaseTask__currentDueTime"> ${releaseTask.currentDueTime}</li>
                <li class="releaseTask__createdDate"> ${releaseTask.createdDate}</li>
                <li class="releaseTask__lastModifiedDate"> ${releaseTask.lastModifiedDate}</li>
                <li class="releaseTask__assignedEmployeeId"> ${releaseTask.assignedEmployeeId}</li>
            </ul>
            `
    }).join("")}
    </ul>
    `
}