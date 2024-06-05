...



### Dependencies ###

The service is developed as a .NET C# app. 

Presumably you've already downloaded and as an Admin installed [Visual Studio](https://visualstudio.microsoft.com/downloads/).

The service client is developed as a Typescript Angular app.

### Opening the Solution ###

Navigate to and open `App.Service.sln`.

Do **NOT** start the application - there is some configuration to do first.

### Setting the Startup Solutions ###

In most cases a solution has only one Startup folder. THis one has two - the service and the service client.

* In Explorer, 
* Right click the `App.Service.sln` SOlution node.


### Setting the Startup File to browse to

If you F5 now, you'll get a console that will open, and transpile the Angular based service client.

When it's finished compiling you won't see a browser and you'll be stuck waiting for godot.

When you realise nothign is going to happen you'll notice the following instruction as the final output
of the transpilation process:

```
** Angular Live Development Server is listening on localhost:4201, open your browser on https://localhost:4201/ **
```

This is because `"port": 4201` was set in `angular.json`.


It won't open automatically when you start building, unless you add `--open` to the end of the `ng serve` statement in the `package.json` file.


