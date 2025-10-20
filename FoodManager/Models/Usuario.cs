using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodManager.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        [Required(ErrorMessage = "É obrigatório informar o ID!")]
        public int Id { get; set; }

        [Required(ErrorMessage ="É obrigatório informar o nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "É obrigatório informar o email!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "É obrigatório informar a senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "É obrigatório informar o perfil")]
        public Perfil Perfil { get; set; }
    }

    public enum Perfil
    {
        Administrador,
        Usuário        
    }
}
