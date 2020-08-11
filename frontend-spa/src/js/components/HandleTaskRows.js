import apiActions from '../api/apiActions';
import ReleaseTask from './ReleaseTask';
import HandleDropDowns from './HandleDropDowns';
import SelectDropDownID from './SelectDropDownID';


const appDiv = document.querySelector('.app');
const appDivLeft = document.querySelector('.appLeft');
const appDivRight = document.querySelector('.appRight');
var selectedRowId = 0;

function OnSelectedIndexChange(){
    console.log('left status clicked');
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
                rowsNotSelected[row].style.backgroundColor = "white";
                rowsNotSelected[row].classList.remove('selected');
            }
            var rowSelected = table.getElementsByTagName('tr')[rowId];
            rowSelected.style.backgroundColor = "rgb(173, 204, 209)";
            rowSelected.className += " selected";
            //rowSelected.cells[2].innerHTML = "TEST";
            
            const statusDrop = HandleDropDowns.StatusDropDown();
            //console.log(statusDrop);
            //const statusDropHTML =`<select id="statusDropID" class="edit-releaseTask__Status" type="dropdown">${statusDrop}</h4></select>"`
    
            //console.log(statusDropHTML);
            //statusDrop.Attributes.Add("onChange", "return OnSelectedIndexChange();");
            rowSelected.cells[2].innerHTML = `<select id="LeftstatusDropID" class="Leftedit-releaseTask__Status" onChange=OnSelectedIndexChange() type="dropdown">${statusDrop}</select>`;
            SelectDropDownID.selectElement('LeftstatusDropID',2);
            //SelectDropDownID.selectElement('LeftstatusDropID',releaseTaskEdit.currentStatusID);

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
