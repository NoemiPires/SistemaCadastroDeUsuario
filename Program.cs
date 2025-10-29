namespace SistemaCadastroDeUsuario
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.


            Credencial c1 = new Credencial();

            c1.Senha = "123456";
            c1.Gerente = true;
            c1.Nome = "JDCria";

            Usuario u1 = new Usuario();

            u1.Nome = "Giovanna";
            u1.Telefone = "349991067707";
            u1.Email = "gmss3@aluno.ifnmg.edu.br";

            u1.Credencial = c1;

            UsuarioRepository.SaveOrUpdate(u1);

            ApplicationConfiguration.Initialize();
            Application.Run(JanelaEntrada.GetInstance());

        }
    }
}