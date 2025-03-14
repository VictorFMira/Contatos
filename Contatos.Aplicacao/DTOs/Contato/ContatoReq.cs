

using MediatR;

namespace Cont.Aplicacao.DTOs.Contato
{
    public class RegistrarContatoReq : IRequest<RegistrarContatoResp>
    {
        public string Telefone { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
    }

    public class AtualizarContatoReq : IRequest<AtualizarContatoResp> 
    {
        public string Telefone { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}
