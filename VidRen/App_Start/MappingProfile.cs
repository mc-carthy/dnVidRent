using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidRen.Dtos;
using VidRen.Models;

namespace VidRen.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain => DTO
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();

            // DTO => Domain
            Mapper.CreateMap<CustomerDto, Customer>()
                .ForMember(c => c.Id, opt => opt.Ignore());
            Mapper.CreateMap<MovieDto, Movie>()
                .ForMember(m => m.Id, opt => opt.Ignore());
        }
    }
}