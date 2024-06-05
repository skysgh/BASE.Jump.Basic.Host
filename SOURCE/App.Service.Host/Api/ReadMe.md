# Synopsis #

Base folder for APIs.

A sub folder for each API protocol. 

THere's REST of course. 

If we were doing OData, I would be tempted to put it under the 
REST folder as strictly speaking it's an extension of REST, 
but it causes more issues that not. Instead, it's put parrallel.


## Introduction ##

Using this assembly for API Controllers is not best practice.


## Implementation Details ##

Using this folder for controllers is not best practice for two reasons.

* Firstly, API Controllers should be in the `*.Presentation.Web` assembly.
* Secondly, API Controllers should be in a Logical Module, separate from the Base assembly
  which is just the base for Modules.

