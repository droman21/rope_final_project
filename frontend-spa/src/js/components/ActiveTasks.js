

// let AllActiveTasks =
//     fetch("https://localhost:44302/api/releaseTask")
//     .then(response => response.json())
//     .then(releaseTasks => {
//         console.log('In let AllActiveTasks');
//         releaseTasks = releaseTasks.filter(task => task.isVisisble == true);
//         AllActiveTasks = releaseTasks;
//         console.log(releaseTasks);
//         //console.log(AllActiveTasks);
//         return AllActiveTasks;
//     })
//     .catch(err => console.log(err));

function getAllACtiveTasks (){
    //let AllActiveTasks =
    console.log('in get ALl acticve');
    fetch("https://localhost:44302/api/releaseTask")
    .then(response => response.json())
    .then(releaseTasks => {
        console.log('In let AllActiveTasks');
        releaseTasks = releaseTasks.filter(task => task.isVisisble == true);
        AllActiveTasks = releaseTasks;
        console.log(releaseTasks);
        //console.log(AllActiveTasks);
        return AllActiveTasks;
    })
    .catch(err => console.log(err));

}

    function ActiveTasksArray(){
        console.log('in ActiveTasksArray');
        //console.log(AllActiveTasks)
        return AllActiveTasks;
    }

    async function ReloadActiveTasksArray(){
        console.log('in ReloadActiveTasks');
        let AllActiveTasks = await fetch("https://localhost:44302/api/releaseTask");
        let data = await AllActiveTasks.json()
        let data2 = await data.filter(task => task.isVisisble == true);
        //let data3 = await data2;
        //let data4 = await data3;
        console.log('in Reload, after fetch');
        console.log(data2);
        console.log('after data 2 log');
        //alert('wait');
        return data2;
    
    }
    
    export default {
        ActiveTasksArray,
        ReloadActiveTasksArray,
        getAllACtiveTasks
    }
