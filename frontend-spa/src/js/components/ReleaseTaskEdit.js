
export default function ReleaseTaskEdit(releaseTask, statusDrop, priorityDrop, employeeDrop) {
    return `
    <section class="edit-container">
    <h3 class="edit-releaseTask__header">Edit the release task fields below.</h3>
    <button class="edit-releaseTask__submit">Save</button>
    <button class="edit__releaseTaskButton__back" id=${releaseTask.id}>Back</button>
        <h4 class="releaseTask__detailsInfolist">Task Name:&ensp;&ensp;
        <input class="edit-releaseTask__name" type="text"  value="${releaseTask.name}"></h4>
        <h4 class="releaseTask__detailsInfolist">Description:</h4>
        <textarea class="new" rows="4" cols="50" >${releaseTask.description}</textarea>
        <h4 class="releaseTask__detailsInfolist">Priority:&ensp;&ensp;
        <select id="priorityDropID" class="edit-releaseTask__Priority" type="dropdown">
        ${priorityDrop}</h4>
        </select>

        <h4 class="releaseTask__detailsInfolist" id="style-edit">Due:&ensp;&ensp;
        <input class="edit-releaseTask__currentDueTime" type="datetime-local" value="${releaseTask.currentDueTime}"></h4>
        
        <h4 class="releaseTask__detailsInfolist">Status:&ensp;&ensp;
        <select id="statusDropID" class="edit-releaseTask__Status" type="dropdown">
        ${statusDrop}</h4>
        </select>

        <h4 class="releaseTask__detailsInfolist">Assigned To:&ensp;&ensp;
        <select id="employeeDropID" class="edit-releaseTask__Employee" type="dropdown"></h4>
        ${employeeDrop}
        </select>
        
        <input class="edit-releaseTask__id" hidden="true" value="${releaseTask.id}">
        <input class="edit-releaseTask__createdDate" hidden="true" value="${releaseTask.createdDate}">
        </section>

        
        <h4></h4>

        <br><br>


    `
}

// function selectElement(id, valueToSelect){
//     console.log(valueToSelect);
//     console.log(id);
//     let element = document.getElementById(id);
//     //let element = document.querySelector('.edit-releaseTask__Status');
//     console.log(element);
//     element.value = valueToSelect;
// }
