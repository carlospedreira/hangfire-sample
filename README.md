# Hangfire Sample

Based on https://docs.hangfire.io/en/latest/getting-started/aspnet-core-applications.html and https://stackoverflow.com/a/46971649.

## Quick start

```bash
$ cd src
$ dotnet run
```

You can view the Hangfire dashboard by navigating to http://localhost:5000/hangfire.

## Known issues

The Hangfire dashboard returns a 403 Forbidden the second time you open it. A work around is to use the link in an incognito window - closing and re-opening that window every time you restart the application.
