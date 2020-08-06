
let statusData = fetch("https://localhost:44302/api/status")
.then(response => response.json())
.then(data => {
    statusData = data;
    return statusData;
})
.catch(err => console.log(err));

let priorityData = fetch("https://localhost:44302/api/priority")
.then(response => response.json())
.then(data => {
    priorityData = data;
    return priorityData;
})
.catch(err => console.log(err));

let employeeData = fetch("https://localhost:44302/api/employee")
.then(response => response.json())
.then(data => {
    employeeData = data;
    return employeeData;
})
.catch(err => console.log(err));

let AllTasks = fetch("https://localhost:44302/api/releaseTask")
.then(response => response.json())
.then(data => {
    AllTasks = data;
    return AllTasks;
})
.catch(err => console.log(err));

function TasksDropDown(){
    console.log('in handle drops');
    console.log(AllTasks)
    console.log('still in handle drops');
    //const tasks = `
    // ${AllTasks.map(task => {
    //     return `
    //     ${task.name}
    //     `
    // })}
    // `
    return AllTasks;

}

function StatusDropDown(){
    const statusDrop = `
    ${statusData.map(sd => {
        return `
        <option class="edit-releaseTask__newStatusID" value="${sd.value}">${sd.name}</option>
        `
    })}
    `
    return statusDrop;
}

function PriorityDropDown() {
    const priorityDrop = `
    ${priorityData.map(pd => {
        return `
        <option class="edit-releaseTask__newPriorityID" value="${pd.value}">${pd.name}</option>
        `
    })}
    `
    return priorityDrop;
}

function EmployeeDropDown() {
    
    const employeeDrop = `
    ${employeeData.map(ed => {
        return `
        <option class="edit-releaseTask__newEmployeeID" value="${ed.id}">${ed.name}</option>
        `
    })}
    `
    return employeeDrop;
}


export default {
    StatusDropDown,
    PriorityDropDown,
    EmployeeDropDown,
    TasksDropDown
}
