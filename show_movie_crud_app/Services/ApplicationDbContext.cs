﻿using Microsoft.EntityFrameworkCore;

namespace show_movie_crud_app.Services
{
    //The dbContext Involved in Creating the table in the database
    //and acts as a middleman between the app and the database
    public class ApplicationDbContext : DbContext
    {
        //
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        //Format for the Table that is Created
        //Movies - Name of Table
        public DbSet<Models.Movie> Movies { get; set; }
    }
}