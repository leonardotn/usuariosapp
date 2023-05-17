namespace UsuariosApp.Domain.Exceptions.Usuarios
{
    /// <summary>
    /// Classe de exceção para email já cadastrado
    /// </summary>
    public class EmailJaCadastradoException : Exception
    {
        public override string Message
            => "O email informado já está cadastrado, tente outro.";

    }
}
