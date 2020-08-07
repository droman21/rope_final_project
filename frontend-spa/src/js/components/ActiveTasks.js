

let AllActiveTasks =
    fetch("https://localhost:44302/api/releaseTask")
    .then(response => response.json())
    .then(releaseTasks => {
        releaseTasks = releaseTasks.filter(task => task.isVisisble == true);
        AllActiveTasks = releaseTasks;
        return AllActiveTasks;
    })
    .catch(err => console.log(err));

    function ActiveTasksArray(){
        //console.log('in Task Array');
        //console.log(AllActiveTasks)
        return AllActiveTasks;
    }
    
    export default {
        ActiveTasksArray
    }
