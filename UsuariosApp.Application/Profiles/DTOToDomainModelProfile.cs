﻿using AutoMapper;
using UsuariosApp.Application.Helpers;
using UsuariosApp.Application.Models.Requests;
using UsuariosApp.Domain.Models;

namespace UsuariosApp.Application.Profiles
{
    /// <summary>
    /// Mapeamento de DTOs para Modelos de domínio
    /// </summary>
    public class DTOToDomainModelProfile : Profile
    {
        public DTOToDomainModelProfile()
        {
            CreateMap<CriarContaRequestDTO, Usuario>()
                .AfterMap((dto, model) =>
                {
                    model.Id = Guid.NewGuid();
                    model.Senha = Sha1Helper.Encrypt(model.Senha);
                    model.DataHoraCriacao = DateTime.Now;
                });
        }
    }
}
