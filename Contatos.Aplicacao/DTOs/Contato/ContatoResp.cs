

using MediatR;

namespace Cont.Aplicacao.DTOs.Contato
{
    public class RegistrarContatoResp 
    {
        public bool Sucesso { get; set; }

        public string Mensagem { get; set; }
    }

    public class AtualizarContatoResp
    {
        public bool Sucesso { get; set; }
        public string Mensagem { get; set; }
    }
}
