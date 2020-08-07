
let AllTasks = fetch("https://localhost:44302/api/releaseTask", {cache: "no-store"})
.then(response => response.json())
.then(data => {
    data = data.filter(task => task.isVisisble == true);
    AllTasks = data;
    return AllTasks;
})
.catch(err => console.log(err));

function TasksArray(){
    console.log('in Task Array');
    console.log(AllTasks)
    return AllTasks;

}

export default {
    TasksArray
}