export default function ReleaseTasks(releaseTasks) {
    return `
        <h1><u>Release Tasks</h1></u>
            ${releaseTasks.map(releaseTask => {
        return `
            <div id="releaseTask">
                <ul>
                <article>
                <a class="releaseTask__name__anchor" id="${releaseTask.id}" href="#">
                    <h2 class='releaseTask__name'>${releaseTask.name}</h2> 
                </a>
                    </article>
                </ul>
            </div>
            
                `
    }).join("")}
    `
}