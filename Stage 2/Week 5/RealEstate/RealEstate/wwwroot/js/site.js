// site.js in wwwroot/js
 const uri = 'api/todoitems';

let listings = [];

function getItems() {
    fetch(uri)
        .then(response => response.json())
        .then(data => _displayItems(data))
        .catch(error => console.error('Unable to get items.', error));
}

function addItem() {
    const addAddressTextbox = document.getElementById('add-address');
    const addCityTextbox = document.getElementById('add-city');
    const addStateTextbox = document.getElementById('add-state');
    const addPriceTextbox = document.getElementById('add-price');
    const addAgentTextbox = document.getElementById('add-agent');
    const item = {
        isSold: false,
        address: addAddressTextbox.value.trim(),
        city: addCityTextbox.value.trim(),
        state: addStateTextbox.value.trim(),
        price: addPriceTextbox.value.trim(),
        agent: addAgentTextbox.value.trim()
    };

    fetch(uri, {
        method: 'POST',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(item)
    })
        .then(response => response.json())
        .then(() => {
            getItems();
            addAddressTextbox.value = '';
            addCityTextbox.value = '';
            addStateTextbox.value = '';
            addPriceTextbox.value = '';
            addAgentTextbox.value = '';
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
    const item = listings.find(item => item.id === id);

    document.getElementById('edit-isSold').checked = item.isSold;
    document.getElementById('edit-address').value = item.address;
    document.getElementById('edit-city').value = item.city;
    document.getElementById('edit-state').value = item.state;
    document.getElementById('edit-price').value = item.price;
    document.getElementById('edit-agent').value = item.agent;
    document.getElementById('edit-id').value = item.id;
    document.getElementById('editForm').style.display = 'block';
}

function updateItem() {
    const itemId = document.getElementById('edit-id').value;
    const item = {
        id: parseInt(itemId, 10),
        isSold: document.getElementById('edit-isSold').checked,
        address: document.getElementById('edit-address').value.trim(),
        city: document.getElementById('edit-city').value.trim(),
        state: document.getElementById('edit-state').value.trim(),
        price: document.getElementById('edit-price').value.trim(),
        agent: document.getElementById('edit-agent').value.trim()
    };

    fetch(`${uri}/${itemId}`, {
        method: 'PUT',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(item)
    })
        .then(() => getItems())
        .catch(error => console.error('Unable to update item.', error));

    closeInput();

    return false;
}

function closeInput() {
    document.getElementById('editForm').style.display = 'none';
}

function _displayCount(itemCount) {
    const address = (itemCount === 1) ? 'to-do' : 'Property Listings';

    document.getElementById('counter').innerText = `${itemCount} ${address}`;
}

function _displayItems(data) {
    const tBody = document.getElementById('listings');
    tBody.innerHTML = '';

    _displayCount(data.length);

    const button = document.createElement('button');

    data.forEach(item => {
        let isSoldCheckbox = document.createElement('input');
        isSoldCheckbox.type = 'checkbox';
        isSoldCheckbox.disabled = true;
        isSoldCheckbox.checked = item.isSold;

        let editButton = button.cloneNode(false);
        editButton.innerText = 'Edit';
        editButton.setAttribute('onclick', `displayEditForm(${item.id})`);

        let deleteButton = button.cloneNode(false);
        deleteButton.innerText = 'Delete';
        deleteButton.setAttribute('onclick', `deleteItem(${item.id})`);

        let tr = tBody.insertRow();

        let td1 = tr.insertCell(0);
        td1.appendChild(isSoldCheckbox);

        let td2 = tr.insertCell(1);
        let textNode = document.createTextNode(item.address);
        td2.appendChild(textNode);

        let td3 = tr.insertCell(2);
        let textNode2 = document.createTextNode(item.city);
        td3.appendChild(textNode2);

        let td4 = tr.insertCell(3);
        let textNode3 = document.createTextNode(item.state);
        td4.appendChild(textNode3);

        let td5 = tr.insertCell(4);
        let textNode4 = document.createTextNode(item.price);
        td5.appendChild(textNode4);

        let td6 = tr.insertCell(5);
        let textNode5 = document.createTextNode(item.agent);
        td6.appendChild(textNode5);

        let td7 = tr.insertCell(6);
        td7.appendChild(editButton);

        let td8 = tr.insertCell(7);
        td8.appendChild(deleteButton);
    });

    listings = data;
}