﻿using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace eBolnica2.Models
{
    class EBolnicaDbContext:DbContext
    {
        //Svi restorani koji su u tabeli se dobijaju iz ovog seta
        public DbSet<Pacijent> Pacijenti { get; set; }
        public DbSet<Doktor> Doktori { get; set; }
       // public DbSet<TerminPregleda> TerminiPregleda { get; set; }
        //Metoda koja će promijeniti konfiguraciju i odrediti gdje se spašava klasa i kako se zove.
        //Ovisno od uređaja spasiti će se na različite lokacije, za desktop se kreira poseban folder
        //u AppData/Local Folderu od korisnika
        //Svaki korisnik koji pokrene aplikaciju će imati kreiranu bazu lokalno kod sebe
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string databaseFilePath = "Ooadbaza.db";
            try
            {
                //za tačnu putanju gdje se nalazi baza uraditi ovdje debug i procitati Path
                databaseFilePath = Path.Combine(ApplicationData.Current.LocalFolder.Path,
                databaseFilePath);
            }
            catch (InvalidOperationException) { }
            //Sqlite baza
            optionsBuilder.UseSqlite($"Data source={databaseFilePath}");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
