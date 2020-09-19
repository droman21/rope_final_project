import apiActions from '../api/apiActions';
import ReleaseTask from './ReleaseTask';
// import HandleDropDowns from './HandleDropDowns';
// import SelectDropDownID from './SelectDropDownID';


const appDiv = document.querySelector('.app');
const appDivLeft = document.querySelector('.appLeft');
const appDivRight = document.querySelector('.appRight');
var selectedRowId = 0;
var selectedIndex = null;


function OnSelectedIndexClick(){
    console.log('left status called clicked');
    const selectedItem = event.target.parentElement.querySelector('.Leftedit-releaseTask__Status').value;
    console.log('selected item='+selectedItem);

    const releaseTaskId = event.target.parentElement.querySelector('.Leftedit-releaseTask__Status').id;
    console.log('in html relid='+releaseTaskId);
    const releaseTaskEndpoint = `https://localhost:44302/api/releaseTask/${releaseTaskId}`;

    const releaseEdit = {
            id: releaseTaskId,
            CurrentStatusID: selectedItem
    };

    apiActions.patchRequest(
            releaseTaskEndpoint,
            releaseEdit
    )


}

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
                rowsNotSelected[row].style.backgroundColor = "#107475";
                rowsNotSelected[row].classList.remove('selected');
            }
            var rowSelected = table.getElementsByTagName('tr')[rowId];

            selectedIndex = rowSelected.cells[0].innerHTML;
            console.log(selectedIndex);

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
    return selectedIndex;
}

function highlightSpecificRow(releaseTaskId) {
    var table = document.getElementById('table1Id');
    var rows = table.getElementsByTagName('tr');
    for (var row = 1; row < rows.length; row++) {
        if (rows[row].cells[0].innerHTML == releaseTaskId){
            var rowSelected = table.getElementsByTagName('tr')[row];
            rowSelected.style.backgroundColor = "rgb(173, 204, 209)";
            rowSelected.className += " selected";
            break;
        }
    }
}

export default {
    highlightSelectedRow,
    highlightSpecificRow
}
