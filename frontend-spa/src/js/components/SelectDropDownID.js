function selectElement(id, valueToSelect){
    let element = document.getElementById(id);
    element.value = valueToSelect;
}

function selectElement2(className, valueToSelect){
    let element = document.querySelector(className);
    element.value = valueToSelect;
}

export default{
    selectElement,
    selectElement2
};