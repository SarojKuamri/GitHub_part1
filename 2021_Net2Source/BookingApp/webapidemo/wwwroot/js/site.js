// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

import { error, post } from "jquery";

// Write your JavaScript code.
const url = '';
let todos = [];
function getHotels() {

}
function addHotel() {
    debugger;
    const hotel = {
        HotelName: document.getElementById('HotelName').value,
        HotelType: document.getElementById('HotelType').value,
        Comments: document.getElementById('Comments').value,

    };
    //FetchAPI
    //axios
    fetch(uri, {
        method: 'POST',
        mode: 'cors',
        header: {
            'Accept': 'application/json',
            'Content-Type': 'application/json;charset=utf-8',
            'Access-control-Allow-Origin': '*'
        },
        body: JSON.stringify(hotel)
    })
        .then(response => response.json())
        .then(() => {

            //getHotels();
            // addNameTextbox.value = '';
        })
        .catch(error => console.error('Unable to add item.', error));
}

function DeleteItem(id) {

}

function displayEditForm(id) {

}
function updateItem() {
    const itemId = document.getElementById('edit - id').value;
    const item = {
        id: pareseInt(itemId, 10),
        isComplete: document.getElementById('edit-isComplete').checked,
        name: document.getElementById('edit-name').value.trim()
    };
    fetch('${ uri } / ${ itemId }'), {

        method: 'PUT',
        header: {'Accept','application/json',}

    }

}
function CloseInput() {
}
function _DisplayCount(itemCount) {
}
function _DisplayItems(data) {
}




