import apiActions from '../api/apiActions';
import ReleaseTask from './ReleaseTask';
import HandleDropDowns from './HandleDropDowns';
import SelectDropDownID from './SelectDropDownID';


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

    // fetch(releaseTaskEndpoint, {
    // method: 'PATCH',
    // body: JSON.stringify(releaseEdit),
    // headers: {
    //     "Content-Type": "application/json"
    // }
    // })
    //     .then(response => response.json())
    //     .catch(err => console.log(err))

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
            
            //const statusDrop = HandleDropDowns.StatusDropDown();
            // console.log('before set HTML');
            // rowSelected.cells[2].innerHTML = `<select id="${releaseTaskId}" style="width:100px;" class="Leftedit-releaseTask__Status" onChange="${OnSelectedIndexChange()}" type="dropdown">${statusDrop}</select>`;
            // console.log('before set drop value');
            // SelectDropDownID.selectElement2('.Leftedit-releaseTask__Status',2);
            // //SelectDropDownID.selectElement('LeftstatusDropID',releaseTaskEdit.currentStatusID);
            
            const releaseTaskEndpoint = `https://localhost:44302/api/releaseTask/${releaseTaskId}`;
            const releaseTaskCallback = releaseTask => {
                appDivRight.innerHTML = ReleaseTask(releaseTask);
            };
            apiActions.getRequest(releaseTaskEndpoint, releaseTaskCallback);
        }
    }
    return selectedIndex;
}

function highlightSpecificRow(rowId) {
    var table = document.getElementById('table1Id');
    var cells = table.getElementsByTagName('td');
    var rows = table.getElementsByTagName('tr');
    console.log(rows.length);
    for (var row = 1; row < rows.length; row++) {
        console.log(rows[row].cells[0].innerHTML);
        if (row[0].innerHTML == rowId){
            console.log('ID='+cells[0].innerHTML);
            var rowSelected = table.getElementsByTagName('tr')[rowId];
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
