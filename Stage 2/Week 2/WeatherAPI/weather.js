import fetch from "fetch";

const apiUrl = "https://api.weather.gov/gridpoints/";

 const getWeather = async (city) => {
 //const response = await fetch(`${apiUrl}${city}`);
 //ApiString = ApiString + theNewOffice + "/31,80/forecast";
// const response = await fetch('${apiUrl}${city}');
 const response = await fetch('${apiUrl}+ "OMA/31,80/forecast";');
 const data = await response.json();
 return data;
};

const renderWeather = (data) => {
 const weatherDiv = document.getElementById("weather");
 weatherDiv.innerHTML = `
 <h2>Weather for ${data.name}</h2>
 <p>Temperature: ${data.temp}°F</p>
 <p>Conditions: ${data.weather}</p>
`;
};

document.getElementById("search").addEventListener("click", async () => {
 const city = document.getElementById("city").value;
 const weatherData = await getWeather(city);
 renderWeather(weatherData);
});