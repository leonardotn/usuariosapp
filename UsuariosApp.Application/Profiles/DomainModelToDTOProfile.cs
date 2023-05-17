using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsuariosApp.Application.Models.Requests;
using UsuariosApp.Application.Models.Responses;
using UsuariosApp.Domain.Models;

namespace UsuariosApp.Application.Profiles
{
    public class DomainModelToDTOProfile : Profile
    {
        public DomainModelToDTOProfile()
        {
            CreateMap<Usuario, CriarContaRequestDTO>();
            CreateMap<Usuario, AutenticarResponseDTO>();
        }
    }
}
