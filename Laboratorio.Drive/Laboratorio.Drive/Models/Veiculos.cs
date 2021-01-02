using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio.Drive.Models
{
    public class Veiculos
    {
        [PrimaryKey]
        [AutoIncrement]
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string PrecoFormatado
        {
            get { return $"R$ {Preco}"; }
        }
    }
}
