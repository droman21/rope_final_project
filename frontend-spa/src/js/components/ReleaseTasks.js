export default function ReleaseTasks(releaseTasks) {
    return `
        <h1><u>Release Tasks123</h1></u>
            ${releaseTasks.map(releaseTask => {
        return `
            <div id="releaseTask">
                <ul>
                <article>
                    <a href="#" class="releaseTask__info" id="${releaseTask.id}">${releaseTask.name}</a>
                </article>
                </ul>
            </div>
            
                `
    }).join("")}
    `
}