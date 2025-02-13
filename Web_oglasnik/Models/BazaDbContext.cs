﻿using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Web_oglasnik.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class BazaDbContext : DbContext
    {
        public DbSet<Oglas> PopisOglasa { get; set; }
        public DbSet<Korisnik> PopisKorisnika { get; set; }
    }
}