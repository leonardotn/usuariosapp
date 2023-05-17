namespace UsuariosApp.Domain.Exceptions.Usuarios
{
    /// <summary>
    /// Classe de exceção para usuário não encontrado
    /// </summary>
    public class UsuarioNaoEncontradoException : Exception
    {
        public override string Message
            => "Usuário não encontrado.";
    }
}
