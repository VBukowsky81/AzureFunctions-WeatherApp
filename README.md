# AzureFunctions-WeatherApp
Azure Functions, Azure Functions Apps, REST, API's, etc

Hello, and good day all

Service deployed on Azure at https://azurefunctionweatherapp.azurewebsites.net

Function URL at https://azurefunctionweatherapp.azurewebsites.net/api/AzureFunctionWeatherApp?code=LIhtu65TO9wTB/FCi1u2sTHYRK5aKPnk1Qc5XK52XFRwYTaqM4PNaA==

Use Postman, or whatever you prefer for API calls. Use above Function URL, and use Query Key "cityname", and values are city names, like London or Paris. Postman example:

![alt text](https://github.com/VBukowsky81/AzureFunctions-WeatherApp/blob/master/Other/PostmanExample.jpg)

Example full query for Paris: https://azurefunctionweatherapp.azurewebsites.net/api/AzureFunctionWeatherApp?code=LIhtu65TO9wTB/FCi1u2sTHYRK5aKPnk1Qc5XK52XFRwYTaqM4PNaA==&cityname=paris

This here is a quick Azure Functions application, that does service requests for local weather. You provide name of the city in the query, and you get the weather breakdown. The API this uses is OpenWeatherMap's API, one the most popular open source weather providers.

I enjoy working with Azure Functions, it's microservices, at our fingertips. We can do so much with this, as developers. Moreover, it is basically free - I believe up to 1 million operations per month are free. And after that, it is still quite cheap.

Anyway, extremely useful Azure feature/service, that I will personally use quite a bit.

So this basically does quick HttpClient GET request on OpenWeatherMap API, using their standard API format. The city name plugs at the query time - I have posted few examples with London, Paris and Berlin below.

Function Apps are completely serverless, by the way. Interesting though - you are still using storage space, to actually locate your function code. But otherwise - completely serverless.

PS Plug in your own API key from OpenWeatherMap, under apiKey, in the main class, if you want to use it locally.

Some service returns:

![alt text](https://github.com/VBukowsky81/AzureFunctions-WeatherApp/blob/master/Other/London.jpg)
![alt text](https://github.com/VBukowsky81/AzureFunctions-WeatherApp/blob/master/Other/Berlin.jpg)
![alt text](https://github.com/VBukowsky81/AzureFunctions-WeatherApp/blob/master/Other/Paris.jpg)

App hosted on Azure, and here are successful calls to its API:
![alt text](https://github.com/VBukowsky81/AzureFunctions-WeatherApp/blob/master/Other/AzureSuccess.jpg)

Good day, and thanks

Vic
