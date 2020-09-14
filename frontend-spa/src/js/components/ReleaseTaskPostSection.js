export default function ReleaseTaskPostSection(statusDrop, priorityDrop, employeeDrop, currentSelectedRowID, releaseTask, currentDate) {
    return `
    <section class="post">
        <section class="create-releaseTask__post">
            <h1 class="releaseTaskPostSection">Add New Release Task</h1>
            <button class="create-releaseTask__submit">Save</button>
            <button class="edit__releaseTaskButton__back" id=${currentSelectedRowID}>Back</button>
        
            <h4 class="releaseTask__detailsInfolist">Task Name:&ensp;&ensp;
            <input class="create-releaseTask__name" type="text" size="37" placeholder="Release Task Name"></h4>
        
            <h4 class="releaseTask__detailsInfolist">Due Time:&ensp;&ensp;
            <input class="create-releaseTask__currentDueTime"  type="datetime-local" value="${Date()}"> </h4>
        
            <h4 class="releaseTask__detailsInfolist">Description:</h4><textarea rows="4" cols="50"<input class="create-releaseTask__description" type="text" placeholder="Enter Release Task Description Here"></textarea>
        
            <h4 class="releaseTask__detailsInfolist">Status:&ensp;&ensp;
            <select id="statusDropID" class="create-releaseTask__Status" type="dropdown">
            ${statusDrop}</h4>
            </select>

            <h4 class="releaseTask__detailsInfolist">Priority:&ensp;&ensp;
            <select id="priorityDropID" class="create-releaseTask__Priority" type="dropdown">
            ${priorityDrop}</h4>
            </select>

            <h4 class="releaseTask__detailsInfolist">Employee:&ensp;&ensp;
            <select id="employeeDropID" class="create-releaseTask__Employee" type="dropdown">
            ${employeeDrop}</h4>
            </select>
        </section> 
    </section>
    `
}