using System;
using System.ComponentModel.DataAnnotations;
namespace _2019AP601.Models
{
    public class marcas{
         [Key]
        public int id_marca { get; set; }
        public string nombre { get; set; }
        
    }
}