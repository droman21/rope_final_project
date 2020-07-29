export default function Employees(employees) {
    return `
        <h1>Employee Roster</h1>
        <ul class="employee-roster>
            ${employees.map(employee => {
        return `
                    <li>
                    <a class="employee__name" id="${employee.id}" href="#"></a>
                    <p class="releaseTask__assignedEmployeeId">
                    </li>
                `
    }).join("")}
        </ul>
    `
}