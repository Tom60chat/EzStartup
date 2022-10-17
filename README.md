# EzStartup

Easily start your application with Windows on startup.

## Download:

[Last release](https://github.com/Tom60chat/Chrome-Rich-Presence/releases)

## How to use?

Toggle app startup:
```csharp
if (EzStartup.IsStartupSet())
    EzStartup.RemoveStartup();
else
    EzStartup.SetStartup();
```
  
  
Check if the app is registered to start with Windows:  
`
EzStartup.IsStartupSet()
`  
  
Register your app to start with Windows:  
`
EzStartup.SetStartup()
`  
  
Unregister your app to start with Windows:  
`
EzStartup.SetStartup()
`  
