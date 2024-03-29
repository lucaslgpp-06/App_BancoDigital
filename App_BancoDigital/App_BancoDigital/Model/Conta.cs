﻿using System;
using System.Collections.Generic;
using System.Text;

namespace App_BancoDigital.Model
{
    public class Conta
    {
        /**
         * Saldo:
         * Limite:
         * Data_Abertura:
         */
        public int Id { get; set; }
        public int id_correntista { get; set; } 
        //public Correntista correntista { get; set; }
        public double Saldo { get; set; }
        public double Limite { get; set; }
        public string Tipo { get; set; }
        public DateTime? Data_Abertura { get; set; }
    }
}
