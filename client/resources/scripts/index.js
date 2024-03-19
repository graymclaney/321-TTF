async function handleOnLoad(){
    url = "http://localhost:5052/api/Books"
    let response = await fetch(url)
    let data = await response.json()
    console.log(data)
}

function GetAllFurniture(){
    const allFurnitureUrl = ""

    fetch(allFurnitureUrl).then(function(response){
        console.log(response)
        return response.json();
    })
}