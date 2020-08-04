//import Employee from "./Employee";
export default function ReleaseTaskEdit(releaseTask) {
    return `
    <h1>Edit the release task fields below.</h1>
        <input class="edit-releaseTask__id" hidden="true" value="${releaseTask.id}">
        <h4>Due:
        <input class="edit-releaseTask__currentDueTime" value="${releaseTask.currentDueTime}"></h4>
        <h4>Task Name:
        <input class="edit-releaseTask__name" type="text" value="${releaseTask.name}"></h4>
        <h4>Description:
        <input class="edit-releaseTask__description" type="text" value="${releaseTask.description}"></h4>
        <h4>Status:
        <input class="edit-releaseTask__currentStatus" value="${releaseTask.status.name}"></h4>
        <h4>Priority:
        <input class="edit-releaseTask__currentPriority" value="${releaseTask.priority.name}"></h4>
        <h4>Assigned To:
        <input class="edit-releaseTask__assignedEmployeed" value="${releaseTask.employee.name}"></h4>
        
        <button class="edit-releaseTask__submit"> Save Your Changes </button>
        <button class="edit__releaseTaskButton__back" id=${releaseTask.id}">Back</button>

    `
}