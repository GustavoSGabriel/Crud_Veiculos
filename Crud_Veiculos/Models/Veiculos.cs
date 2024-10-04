using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crud_Veiculos.Models
{
    [Table("Veiculos")]
    public class Veiculos
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("Marca")]
        [Display(Name = "Marca")]
        public string Marca { get; set; }

        [Column("Modelo")]
        [Display(Name = "Modelo ")]
        public string Modelo { get; set; }

        [Column("Ano")]
        [Display(Name = "Ano")]
        public string Ano { get; set; }

        [Column("Placa ")]
        [Display(Name = "Placa ")]
        public string Placa { get; set; }

        [Column("Cor")]
        [Display(Name = "Cor ")]
        public string Cor { get; set; }
    }

}
