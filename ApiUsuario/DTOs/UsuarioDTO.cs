using System;
using System.ComponentModel.DataAnnotations;

namespace ApiUsuario.DTOs
{
	public class UsuarioDTO
	{
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; } = string.Empty;

        [Required]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Senha { get; set; } = string.Empty;

        [Required]
        public string CPF { get; set; } = string.Empty;

        public string Cargo { get; set; } = string.Empty;

        public Boolean Administrador{ get; set; } = false;
    }
}

