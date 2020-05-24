using System.Collections.Generic;
using AutoMapper;
using RotaDasTapas.Models;
using RotaDasTapas.Models.Gateway;

namespace RotaDasTapas.Profiles.TypeConverter
{
    public class TapasResponseTypeConverter : ITypeConverter<TapaDto, TapasResponse>
    {
        private readonly IMapper _mapper;

        public TapasResponseTypeConverter(IMapper mapper)
        {
            _mapper = mapper;
        }

        public TapasResponse Convert(TapaDto source, TapasResponse destination, ResolutionContext context)
        {
            var tapa = _mapper.Map<Tapa>(source);
            var tapaResponse = new TapasResponse()
            {
                Tapas = new List<Tapa> {tapa}
            };
            return tapaResponse;
        }
    }
}