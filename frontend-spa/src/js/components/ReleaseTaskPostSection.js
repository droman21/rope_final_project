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

// export default ReleaseTaskPostSection(releaseTask) {
//     return `
// <h1 class="releaseTaskPostSection"> Release Task <h1>
// <section class="releaseTask__list">
//     ${releaseTasks.map(releaseTask => {
//         return `
//             <input class="create-releaseTask__id" type"hidden" id="${releaseTask.Id}>
//             <input class="create-releaseTask__name" type="text" >${releaseTask.name}</input>
//             <input class=""create-releaseTask__description type="text">"${releaseTask.description}</input>
//             <input class=""releaseTask__currentStatusId  text="text"id="${releaseTask.currentStatusId}"></input>
//             <input class=""releaseTask__currentPriorityId  type"text" id="${releaseTask.currentpriorityId}"></input>
//             <input class=""releaseTask__assignedEmployeeId type="text" id="${releaseTask.employeeId}"></input>
//             <input class=""releaseTask__isVisible  type="text" id="${releaseTask.isVisible}"></input>
//             <input class=""releaseTask__currentDueTime type="text" id="${releaseTask.currentDueTime}"></input>
//             <input class=""releaseTask__createdTime type="text" id="${releaseTask.createdTime}"></input>
//             <input class=""releaseTask__lastModifiedTime  type="text" id="${releaseTask.lastModifiedTime}"></input> 

//                 ${releaseTasks.map(releaseTask => {
//             return `
//             <ul>
//                 <li class="releaseTask__id" id="${releaseTask.Id}>${releaseTask.name}</li>
//                 <li class=""releaseTask__description>"${releaseTask.description}</li>
//                 <li class=""releaseTask__currentStatusId id="${releaseTask.currentStatusId}"></li>
//                 <li class=""releaseTask__currentPriorityId id="${releaseTask.currentpriorityId}"></li>
//                 <li class=""releaseTask__assignedEmployeeId id="${releaseTask.employeeId}"></li>
//                 <li class=""releaseTask__isVisible id="${releaseTask.isVisible}"></li>
//                 <li class=""releaseTask__currentDueTime id="${releaseTask.currentDueTime}"></li>
//                 <li class=""releaseTask__createdTime id="${releaseTask.createdTime}"></li>
//                 <li class=""releaseTask__lastModifiedTime id="${releaseTask.lastModifiedTime}"></li>
//             </ul>
//                     `
//         })}    
//     }).join("")}


// `
//     }
