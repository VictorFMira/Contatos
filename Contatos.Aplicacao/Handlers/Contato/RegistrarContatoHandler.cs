using Cont.Aplicacao.DTOs.Contato;
using Cont.Dominio.Intefaces;
using Cont.Dominio.Entidades;
using MediatR;

namespace Cont.Aplicacao.Handlers.Contato
{
    public class RegistrarContatoHandler(IUnitOfWork unitOfWork) : IRequestHandler<RegistrarContatoReq, RegistrarContatoResp>
    {
        private readonly IUnitOfWork _unitOfWork = unitOfWork;

        public async Task<RegistrarContatoResp> Handle(RegistrarContatoReq request, CancellationToken cancellationToken)
        {
            var response = new RegistrarContatoResp();
            if (string.IsNullOrWhiteSpace(request.Nome) || string.IsNullOrWhiteSpace(request.Telefone))
            {
                response.Sucesso = false;
                response.Mensagem = "Nome e telefone são obrigatórios";
                return response;
            }
            var contato = new Cont.Dominio.Entidades.Contato
            {
                Nome = request.Nome,
                Telefone = request.Telefone,
                Email = request.Email
            };
            await _unitOfWork.InserirAsync(contato);
            await _unitOfWork.SalvarAlteracoesAsync(cancellationToken);
        }
    }
}
