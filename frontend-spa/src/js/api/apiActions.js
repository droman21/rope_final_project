function getRequest(location, callback) {
    fetch(location)
        .then(response => response.json())
        .then(data => callback(data))
        .catch(err => console.log(err))
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

function putRequest2(location, requestBody){
    fetch(location, {
        method: 'PUT',
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
    putRequest,
    putRequest2
};