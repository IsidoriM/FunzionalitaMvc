using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlyPagination.Extensions.Query.Model
{
    /// <summary>
    /// What route should be requested while paging
    /// </summary>
    public class RouteInfo
    {


        /// <summary>
        /// Name of controller
        /// </summary>
        public string ControllerName { get; set; }


        /// <summary>
        /// Name of action
        /// </summary>
        public string ActionName { get; set; }
    }
}