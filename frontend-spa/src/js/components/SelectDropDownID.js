function selectElement(id, valueToSelect){
    let element = document.getElementById(id);
    element.value = valueToSelect;
}

export default{
    selectElement
};