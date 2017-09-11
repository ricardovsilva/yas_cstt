  

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
	} 
}
  
