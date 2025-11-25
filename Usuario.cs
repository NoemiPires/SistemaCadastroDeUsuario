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
        public UInt64 Id { get; set; }
        public String Nome { get; set; }
        public String Telefone { get; set; }
        public String Email { get; set; }
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
        
        public Compra Compra { get; set; }


        // Método para calcular a comissão do usuário usuario se ele for do tipo vendedor, somando 
        // todas as comissoes das vendas realizadas por ele na classe Compra no metodo Calcular Comissao. 
        public Decimal CalcularComisasaoUsuario(TipoUsuario Tipo)
        {
            if (this.Tipo != TipoUsuario.Vendedor)
            {
                return 0;
            }
            else
            {
                List<Compra> comprasDoVendedor = CompraRepository.FindByVendedorId(this.Id);
                Decimal totalComissao = 0;
                foreach (var compra in comprasDoVendedor)
                {

                    if (compra != null)
                    {
                        totalComissao += compra.CalcularComissao();
                    }
                }
                return totalComissao;
            }
        }
    }

}
