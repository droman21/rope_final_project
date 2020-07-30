export default function Employee(employee, releaseTask) {
    return `
    <h1>${employee.name}</h1>
    ${Employees.employee.map(employee => {
        return `
            <ul class="employee__info">
                <li class="employee__id"> ${employee.id}</li>
                <li class="employee__releaseTaskName" value="${releaseTask.id}"> ${releaseTask.name}</li>
            </ul>
            `
    }).join("")}
    </ul>
    `
}