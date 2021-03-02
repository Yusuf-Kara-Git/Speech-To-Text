using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SpeechToText.Models
{
    public class Context : DbContext
    {
        public Context() : base("Context")
        {

        }
        public DbSet<text> texts { get; set; }
    }
}