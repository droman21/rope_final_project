export default function ReleaseTaskPostSection(statusDrop, priorityDrop, employeeDrop, currentSelectedRowID, releaseTask, currentDate) {
    return `
    <section class="post">
        <section class="create-releaseTask__post">
            <h1 class="releaseTaskPostSection">Add New Release Task</h1>
            <button class="create-releaseTask__submit">Save</button>
            <button class="edit__releaseTaskButton__back" id=${currentSelectedRowID}>Back</button>
        
            <h4>Task Name:
            <input class="create-releaseTask__name" type="text" placeholder="Release Task Name"></h4>
        
            <h4>Due Time:
            <input class="create-releaseTask__currentDueTime"  type="datetime-local" value="${Date()}"> </h4>
        
            <h4>Description:</h4><textarea rows="4" cols="50"<input class="create-releaseTask__description" type="text" placeholder="Enter Release Task Description Here"></textarea>
        
            <h4>Status:
            <select id="statusDropID" class="create-releaseTask__Status" type="dropdown">
            ${statusDrop}</h4>
            </select>

            <h4>Priority:
            <select id="priorityDropID" class="create-releaseTask__Priority" type="dropdown">
            ${priorityDrop}</h4>
            </select>

            <h4>Employee:
            <select id="employeeDropID" class="create-releaseTask__Employee" type="dropdown">
            ${employeeDrop}</h4>
            </select>
        </section> 
    </section>
    `
}