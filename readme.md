## Synopsis ##

The service that an end user sees is composed of 
several discrete parts managed in their own 
discrete Code Repository, to permit different teams
to manage what they do best. 


## Background ##

The objective is to use separate repos for UX as for Servers as for Libraries.
The advantage of this approach is that 
* UX developers can concentrate on developing the 
  best user experience using one tech stack (eg: Angular), 
  without having to split focus to develop backend service 
  capabilities, usig a different tech stack (C#).
* Backend developers can focus on develoing the service stack
  irrespective of front-end, baking in long term 
  maintainability and interoperability,
* Framework developers can focus on developing reusable code in one repo, without 
  direct engagement with point business concerns

Git permits this separation of concerns by offering the
capability of nesting Git Repositories, as `submodule`'s.

The impact is that developers are required to know just a little
bit more than the raw basics of Git to switching back and forth 
across 3+ repos, rather than just working with one.
than just one.

### Adding SubModules ###
Git submdules were added with commands similar to the following:

```
git submodule add -b main "https://github.com/skysgh/BASE.git" SUBREPOS/BASE
git submodule add -b main "https://github.com/skysgh/BASE.Jump.Basic.Client.git" SUBREPOS/CLIENT
```

This will create a `.gitmodule` file in the parent repo's root directory:

```
[submodule "BASE"]
	path = BASE
	url = https://github.com/skysgh/BASE.git
	branch = main
[submodule "BASE.Jump.Basic.Client"]
	path = BASE.Jump.Basic.Client
	url = https://github.com/skysgh/BASE.Jump.Basic.Client.git
	branch = main
[submodule "BASE.Jump.Basic.Host"]
	path = BASE.Jump.Basic.Host
	url = https://github.com/skysgh/BASE.Jump.Basic.Host.git
	branch = main
```

New Git Submodules may require an initial pull to hydrate:

```
git pull --recurse-submodules
```

### Deleting / Restarting ###

It's hard to think up front of the right names for folders...
so one might add a Module that needs to be renamed or removed.

That's not as straight forward as I would like.

