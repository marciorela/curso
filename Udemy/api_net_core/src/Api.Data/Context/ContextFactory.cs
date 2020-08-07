using System;
using Api.Data.Constant;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Api.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            // var connectionString = "Server=192.168.1.19;Database=CursoApi;Uid=sa;Pwd=sa123$567SA";
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            optionsBuilder.UseMySql(Environment.GetEnvironmentVariable("DB_CONNECTION"));
            return new MyContext(optionsBuilder.Options);
        }
    }
}
