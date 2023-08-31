async function getArtists(term){
  
    var ApiString = "https://itunes.apple.com/search?term=";
   // var theNewOffice = document.getElementById("newOffice","CLE").value;
   // ApiString = ApiString + theNewOffice + "/31,80/forecast";
    ApiString = "https://itunes.apple.com/search?term=" + term + "&wrapperType=track&entity=album&type=Artist&country=US&limit=25";
  
    console.log(ApiString);
  
    var response = await fetch(ApiString);
    var jsonData = await response.json();

    console.log(jsonData);
    //document.getElementById("myJson").innerHTML =  JSON.stringify(jsonData);
    var items = 0;
   // items=jsonData.properties.results.length; // array length
    items=jsonData.results.length; // array length
    document.getElementById("items").innerHTML =  "";
    document.getElementById("items").innerHTML +=  "items = " + items;
    console.log("items = " + items);
    console.log("items = ");
    document.getElementById("artistName").innerHTML = "";
    document.getElementById("collectionName").innerHTML = "";
    document.getElementById("trackName").innerHTML = "";
    
    for (let i=0;i<items;i++){
      //document.getElementById("artistName").innerHTML += jsonData.properties.results[i].artistName + "<br><br>";
      document.getElementById("artistName").innerHTML += jsonData.results[i].artistName + "<br><br>";
      document.getElementById("collectionName").innerHTML += jsonData.results[i].collectionName + "<br><br>";
      document.getElementById("trackName").innerHTML += jsonData.results[i].collectionPrice + " cost" + "<br><br>";
    }
    //const resultsDiv = document.getElementById("results");
}
