using OnlyPagination.Extensions.Query;
using OnlyPagination.Extensions.Query.Model;
using OnlyPagination.Models;
using OnlyPagination.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace OnlyPagination.Services
{
    public class PersonService
    {
        public DataResultViewModel<PersonViewModel> GetWithPagination(Pagination pagination,
            Expression<Func<Person, DateTime>> fieldName)
        {
            var result = new DataResultViewModel<PersonViewModel>();

            using (var db = new PersonInfoEntities())
            {
                var persons = db.Person.AsQueryable();

                result.Pagination = pagination;
                result.Pagination.TotalItems = persons.Count();
                result.Pagination.RouteInfo = new RouteInfo() 
                {
                    ActionName = "Index", 
                    ControllerName = "Person"
                };

                if (pagination.SortBy == null)
                    pagination.SortBy = "CreateDate";
                persons = persons.UseOrdering(pagination, fieldName);
                persons = persons.UsePagination(pagination);

                result.Items = persons
                    .Select(s => new PersonViewModel()
                    {
                        ID = s.ID,
                        FirstName = s.FirstName,
                        LastName = s.LastName
                    })
                    .ToList();

                return result;
            }
        }
    }
}