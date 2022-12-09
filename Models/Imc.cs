using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API_IMC.Models
{
    public class Imc
    {
        public int Id { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }
        public double ImcCalc { get; set; }
        public string classificacao { get; set; }

        public int? UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }

}