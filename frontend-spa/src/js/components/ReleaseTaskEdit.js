//import Employee from "./Employee";
export default function ReleaseTaskEdit(releaseTask) {
    return `
        <input class="edit-releaseTask__id" value="${releaseTask.id}">
        <input class="edit-releaseTask__name" type="text" value="${releaseTask.name}">
        <input class="edit-releaseTask__description" type="text" value="${releaseTask.description}">
        <input class="edit-releaseTask__currentStatus" value="${releaseTask.status.name}">
        <input class="edit-releaseTask__currentPriority" value="${releaseTask.priority.name}">
        <input class="edit-releaseTask__currentDueTime" value="${releaseTask.currentDueTime}">
        <input class="edit-releaseTask__assignedEmployeed" value="${releaseTask.employee.name}">
        <button class="edit-releaseTask__submit"> Save Your Changes </button>
    `
}