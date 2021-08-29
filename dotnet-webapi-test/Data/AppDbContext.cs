using dotnet_webapi_test.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_webapi_test.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book_Author>()
                .HasOne(b => b.Book)
                .WithMany(ba => ba.Book_Authors)
                .HasForeignKey(bi => bi.BookId);

            modelBuilder.Entity<Book_Author>()
               .HasOne(b => b.Author)
               .WithMany(ba => ba.Book_Authors)
               .HasForeignKey(bi => bi.AuthorId);

        }


        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book_Author> Books_Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
    }
}


//local Database 추가하기
//1. SQL Server Obbject Explorer로 이동
//2. local에 생성되어 있는 localdbserver에서 새로운 db추가
//3. db 이름 우클릭 후 주소 복사
//4. appsetting.json connection string에 주소 추가 


//모델 생성 후 DB 자동 생성하기 Command
//Package manager console -> Add-Migration [commit할 이름] -> Update-Database하면 자동으로 테이블 생성됨.