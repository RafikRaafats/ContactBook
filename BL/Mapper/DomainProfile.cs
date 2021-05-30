using AutoMapper;
using ContactBook.DAL.Entity;
using ContactBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactBook.BL.Mapper
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            CreateMap<Client,ClientVM>();
            CreateMap<ClientVM, Client>();
        }
    }
}
