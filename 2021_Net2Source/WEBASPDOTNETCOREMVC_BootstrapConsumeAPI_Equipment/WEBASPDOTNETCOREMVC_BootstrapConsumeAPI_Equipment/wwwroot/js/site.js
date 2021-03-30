// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
// Write your JavaScript code.

const uri = 'http://localhost:58904/api/Equipment';
let Equipmentlist = [];

function GetEquipment() {
    fetch(uri, {
        method: 'GET',
        mode: 'cors',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json; charset=utf-8',
            'Access-Control-Allow-Origin': '*'
        },
    })
        .then(response => response.json())
        .then(data => _displayEquipmentList(data))
        .catch(error => console.error('Unable to get items.', error));
}

function addEquipment() {
    debugger;
    const Equipment = {
        equipmentName: document.getElementById('EquipmentName').value,
        totalAmount: document.getElementById('TotalAmount').value,
        purchageDate: document.getElementById('PurchageDate').value
    };
    //Fetch API
    //axios
    //jquery ajax
    //angular http service
    fetch(uri, {
        method: 'POST',
        mode: 'cors',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json; charset=utf-8',
            'Access-Control-Allow-Origin': '*'
        },
        body: JSON.stringify(Equipment)
    })
        .then(response => response.json())
        .then(() => {
            debugger;
            GetEquipment();
            ///addNameTextbox.value = '';
        })
        .catch(error => console.error('Unable to add item.', error));
}

function deleteItem(id) {
    fetch(`${uri}/${id}`, {
        method: 'DELETE'
    })
        .then(() => getItems())
        .catch(error => console.error('Unable to delete item.', error));
}

function displayEditForm(id) {
    const item = Equipmentlist.find(item => item.equipmentID === id);
    debugger;

    document.getElementById('editEquipmentID').value = item.equipmentID;
    document.getElementById('editEquipmentName').value = item.equipmentName;
    document.getElementById('editTotalAmount').value = item.totalAmount;
    document.getElementById('editPurchageDate').value = item.purchageDate;
    document.getElementById('editForm').style.display = 'block';
}
function updateItem() {

    const equipmentID = document.getElementById('editEquipmentID').value;
    const Equipment = {
        EquipmentName: document.getElementById('editEquipmentName').value,
        TotalAmount: document.getElementById('editTotalAmount').value,
        PurchageDate: document.getElementById('editPurchageDate').value
    };

    fetch(`${uri}/${equipmentID}`, {
        method: 'PUT',
        mode: 'cors',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json; charset=utf-8',
            'Access-Control-Allow-Origin': '*'
        },
        body: JSON.stringify(Equipment)
    })
        .then(() => GetEquipment())
        .catch(error => console.error('Unable to update item.', error));

    closeInput();

    return false;
}

function closeInput() {
    document.getElementById('editForm').style.display = 'none';
}

function _displayCount(itemCount) {
    const name = (itemCount === 1) ? 'to-do' : 'to-dos';

    document.getElementById('counter').innerText = `${itemCount} ${name}`;
}

function _displayEquipmentList(data) {
    debugger;
    const tBody = document.getElementById('Equipmentlist');
    tBody.innerHTML = '';

    _displayCount(data.length);

    const button = document.createElement('button');

    data.forEach(item => {
        let lableforId = document.createElement('label');
        lableforId.innerHTML = item.equipmentID;

        let lableforEquipmentName = document.createElement('label');
        lableforEquipmentName.innerHTML = item.equipmentName;

        let lableforTotalAmount = document.createElement('label');
        lableforTotalAmount.innerHTML = item.totalAmount;

        let lableforPurchageDate = document.createElement('label');
        lableforPurchageDate.innerHTML = item.purchageDate;

        let editButton = button.cloneNode(false);
        editButton.innerText = 'Edit';
        editButton.setAttribute('onclick', `displayEditForm(${item.equipmentID})`);

        let deleteButton = button.cloneNode(false);
        deleteButton.innerText = 'Delete';
        deleteButton.setAttribute('onclick', `deleteItem(${item.equipmentID})`);

        let tr = tBody.insertRow();

        let td1 = tr.insertCell(0);
        td1.appendChild(lableforId);

        let td2 = tr.insertCell(1);
        td2.appendChild(lableforEquipmentName);

        let td3 = tr.insertCell(2);
        td3.appendChild(lableforTotalAmount);

        let td4 = tr.insertCell(3);
        td4.appendChild(lableforPurchageDate);

        //let td2 = tr.insertCell(1);
        //let textNode = document.createTextNode(item.name);
        //td2.appendChild(textNode);

        let td5 = tr.insertCell(4);
        td5.appendChild(editButton);

        let td6 = tr.insertCell(5);
        td6.appendChild(deleteButton);
    });

    Equipmentlist = data;
}