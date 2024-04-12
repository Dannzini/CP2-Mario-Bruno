using System;
using System.ComponentModel.DataAnnotations;

namespace ApiUsuario.Models
{
	public class Usuario
	{
        [Key]
		public int Id { get; set; }
		public string Nome { get; set; } = string.Empty;
		public string Email { get; set; } = string.Empty;
		public string Senha { get; set; } = string.Empty;
		public string CPF { get; set; } = string.Empty;
		public string Cargo { get; set; } = string.Empty;
        public Boolean Administrador { get; set; } = false;
    }
}

