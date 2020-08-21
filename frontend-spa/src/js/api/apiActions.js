function getRequest(location, callback) {
    console.log('14-in get request');
    fetch(location)
        .then(response => response.json())
        .then(data => callback(data))
        .catch(err => console.log(err))
    console.log('15-end get request');
}
function getRequest2(location, callback) {
    fetch(location)
        .then(response => response.json())
        .catch(err => console.log(err))
}

function postRequest(location, requestBody, callback) {
    fetch(location, {
        method: 'POST',
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(requestBody),
    })
        .then(response => response.json())
        .then(data => callback(data))
        .catch(err => console.log(err))
}
function postRequest2(location, requestBody) {
    fetch(location, {
        method: 'POST',
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(requestBody),
    })
        .then(response => response.json())
        .catch(err => console.log(err))
}

function deleteRequest(location, callback) {
    fetch(location, {
        method: 'DELETE',
        headers: {
            "Content-Type": "application/json"
        }
    })
        .then(response => response.json())
        .then(data => callback(data))
        .catch(err => console.log(err))
}

function deleteRequest2(location){
    fetch(location, {
        method: 'DELETE',
        headers: {
            "Content-Type": "application/json"
        }
    })
        .then(response => response.json())
        .catch(err => console.log(err))
}

function putRequest(location, requestBody, callback) {
    fetch(location, {
        method: 'PUT',
        body: JSON.stringify(requestBody),
        headers: {
            "Content-Type": "application/json"
        }
    })
        .then(response => response.json())
        .then(data => callback(data))
        .catch(err => console.log(err))
}

async function putRequest2(location, requestBody){
    console.log('4-in put request');
    await fetch(location, {
        method: 'PUT',
        body: JSON.stringify(requestBody),
        headers: {
            "Content-Type": "application/json"
        }
    })
        .then(response => response.json())
        .catch(err => console.log(err))
    console.log('5-end put request');
}

function patchRequest(location, requestBody){
    fetch(location, {
        method: 'PATCH',
        body: JSON.stringify(requestBody),
        headers: {
            "Content-Type": "application/json"
        }
    })
        .then(response => response.json())
        .catch(err => console.log(err))
}

export default {
    getRequest,
    getRequest2,
    postRequest,
    postRequest2,
    deleteRequest,
    deleteRequest2,
    putRequest,
    putRequest2,
    patchRequest
};