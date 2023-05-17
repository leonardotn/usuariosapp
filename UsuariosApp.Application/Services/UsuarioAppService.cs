using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using UsuariosApp.Application.Interfaces;
using UsuariosApp.Application.Models.Requests;
using UsuariosApp.Application.Models.Responses;
using UsuariosApp.Domain.Interfaces.Services;
using UsuariosApp.Domain.Models;

namespace UsuariosApp.Application.Services
{
    public class UsuarioAppService : IUsuarioAppService
    {
        private readonly IUsuarioDomainService? _usuarioDomainService;
        private readonly IMapper? _mapper;

        public UsuarioAppService(IUsuarioDomainService? usuarioDomainService, IMapper? mapper)
        {
            this._usuarioDomainService = usuarioDomainService;
            _mapper = mapper;
        }

        public AutenticarResponseDTO Autenticar(AutenticarRequestDTO dto)
        {
            throw new NotImplementedException();
        }

        public CriarContaResponseDTO CriarConta(CriarContaRequestDTO dto)
        {
            var usuario = _mapper?.Map<Usuario>(dto);
            _usuarioDomainService.CriarConta(usuario);

            return _mapper.Map<CriarContaResponseDTO>(usuario);
        }

        public void Dispose()
        {
            _usuarioDomainService?.Dispose();
        }
    }
}
