## Description ##

This is a directory demonstrating an API controller.



## Implementation Details ##

Using this folder is not best practice for two reasons.

* Firstly, API Controllers should be in the `*.Presentation.Web` assembly.
* Secondly, API Controllers should be in a Logical Module, separate from the Base assembly
  which is just the base for Modules.

Whereever they are, note:
* API Controllers inherit from `ControllerBase`
* Decorated with `[Route("ApiConstants.RestApiRoutePrefix+[controller]")]`
* Decorated with `[ApiController]`

Note:
the Angular client won't be able to see any APIs unless they are
registered in `proxy.conf.js` as per below:

```
const PROXY_CONFIG = [
  {
    context: [
      "/api/value",
      "/api/weatherforecast",
      ...
   ],
   ...
   }
]
```

