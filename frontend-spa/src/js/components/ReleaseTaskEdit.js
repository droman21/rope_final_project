//import Employee from "./Employee";
export default function ReleaseTaskEdit(releaseTask, statusDrop,priorityDrop,employeeDrop) {
    return `
    <h1>Edit the release task fields below.</h1>
        <input class="edit-releaseTask__id" hidden="true" value="${releaseTask.id}">
        <input class="edit-releaseTask__createdDate" hidden="true" value="${releaseTask.createdDate}">
        <h4>Due:
        <input class="edit-releaseTask__currentDueTime" value="${releaseTask.currentDueTime}"></h4>
        <h4>Task Name:
        <input class="edit-releaseTask__name" type="text" value="${releaseTask.name}"></h4>
        <h4>Description:
        <input class="edit-releaseTask__description" type="text" value="${releaseTask.description}"></h4>
        <h4>Status:
        ${statusDrop}</h4>
        <h4>Priority:
        ${priorityDrop}</h4>
        <h4>Assigned To:
        ${employeeDrop}</h4>
        <h4></h4>
        <br><br>
        <button class="edit-releaseTask__submit"> Save Your Changes </button>
        <button class="edit__releaseTaskButton__back" id=${releaseTask.id}>Back</button>

    `
}