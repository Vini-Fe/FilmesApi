﻿using FilmesApi.Data.Dtos;
using AutoMapper;
using FilmesApi.Models;
namespace FilmesApi.Profiles;

public class FilmeProfile : Profile
{
    public FilmeProfile()
    {
        CreateMap<CreateFilmeDto, Filme>();
        
        CreateMap<UpdateFilmeDto, Filme>();
        CreateMap<Filme, UpdateFilmeDto>();
        CreateMap<Filme, ReadFilmeDto>().ForMember(filmeDto => filmeDto.Sessoes, opt => opt.MapFrom(filme => filme.Sessoes));
    }
}
