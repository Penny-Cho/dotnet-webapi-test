using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_webapi_test.Data.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        //Navigation Properties (many to many)
        public List<Book_Author> Book_Authors { get; set; }


    }
}
