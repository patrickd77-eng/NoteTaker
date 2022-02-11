#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NoteTaker.Models;

    public class MvcNoteContext : DbContext
    {
        public MvcNoteContext (DbContextOptions<MvcNoteContext> options)
            : base(options)
        {
        }

        public DbSet<NoteTaker.Models.Note> Note { get; set; }
    }
