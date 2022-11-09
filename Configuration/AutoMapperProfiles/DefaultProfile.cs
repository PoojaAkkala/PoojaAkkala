using AutoMapper;

namespace PoojaProject.Profiles
{
    /// <summary>
    /// Default profile for AutoMapper
    /// </summary>
    /// <remarks>See: https://github.com/drwatson1/AspNet-Core-REST-Service/wiki#automapper</remarks>
    public class DefaultProfile : Profile
    {
        public DefaultProfile()
        {
            CreateMap<Model.Question, Dto.Product>();
            CreateMap<Dto.UpdateProduct, Model.Question>();
            // For copy creation
            CreateMap<Model.Question, Model.Question>();
        }
    }
}
