using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaCadastroDeUsuario
{
    [Table("Usuario")]
    public class Usuario
    {
        public UInt64 Id {  get; set; }
        public String Nome {  get; set; }
        public String Telefone {  get; set; }
        public String Email {  get; set; }
        public TipoUsuario Tipo { get; set; }

        private Credencial _credencial;

        [ForeignKey("credencial_id")]
        public Credencial Credencial
        {
            get => _credencial;
            set
            {
                _credencial = value;
                value.Usuario = this;
            }
        }
    }
}
