using AutoMapper;
using PartialViewDB.Models.Entities;
using PartialVIewLayerDB_NET6.ViewModels;

namespace PartialVIewLayerDB_NET6.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Adult, AdultVM>();
        }
    }
}
