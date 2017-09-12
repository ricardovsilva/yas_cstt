# YAS CSTT - Yes! Another Simple Csharp Text Template Generator

This template generator uses tt files. TT files are natively supported by visual studio, but no one knows that, even I didn't know that til today.
This template generator doesn't require any instalation of services, plugins or other things like that.

## Usage
Clone this repository, then open solution in a new Visual Studio Instance. Open template file (with extension .tt), build all projects, edit template, save template than cs file will be automatically generated. If you create usefull templates, please, open a PR.

## Templates
**MORE TEMPLATES ON THE WAY**


- Controller: Really really simple template, but also very useful. Open Controller.tt file and take a look at these lines:
```csharp
<#+
	string ClassName = "UserController";
	string Namespace = "MyApp.MVC.Controllers";
	Dependencies Dependencies = new Dependencies() { "IFooService", "IFooRepository", "JustFooClass" };
	Imports Imports = new Imports() { "MyApp.Domain.Repositories", "MyApp.Domain.Services" };
	Actions Actions = new Actions() { "List", "Create", "Delete", "Update" };
#>
```

That's it, change strings above, save file, then click in arrow next to Controller.tt and you will see the Controller.cs file:

![controller arrow down](https://user-images.githubusercontent.com/2130182/30297897-c9cf1016-971f-11e7-92a2-dac0924ad385.png)

That's it, change strings above, save file and a Controller.cs with the following content will be generated:
and a Controller.cs with the following content will be generated:

```csharp
using System.Web.Mvc;
using MyApp.Domain.Repositories;
using MyApp.Domain.Services;

namespace MyApp.MVC.Controllers
{
	public class UserController : Controller
	{
		private IFooService fooService;
		private IFooRepository fooRepository;
		private JustFooClass justFooClass;

		public UserController(IFooService fooService, IFooRepository fooRepository, JustFooClass justFooClass)
		{
			this.fooService = fooService;
			this.fooRepository = fooRepository;
			this.justFooClass = justFooClass;
		}

		public ActionResult List()
		{
			throw new NotImplementedException();
		}

		public ActionResult Create()
		{
			throw new NotImplementedException();
		}

		public ActionResult Delete()
		{
			throw new NotImplementedException();
		}

		public ActionResult Update()
		{
			throw new NotImplementedException();
		}
	}
}
```


