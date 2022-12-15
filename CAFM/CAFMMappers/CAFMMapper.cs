using AutoMapper;
using CAFM.Models;
using CAFM.Models.Dtos;

namespace CAFM.CAFMMappers
{
    public class CAFMMapper : Profile
    {
        public CAFMMapper()
        {
            CreateMap<Usuario, UsuarioDto_cs>().ReverseMap();
            CreateMap<Usuario, CreateUsuarioDto_cs>().ReverseMap();
        }
    }
}
