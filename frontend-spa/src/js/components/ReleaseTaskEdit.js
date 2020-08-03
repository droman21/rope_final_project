//import Employee from "./Employee";
export default function ReleaseTaskEdit(releaseTask) {
    return `
        <h1>Edit the release task fields below.</h1>
        <h4>Task ID:
        <input class="edit-releaseTask__id" value="${releaseTask.id}"></h4>
        <h4>Task Name:
        <input class="edit-releaseTask__name" type="text" value="${releaseTask.name}"></h4>
        <h4>Description:
        <input class="edit-releaseTask__description" type="text" value="${releaseTask.description}"></h4>
        <h4>Status:
        <input class="edit-releaseTask__currentStatus" type="dropdown" value="${releaseTask.status.name}"></h4>
        <h4>Priority:
        <input class="edit-releaseTask__currentPriority" value="${releaseTask.priority.name}"></h4>
        <h4>Due: 
        <input class="edit-releaseTask__currentDueTime" value="${releaseTask.currentDueTime}"></h4>
        <h4>Assigned Employee:
        <input class="edit-releaseTask__assignedEmployeed" value="${releaseTask.employee.name}"></h4><br><br>
        <div class="edit-releaseTask__submitContainer">
        <div class="edit-releaseTask_submitCenter">
        <button class="edit-releaseTask__submit">Save Your Changes</button></div></div>
    `
}