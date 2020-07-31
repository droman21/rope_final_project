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

// var priorityThreshold = 10,
//     priorityColor = document.querySelector('.priorityLevel');

// function changeColor(val) {
//     var color = "green";

//     if (val = 3) {
//         color = "yellow"
//     }
//     if (val =2) {
//         color = "orange";
//     }
//     if (val = 1) {
//         color = "red";
//     }

//     priorityColor.style.color = color;
// }

// changeColor(colorThreshold);