const tbody = document.querySelector('#tbody');

const getdata = async () => {
  //const endpoint = "https://api.covid19api.com/summary",
  const endpoint ="https://itunes.apple.com/search?term=elvis&wrapperType=track&entity=album&type=Artist&country=US&limit=25";
        response = await fetch(endpoint),
        data = await response.json(),
        console.log(data);
        results = data.results;

 results.forEach(resultsObj => {
    let {WrapperType, Kind, TrackName, ArtistName, CollectionName, ViewURL, TrackTimeMillis} = resultsObj;
    tbody.innerHTML += <tr>
        <td>${WrapperType}</td>
        <td>${Kind}</td>
        <td>${TrackName}</td>
        <td>${ArtistName}</td>
        <td>${CollectionName}</td>
        <td>${ViewURL}</td>
        <td>${TrackTimeMillis}</td>
    </tr>;
 });

}
getdata();