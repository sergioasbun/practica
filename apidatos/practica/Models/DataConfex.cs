using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace practica.Models
{
    public class DataConfex : DbContext
    {
        public DataConfex() : base("DefaultConnection")
        { 
    }
        public System.Data.Entity.DbSet<practica.Models.asbun> asbun { get; set; }
}