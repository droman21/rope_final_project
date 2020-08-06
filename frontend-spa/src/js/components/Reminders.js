
let AllTasks = fetch("https://localhost:44302/api/releaseTask")
.then(response => response.json())
.then(data => {
    AllTasks = data;
    return AllTasks;
})
.catch(err => console.log(err));

function TasksArray(){
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

export default {
    TasksArray
}