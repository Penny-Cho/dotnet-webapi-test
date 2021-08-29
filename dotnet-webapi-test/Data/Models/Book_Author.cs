using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_webapi_test.Data.Models
{
    public class Book_Author
    {
        public int Id { get; set; }

        //book과 author를 잇는 테이블의 생성
        public int BookId { get; set; }
        public Book Book { get; set; }


        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
