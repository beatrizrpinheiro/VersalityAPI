using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FilesAPI.Models;

    public class FilesContext : DbContext
    {
        public FilesContext (DbContextOptions<FilesContext> options)
            : base(options)
        {
        }

        public DbSet<FilesAPI.Models.Termometro>? Termometro { get; set; }
    }
