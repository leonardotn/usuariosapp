namespace UsuariosApp.Domain.Exceptions.Usuarios
{
    /// <summary>
    /// Classe de exceção para acesso não autorizado de usuário
    /// </summary>
    public class AcessoNegadoException : Exception
    {
        public override string Message
            => "Acesso negado. Usuário inválido.";
    }
}
