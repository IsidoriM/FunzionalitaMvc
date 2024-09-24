using OnlyPagination.Extensions.Query.Model;
using OnlyPagination.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlyPagination.Controllers
{
    public class PersonController : Controller
    {
        PersonService _personService;


        public PersonController()
        {
            _personService = new PersonService();
        }


        // GET: Person
        public ActionResult Index(int? page, int? pageSize, string sortBy, bool? isSortAscending)
        {
            return View
                (_personService.GetWithPagination(new Pagination()
                    {
                        Page = page ?? 1,
                        PageSize = pageSize ?? 3,
                        SortBy = sortBy,
                        IsSortAscending = isSortAscending ?? false
                    },
                    v => v.CreateDate
                    )
                );
        }
    }
}