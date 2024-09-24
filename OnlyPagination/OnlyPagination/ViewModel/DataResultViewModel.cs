using OnlyPagination.Extensions.Query.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlyPagination.ViewModel
{
    public class DataResultViewModel<T>
    {
        /// <summary>
        /// Элементы
        /// </summary>
        public IEnumerable<T> Items { get; set; }


        /// <summary>
        /// Pagination
        /// </summary>
        public Pagination Pagination { get; set; }
    }
}