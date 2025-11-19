using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaCadastroDeUsuario
{
    [Table("tbl_credencial")]
    public class Credencial
    {
        public const String SALT = "!@$#_";
        public String Nome {  get; set; }
        public UInt64 Id {  get; set; }
        public Usuario Usuario { get; set; }
        public DateTime UltimoAcesso { get; set; }
        public TipoUsuario Tipo { get; set; }

        private String _senha;
        public String Senha
        {
            get => _senha;
            set
            {
                _senha = ComputeSHA256(value, SALT);
            }
        }
        #region

        public static String ComputeSHA256(String input)
        {
            return ComputeSHA256(input, null);
        }
        public static String ComputeSHA256(String input, String salt)
        {
            String hash = String.Empty;
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashValue = sha256.ComputeHash(Encoding.UTF8.GetBytes(salt + input));
                foreach (byte b in hashValue)
                {
                    hash += $"{b:X2}";
                }
            }
            return hash;
        }
        #endregion

        public Boolean PermitirAcesso()
        {
            if (((this.Tipo == TipoUsuario.VENDEDOR) || (this.Tipo == TipoUsuario.OPERADORCAIXA)) || (this.Tipo == TipoUsuario.GERENTE))
            {
                return true;

            } 
            else
            {
                return false;
            }
        }
    }
}
