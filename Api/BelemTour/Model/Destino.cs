using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BelemTour.Model
{
    [Table("destino")]
    public class Destino
    {

        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
         [Required]
        public  string Nome { get; set; }


        [Column("categoria")]
        [Required]

        public string Categoria { get; set; }

        [Column("tempo")]
         [Required]

        public string Tempo { get; set; }
             
        [Column("valor")]
        public decimal Valor { get; set; }
        
        [Column("imagem")]

         public string Imagem { get; set; }




    }
}