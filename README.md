# Umbraco Open AI Content App
This is a content app for Umbraco version 11 which gives content editors ability to use OpenAI directly inside Umbraco whilst editing content.

The content app uses OpenAI completions API, this API finishes a subject, you should phrase your subjects similar to "Software prototyping is useful because" to get the most out of the response.

## Usage
1. Head over to https://openai.com/api/ to create an account and follow steps to get an API key.
2. Install this package via nuGet. https://www.nuget.org/packages/Absurd.Umbraco.OpenAI/
3. Once installed add the following config values in appSettings
```json
  "OpenAI": {
    "ApiKey": "YOUR_APIKEY"
  }
  ```
4. Run Umbraco
5. You should see content app in the content section.

## Dependencies
This package utilizes the following open source project: https://www.nuget.org/packages/OpenAI


## Demo
![alt text](https://raw.githubusercontent.com/absurdltd/Absurd.Umbraco.OpenAI/master/readme/readmedemo.gif "Demo of the content app")
