﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eBolnica;

namespace eBolnica.Model
{
    public class Dostavljac : Osoba
    {
        private int id;

        private static int brojac = 0;

        public Dostavljac(string ime, string prezime, DateTime datumRodjenja, string jmbg, string adresaStanovanja, string brojTelefona, string email) : base(ime, prezime, datumRodjenja, jmbg, adresaStanovanja, brojTelefona, email)
        {
            brojac++;
            this.id = brojac;
        }
        public int Id
        {
            get; set;
        }
        //public int Id { get => id; set => id = value; }
    }
}
