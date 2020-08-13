import moment from "moment";

export default function ReleaseTask(releaseTask) {

    let imageSrc = "";

    switch (releaseTask.priority.value) {
        case 1:
            imageSrc = "images/chainHigh.png"
            break;
        case 2:
            imageSrc = "images/chainHigh.png"
            break;
        case 3:
            imageSrc = "images/chainHigh.png"
            break;
        case 4:
            imageSrc = "images/chainHigh.png"
            break;
        default:
            imageSrc = "images/rope.png"
    }
    return `
    <div class="IconHeading">
        <img class="priorityColor" id="${releaseTask.currentPriorityID}"src="${imageSrc}" width="100" height="100">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <h2 class="table-2__header"  id="${releaseTask.id}">${releaseTask.id}: ${releaseTask.name}</h2>
    </div>
    <section class="releaseTask__detailsInfo">
        <button class="edit__releaseTaskButton" id="${releaseTask.id}">Edit</button>
        <button class="add__commentButton" id="${releaseTask.id}">Add Comment</button>
        <button class="delete_releaseTaskButton" id="${releaseTask.id}">Delete</button>
        <div class="releaseTask__detailsInfolist">
            <p class="releaseTask__currentPriorityName"><b>Priority:</b><span class="prioritytest" id="${releaseTask.currentPriorityID}"> ${releaseTask.priority.name}</span></p>
            <p class="releaseTask__currentDueTime"><b>Due:</b> ${moment(releaseTask.currentDueTime).format(('MMMM Do YYYY, h:mm a'))}</p>
            <p class="releaseTask__currentStatusName"><b>Status:</b> ${releaseTask.status.name}</p>   
            <p class="releaseTask__assignedEmployeeName"><b>Assigned To:</b> ${releaseTask.employee.name}</p>
            <p class="releaseTask__description"><b>Description:</b> ${releaseTask.description}</p>
            <p class="releaseTask__lastModifiedDate"><b>Last Modified:</b> ${moment(releaseTask.lastModifiedDate).format(('MMMM Do YYYY, h:mm a'))}</p>
            <p class="releaseTask__comment"><b>Comments:</b>
                ${releaseTask.comments.map(comment => {
                    return `
                    <li type="date">${comment.details}</li>
                    `
                }).join("")}
            </p>
            <p class="releaseTask__createdDate"><b>Created:</b> ${moment(releaseTask.createdDate).format(('MMMM Do YYYY, h:mm a'))}</p>
        </div>
    </section>

    `

}