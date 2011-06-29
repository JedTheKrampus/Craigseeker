using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CraigSeeker.Models
{
    public class CraigQuery
    {
        private string email;
        private string search;

        public CraigQuery(string email, string search)
        {
            // TODO: Complete member initialization
            this.email = email;
            this.search = search;
        }

        public string Email { get; set; }
        public string Search { get; set; }
    }
}
