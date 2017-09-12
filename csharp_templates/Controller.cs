  

using System;
using System.Web.Mvc;
using MyApp.Domain.Repositories;

namespace MyApp.MVC.Controllers
{
	public class AutoController : Controller
	{
		private IFooService fooService;

		public AutoController(IFooService fooService)
		{
			this.fooService = fooService;
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
  
