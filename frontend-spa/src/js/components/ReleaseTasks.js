export default function ReleaseTasks(releaseTasks){
    return `
        <h1><u>Release Tasks</h1></u>
            ${releaseTasks.map(releaseTask => {
                return `
            <div id="releaseTasks"
                <ul><article><h2 class='releaseTask__name'>${releaseTask.name}</h2>
            </div></ul></article>
            
                `
            }).join("")}
    `
}