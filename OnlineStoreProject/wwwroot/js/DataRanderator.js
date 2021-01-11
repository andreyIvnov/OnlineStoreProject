async function GetData() {
    let promise = await fetch("http://localhost:55803/api/Products/");
    let json = await promise.json();
    return json;
}

async function PostData(data) {

    let promise = await fetch("http://localhost:55803/api/Products/",
                {
                    method: 'POST', 
                    headers:
                    {
                        'Content-Type': 'application/json',
                    },
                    body: JSON.stringify(data),
                });
    let json = await promise.json();
    return json;

}


async function PutData(data) {
    let promise = await fetch("http://localhost:55803/api/Products/" + data.id, {
        method: 'PUT', // or 'PUT'
        headers: {
            'Content-Type': 'application/json',
        },
        body: JSON.stringify(data),
    });
    return;

}

async function onload() {
    let data = await GetData();

    let table = document.getElementById("Container");

    table.innerHTML += 
        `<tr>
<td>Sireal Number</td>
<td>Name of product</td>
<td>Price</td>
<td>Description</td>
<td>Image</td>
<td>Quantity in stoke</td>
        </tr>`
    for (var i = 0; i < data.length; i++) {
        let tr = `<tr>
                    <td>${data[i].id}</td>
                    <td>${data[i].name}</td>
                    <td>${data[i].price}</td>
                    <td>${data[i].description}</td>
                    <td height="250" width="250" ><img src="${data[i].image}" class="img-circle" height="200" width="200" </td>
                    <td>${data[i].quantityInStoke}</td>
                    <td>
                        <button onclick="buyTheProduct(${data[i].id})"  >Buy</button>
                        <button onclick="deleteAProduct(${data[i].id})" >Delete</button>
                    </td>
                  </tr>`
        table.innerHTML += tr;
    }
}


onload();

async function addNew() {
    let name = document.getElementById("name").value;
    let price = document.getElementById("price").value;
    let desc = document.getElementById("desc").value;
    let image = document.getElementById("image").value;
    let quantity = document.getElementById("quantity").value;

    let data = {
        name: name,
        price: price,
        description: desc,
        image: image,
        quantityInStoke: quantity
    }

    await PostData(data);
    clearTable();
    onload();
}



async function buyTheProduct(id) {

}


async function deleteAProduct(id) {
    let promise = await fetch("http://localhost:55803/api/Products/" + id,
        {
            method: 'DELETE',
            headers:
            {
                'Content-Type': 'application/json',
            }
        });
    await promise.json();

    clearTable();
    onLoad();

}

function clearTable() {
    let table = document.getElementById("Container");

    table.innerHTML = "";
}
