using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoAPI.Models
{
    /// <summary>
    /// Represents one specific person
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Id from SQL
        /// </summary>
        public int Id { get; set; } = 0;
        /// <summary>
        /// Users first name
        /// </summary>
        public String FirstName { get; set; } = "";
        /// <summary>
        /// Users last name
        /// </summary>
        public String LastName { get; set; } = "";
    }
}