using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppWeb_UsersCreate.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Display(Name ="Código")]
        [Column("Id")]
        public int Id { get; set; }

        // Nome do Cliente
        [Display(Name = "Nome")]
        [Column("Nome")]
        public string Name { get; set; }

        // tel para contato
        [Display(Name = "Contato")]
        [Column("Contato")]
        public string Contato { get; set; }

        // Email
        [Display(Name = "Email")]
        [Column("Email")]
        public string Email { get; set; }

    }
}
