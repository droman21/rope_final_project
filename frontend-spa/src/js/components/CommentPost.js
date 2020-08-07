export default function CommentPost(releaseTaskId) {
    return `
    <div class="commentpostcomponent"
    <h4>Enter the Comment details below.</h4>
    <input class="edit-releaseTask__id" hidden="true" value="${releaseTaskId}">
    <textarea rows="4" cols="50" <input class="add-comment__details" type="text" placeholder="Add Comment Here"></textarea>
    <br><br>
    <button class="add-comment__submit" id="${releaseTaskId}">Save</button>
    <button class="edit__releaseTaskButton__back" id=${releaseTaskId}>Back</button>


    `
}