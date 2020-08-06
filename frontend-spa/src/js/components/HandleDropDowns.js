
let statusData = fetch("https://localhost:44302/api/status")
.then(response => response.json())
.then(data => {
    statusData = data;
    return statusData;
})
.catch(err => console.log(err));

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

export default {
    StatusDropDown
}
