using AutoMapper;

namespace Notes.Aplication.Common.Mappings
{
    internal interface IMapWith<T>
    {
        void Mapping(Profile profile) => profile.CreateMap(typeof(T), GetType());
    }
}
