export default function Priority(priority) {
    return `
    <h1>${priority.name}</h1>
    ${priority.map(priority => {
        return `
            <ul class="priority__info">
                <li class="priority__id"> ${priority.id}</li>
                <li class="priority__name" ${priority.name}</li>
                <li class="priority__value"> ${priority.value}</li>
            </ul>
            `
    }).join("")}
    </ul>
    `
}