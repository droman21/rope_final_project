import ReleaseTask from "./ReleaseTask";

export default function CommentPost(releaseTaskId, comment) {
    return `
    <h1>Enter the Comment details below.</h1>
    <input class="edit-releaseTask__id" hidden="true" value="${releaseTaskId}">
    <input class="add-comment__details" type="text" placeholder="Add Comment Here">
    <button class="add-comment__submit" id="${releaseTaskId}"> Save Your Changes </button>
    <button class="edit__releaseTaskButton__back" id=${releaseTaskId}>Back</button>



    `
}