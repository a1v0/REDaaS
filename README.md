# Romanes Eunt Domus as a Service

REDaaS is the world's leader in mistranslating foreign languages, taking inspiration from [this scene](https://www.youtube.com/watch?v=IIAdHEwiAy8) from _Monty Python's Life of Brian_.

## Tech requirements

This API is written in C# using ASP.NET. To install this API locally, you will need .NET 6 installed, along with Visual Studio.

<!-- mention API key and other details related to Yandex API -->

# DELETE THIS SECTION ONCE API IS COMPLETE

I want to:

- allow users to view output in HTML _or_ JSON (need to look into headers for this)

Endpoints:

- `POST /red/:originalLanguage/:targetLanguage`: translates something incorrectly, word for word
- `GET /brian/:targetLanguage`: returns script of that scene in target language
- `POST /image/`: user posts imageData array for a given picture. API takes each value in cell, converts it to Roman numerals, then sums the ASCII code of each letter (available [here](http://sticksandstones.kstrom.com/appen.html)) and puts that into the array instead. (Need to come up with a solution for when the sum > 255.)

Useful links:

- <https://yandex.com/dev/translate/>
- <https://www.c-sharpcorner.com/article/create-simple-web-api-in-asp-net-mvc/>
- <https://www.abstractapi.com/guides/best-translation-apis-for-developers>
