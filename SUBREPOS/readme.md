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

The following did work:

```
# you may need to add -f to force it, but the following 
# cleans up the folder, and .gitmodule and .git/config files 
# and whatever else needs to be.
git rm -r <projectfolder> 
git submodule add -b main "https://....git" SUBREPOS/CLIENT
```

### Checking out


### Committing & Pushing

This is maybe really the only shift that a developer needs to 
get a grip on.

Visual Developers are notable for being dependent on Visual Studio's
UX to do anything, loath to use the commandline, and unravel when they
do. Luckily...they don't.

But they do have to learn another Visual Studio move. 

When you checkin, it's *per repo* -- and it doesn't recursively checkin
child repos...

Therefore, if you're working on files in the parent repo (the Service Host)
you commit like you've always done.

But if you have made changes in the Client,or Base lib solutions, then you
have to remember that they are in child Repos.  

To check those changes in, you have to:

* In Solution Explorer
* Select "Switch between Solutions and available View"
* And you'll see a list of all Solutions under the root Repo.
* Select one.

What is happening is that when you switch Solution as the parent node, 
you are in effect switching Repo context. 

Now, when you select Git Changes & Stage changes, 
you're staging to the child repo. Get it?

From the command line one can do all this Recursively...but 
Visual Studio is not geared up to take advantage of this.



### Changing Branches ###

One key aspect is that when you setup GitModules, you setup
the Branch you're looking at. 

But anybody can see it's increadibly bad form to commit directly 
to the Main branch of anything -- let alone a shared library that
other projects are dependent on.

So you should be as or more careful with the submodules and know what
branch you are staging / pushing to.





