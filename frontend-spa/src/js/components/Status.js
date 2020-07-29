
export default function Status(status) {
    return `
    <h1>${status.name}</h1>
    ${status.map(status => {
        return `
            <ul class="status__info">
                <li class="status__id"> ${status.id}</li>
                <li class="status__name" ${status.name}</li>
                <li class="status__value"> ${status.value}</li>
            </ul>
            `
    }).join("")}
    </ul>
    `
}