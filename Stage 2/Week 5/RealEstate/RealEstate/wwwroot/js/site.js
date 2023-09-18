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
    const addAddressNoTextbox = document.getElementById('add-addressNo');
    const addAddressStTextbox = document.getElementById('add-addressSt');
    const addAddressStTypeTextbox = document.getElementById('add-addressStType');
    const addCityTextbox = document.getElementById('add-city');
    const addStateTextbox = document.getElementById('add-state');
    const addPriceTextbox = document.getElementById('add-price');
    const addAgentTextbox = document.getElementById('add-agent');
    const item = {
        isSold: false,
        addressNo: addAddressNoTextbox.value.trim(),
        addressSt: addAddressStTextbox.value.trim(),
        addressStType: addAddressStTypeTextbox.value.trim(),
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
            addAddressNoTextbox.value = '';
            addAddressStTextbox.value = '';
            addAddressStTypeTextbox.value = '';
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
    document.getElementById('edit-addressNo').value = item.addressNo;
    document.getElementById('edit-addressSt').value = item.addressSt;
    document.getElementById('edit-addressStType').value = item.addressStType;
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
        addressNo: document.getElementById('edit-addressNo').value.trim(),
        addressSt: document.getElementById('edit-addressSt').value.trim(),
        addressStType: document.getElementById('edit-addressStType').value.trim(),
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

function formatPrice(price) {
    return `${price.toLocaleString('en-US', { style: 'currency', currency: 'USD' })}`;
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
        let textNode7 = document.createTextNode(item.addressNo);
        td2.appendChild(textNode7);

        let td3 = tr.insertCell(2);
        let textNode = document.createTextNode(item.addressSt);
        td3.appendChild(textNode);

        let td4 = tr.insertCell(3);
        let textNode8 = document.createTextNode(item.addressStType);
        td4.appendChild(textNode8);

        let td5 = tr.insertCell(4);
        let textNode2 = document.createTextNode(item.city);
        td5.appendChild(textNode2);

        let td6 = tr.insertCell(5);
        let textNode3 = document.createTextNode(item.state);
        td6.appendChild(textNode3);

        let td7 = tr.insertCell(6);
        let textNode4 = document.createTextNode(formatPrice(item.price));
        td7.appendChild(textNode4);

        let td8 = tr.insertCell(7);
        let textNode5 = document.createTextNode(item.agent);
        td8.appendChild(textNode5);

        let td9 = tr.insertCell(8);
        td9.appendChild(editButton);

        let td10 = tr.insertCell(9);
        td10.appendChild(deleteButton);

        let linkButton = button.cloneNode(false);
     //   string ? addressStPlus = replace(item.addressSt, " ", "+");

        var addresslink = "<a href=https://maps.google.com/?q=" + item.addressNo + "+" + item.addressSt + item.city + item.state + ">Google</a>";
       // linkButton.innerHTML = `<a href="https://www.google.com/maps/place/" + item.address + item.city +item.state >Google</a>`;;
     //   linkButton.innerHTML = '<a href="https://www.google.com/maps/place/" >Google</a>`;
        linkButton.text = "hello";
        linkButton.innerHTML = addresslink;
     //     linkButton.innerHTML = `<a href="https://www.google.com/maps/place/"+ addresslink >Map</a>`;
      //  linkButton.innerHTML = "<a href=https://www.google.com/maps/place/" + item.address + item.city + item.state + ">Google</a>";
       // linkButton.setAttribute('onclick', window.open("https://www.google.com", "_blank");
      
        let td11 = tr.insertCell(10);
        td11.appendChild(linkButton);

   
    });

    listings = data;
}