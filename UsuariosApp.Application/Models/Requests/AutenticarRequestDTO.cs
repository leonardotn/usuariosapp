﻿using System.ComponentModel.DataAnnotations;

namespace UsuariosApp.Application.Models.Requests
{
    public class AutenticarRequestDTO
    {
        [EmailAddress(ErrorMessage = "Endereço de e-mail inválido.")]
        [Required(ErrorMessage = "Informe o e-mail inválido.")]
        public string? Email { get; set; }
        [MinLength(8, ErrorMessage = "Senha deve conter pelo menos {1} caracteres.")]
        [MaxLength(20, ErrorMessage = "Senha deve conter no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Informe a senha.")]
        public string? Senha { get; set; }

    }
}
