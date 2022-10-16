## Description ##

This folder is the destination of builds
from the following projects:

- App.Infrastructure.Environments.Cloud.Azure
- App.Infrastructure.Environments.Cloud.AWS


## Implementation Details ##

* These assemblies DO reference `App.Base.Shared`, 
  `App.Base.Infrastructure` and others, to reuse 
  their models and services.
* But Base assemblies do NOT have a reference to these
  assemblies.
* So they are found by Reflection when the startup
  sequence says to scan the `COMPONENTS` (and `MODULES`) 
  folders.

