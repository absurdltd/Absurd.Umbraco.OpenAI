# Umbraco Open AI Content App
This is a content app for Umbraco version 11 which gives content editors ability to use OpenAI directly inside Umbraco whilst editing content.

## Usage
1. Head over to https://openai.com/api/ to create an account and follow steps to get an API key.
2. Install this package via nuGet. <nugetLink>
3. Once installed add config values in appSettings
```json
  "OpenAI": {
    "ApiKey": "YOUR_APIKEY"
  }
  ```
4. Run Umbraco
5. You should see content app in the content section.

## Dependencies
This package utilizes the following open source project: https://www.nuget.org/packages/OpenAI