//import Employee from "./Employee";
export default function ReleaseTaskEdit(releaseTask) {
    return `
        <h1>Edit the release task fields below.</h1>
        <h3>Task ID:
        <input class="edit-releaseTask__id" value="${releaseTask.id}"></h3>
        <h3>Task Name:
        <input class="edit-releaseTask__name" type="text" value="${releaseTask.name}"></h3>
        <h3>Description of Task:
        <input class="edit-releaseTask__description" type="text" value="${releaseTask.description}"></h3>
        <h3>Current Task Status:
        <input class="edit-releaseTask__currentStatus" value="${releaseTask.status.name}"></h3>
        <h3>Priority:
        <input class="edit-releaseTask__currentPriority" value="${releaseTask.priority.name}"></h3>
        <h3>Due Time: 
        <input class="edit-releaseTask__currentDueTime" value="${releaseTask.currentDueTime}"></h3>
        <h3>Assigned Employee:
        <input class="edit-releaseTask__assignedEmployeed" value="${releaseTask.employee.name}"></h3><br><br>
        <div class="edit-releaseTask__submitContainer">
        <div class="edit-releaseTask_submitCenter">
        <button class="edit-releaseTask__submit">Save Your Changes</button></div></div>
    `
}