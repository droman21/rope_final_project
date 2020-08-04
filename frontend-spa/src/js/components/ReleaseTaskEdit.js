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
        <select class="edit-releaseTask__currentStatus" type="dropdown" value="${releaseTask.status.name}"></h4>
            <option value="new">New</option>
            <option value="in_progress">In Progress</option>
            <option value="done">Done</option>
            <option value="cancelled">Cancelled</option>
        </select>
        <h4>Priority:
        <select class="edit-releaseTask__currentPriority" type="dropdown" value="${releaseTask.priority.name}"></h4>
            <option value="low">Low</option>
            <option value="medium">Medium</option>
            <option value="high">High</option>
            <option value="critical">Critical</option>
        </select>
        <h4>Assigned To:
        <select class="edit-releaseTask__assignedEmployeed" type="dropdown" value="${releaseTask.employee.name}"></h4>
            <option value="dakota">Dakota</option>
            <option value="bernard">Bernard</option>
            <option value="ron">Ron</option>
            <option value="dan">Dan</option>
        </select>
        <br><br>
        <button class="edit-releaseTask__submit"> Save Your Changes </button>
        <button class="edit__releaseTaskButton__back" id=${releaseTask.id}>Back</button>

    `
}