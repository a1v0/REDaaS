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
- `POST /image/`: user posts imageData array for a given picture. API does something like turning each value into a string, turning each digit into binary, then turning it back into decimal and returning new image data (though this needs a cleverer solution, methinks)
