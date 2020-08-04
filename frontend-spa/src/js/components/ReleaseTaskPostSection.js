export default ReleaseTaskPostSection(releaseTasks) {
    return `
        <h1 class="releaseTaskPostSection"> Create New Release Task <h1>
        <section class="create-releaseTask__post">
            ${releaseTasks.map(releaseTask => {
                return `
        <input class="create-releaseTask__id" type"hidden" value="${releaseTask.Id}>
        <input class="create-releaseTask__name" type="text" value="${releaseTask.name}">
        <input class="create-releaseTask__description" type="text" value="${releaseTask.description}">
        <input class="releaseTask__currentStatusId"  text="dropdown" value="${releaseTask.currentStatusId}">
        <input class="releaseTask__assignedEmployeeId" type="text" value="${releaseTask.employeeId}">
        <input class="releaseTask__isVisible  "type="text" value="${releaseTask.isVisible}">
        <input class="releaseTask__currentDueTime" type="text" value="${releaseTask.currentDueTime}">
        <input class="releaseTask__createdTime" type="text" value="${releaseTask.createdTime}">
        <input class="releaseTask__lastModifiedTime"  type="text" value="${releaseTask.lastModifiedTime}">
        <button class="create-releaseTask__submit">Save Your Task</button>
        </section>
        `
        }).join("")}
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
