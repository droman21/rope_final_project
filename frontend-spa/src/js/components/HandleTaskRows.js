import apiActions from '../api/apiActions';
import ReleaseTask from './ReleaseTask';

const appDiv = document.querySelector('.app');
const appDivLeft = document.querySelector('.appLeft');
const appDivRight = document.querySelector('.appRight');
var selectedRowId = 0;

function highlightSelectedRow() {
    var table = document.getElementById('table1Id');
    var cells = table.getElementsByTagName('td');
    
    for (let i = 0; i < cells.length; i++) {
        var cell = cells[i];
        cell.onclick = function () {
            var rowId = this.parentNode.rowIndex;
            selectedRowId = rowId;
            var rowsNotSelected = table.getElementsByTagName('tr');
            for (var row = 1; row < rowsNotSelected.length; row++) {
                rowsNotSelected[row].style.backgroundColor = "white";
                rowsNotSelected[row].classList.remove('selected');
            }
            var rowSelected = table.getElementsByTagName('tr')[rowId];
            rowSelected.style.backgroundColor = "rgb(173, 204, 209)";
            rowSelected.className += " selected";

            const releaseTaskId = rowSelected.cells[0].innerHTML;
            const releaseTaskEndpoint = `https://localhost:44302/api/releaseTask/${releaseTaskId}`;
            const releaseTaskCallback = releaseTask => {
                appDivRight.innerHTML = ReleaseTask(releaseTask);
            };
            apiActions.getRequest(releaseTaskEndpoint, releaseTaskCallback);
        }
    }
    return selectedRowId;
}

function highlightSpecificRow(rowId) {
    var table = document.getElementById('table1Id');
    var rowSelected = table.getElementsByTagName('tr')[rowId];
    rowSelected.style.backgroundColor = "rgb(173, 204, 209)";
    rowSelected.className += " selected";
}

export default {
    highlightSelectedRow,
    highlightSpecificRow
}
