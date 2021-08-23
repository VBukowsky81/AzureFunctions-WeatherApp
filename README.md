# AzureFunctions-WeatherApp
Azure Functions, Azure Functions Apps, REST, API's, etc

Hello, and good day all

This here is a quick Azure Functions application, that does service requests for local weather. You provide name of the city in the query, and you get the weather breakdown. The API this uses is OpenWeatherMap API's, one the most popular open source weather providers.

I absolutely love Azure Functions, and what they are capable of doing. This is microservices, at our fingertips. We can do so much with this, as developers. Moreover, it is basically free, a free gift from Microsoft - I believe up to 1 million operations per month are free. And after that, it is still super cheap.

Anyway, extremely useful Azure feature/service, that I will personally use quite a bit.

So this basically does quick HttpClient GET request on OpenWeatherMap API, their usual API format. The city name plugs at the query time, so I have shown a few examples with London, Paris and Berlin below.

Quick app, but these are completely serverless. Interesting though - you are still using storage space, to actually locate your function code. But otherwise - completely serverless.

PS Plug in your own API key from OpenWeatherMap, under apiKey, in the main class, if you want to use it locally.

Some query results:

![alt text](https://github.com/VBukowsky81/AzureFunctions-WeatherApp/blob/master/Other/London.jpg)
![alt text](https://github.com/VBukowsky81/AzureFunctions-WeatherApp/blob/master/Other/Berlin.jpg)
![alt text](https://github.com/VBukowsky81/AzureFunctions-WeatherApp/blob/master/Other/Paris.jpg)

Good day, and thanks

Vic
