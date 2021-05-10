# Building for Sitecore XP and XM at the same time
This little project is intended to provide flexibility when you are building platforms that need to be able to run on Sitecore XP as well as on Sitecore XM without changing the way that you do the VisitorIdentification.

Read more in my blogpost for the entire story at [Tips on how to build for Sitecore XP and XM](https://www.alexvanwolferen.nl/visitoridentification-and-how-to-deal-with-sitecore-xp-and-xm)

# How to use this?
## Step 1 - Add topology appsetting
Add one single appsetting to your web.config or AppService or whatever configuration store you are using.

For Sitecore XP (not required!)
```xml
<add key="topology:define" value="xp" />
```
For Sitecore XM
```xml
<add key="topology:define" value="xm" />
```

## Step 2 - Update your views
Please update all your view where you use the safe VisitorIdentification.

Replace the using:
```c
@using Sitecore.Mvc.Analytics.Extensions
``` 
with
```c
@using AlexVanWolferen.PlatformExtensions.Extensions 
```

And update the usage of the VisitorIdentification itself, so replace:
```c
@Html.Sitecore().VisitorIdentification()
```
with
```c
@Html.Sitecore().SafeVisitorIdentification()
```

## Step 3 - Publish your code to your site
Publish your code, do not forget to double check the web.config!

Always test this on your local environment before rolling it out to ither stages. You could also use PowerShell to update all your views. Use the Install.ps1 as a starter.

# Happy coding!
Please share the blogpost mentioned, I do appreciate it.