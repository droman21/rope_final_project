import Employee from "./Employee";

export default function ReleaseTaskEdit(releaseTask, employeeId) {
    return `
        <input class="edit-releaseTask__id" type="hidden" value="${releaseTask.id}">
        <input class="edit-releaseTask__name" type="text" value="${releaseTask.name}">
        <input class="edit-releaseTask__description" type="text" value="${releaseTask.description}">
        <input class="edit-releaseTask__currentStatusId" type="hidden" value="${releaseTask.currentStatusId}">
        <input class="edit-releaseTask__currentPriorityId" type="hidden" value="${releaseTask.currentPriorityId}">
        <input class="edit-releaseTask__currentDueTime" type="hidden" value="${releaseTask.currentDueTime}">
        <select class="edit-releaseTask__assignedEmployeedId" type="dropdown" value="${releaseTask.assignedEmployeeId}">
        ${Employees.map(employee => {
            return `
            <option class="edit-releaseTask__assignedEmployeeId" value="${employee.assignedEmployeeId}">${employee.name}</option>
            `
        }).join("")}
        </select>
        <button class="edit-releaseTask__button"> Save Your Changes </button>
    `
}