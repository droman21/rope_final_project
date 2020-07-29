export default ReleaseTaskPostSection(releaseTasks) {
    return `
    <h1 class="releaseTaskPostSection"> Create New Release Task <h1>
    <section class="create-releaseTask__post">
    ${releaseTasks.map(releaseTask => {
        return `
        <input class="create-releaseTask__id" type"hidden" value="${releaseTask.Id}>
        <input class="create-releaseTask__name" type="text" value="${releaseTask.name}">
        <input class="create-releaseTask__description" type="text" value="${releaseTask.description}">
        <input class="releaseTask__currentStatusI"d  text="text" value="${releaseTask.currentStatusId}">
        <input class="releaseTask__assignedEmployeeId" type="text" value="${releaseTask.employeeId}">
        <input class="releaseTask__isVisible  "type="text" value="${releaseTask.isVisible}">
        <input class="releaseTask__currentDueTime" type="text" value="${releaseTask.currentDueTime}">
        <input class="releaseTask__createdTime" type="text" value="${releaseTask.createdTime}">
        <input class="releaseTask__lastModifiedTime"  type="text" value="${releaseTask.lastModifiedTime}">
        </section>
        `
    }).join("")}
    `
}