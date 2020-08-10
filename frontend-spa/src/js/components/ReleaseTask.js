import moment from "moment";

export default function ReleaseTask(releaseTask) {

    let imageSrc = "";

    switch(releaseTask.priority.value){
        case 1:
            imageSrc="images/critical.png"
            break;
        case 2:
            imageSrc="images/high.png"
            break;
        case 3:
            imageSrc="images/medium.png"
            break;
        case 4:
            imageSrc="images/low.png"
            break;
        default:
            imageSrc="images/rope.png"
    }
    return `
    <h1 class="table-2__header"  id="${releaseTask.id}">${releaseTask.name}</h1>
    <img src="${imageSrc}" width="100" height="100">
    <section class="releaseTask__detailsInfo">
        <ul class="releaseTask__detailsInfolist">
            <li class="releaseTask__currentDueTime"><b>Due:</b> ${moment(releaseTask.currentDueTime).format(('MMMM Do YYYY, h:mm a'))}</li>
            <br>
            <li class="releaseTask__id" ><b>ID:</b> ${releaseTask.id}</li>
            <br>
            <li class="releaseTask__name" id="${releaseTask.id}"><b>Task Name:</b> ${releaseTask.name}</li>
            <br>
            <li class="releaseTask__description"><b>Description:</b> ${releaseTask.description}</li>
            <br>
            <li class="releaseTask__currentStatusName"><b>Status:</b> ${releaseTask.status.name}</li>   
            <br>
            <li class="releaseTask__currentPriorityName"><b>Priority:</b> ${releaseTask.priority.name}</li>
            <br>
            <li class="releaseTask__createdDate"><b>Created:</b> ${moment(releaseTask.createdDate).format(('MMMM Do YYYY, h:mm a'))}</li>
            <br>
            <li class="releaseTask__lastModifiedDate"><b>Last Modified:</b> ${moment(releaseTask.lastModifiedDate).format(('MMMM Do YYYY, h:mm a'))}</li>
            <br>
            <li class="releaseTask__assignedEmployeeName"><b>Assigned To:</b> ${releaseTask.employee.name}</li>
            <br>
            <ul class="releaseTask__comment"><b>Comments:</b>
            ${releaseTask.comments.map(comment => {
                return `
                <li>${comment.details}</li>
                        `
                    }).join("")}
            </ul>
            <br>
        </ul>
            <button class="edit__releaseTaskButton" id="${releaseTask.id}">Edit</button>
            <button class="add__commentButton" id="${releaseTask.id}">Add Comment</button>
            <button class="delete_releaseTaskButton" id="${releaseTask.id}">Delete</button>
        
    </section>

    `

}