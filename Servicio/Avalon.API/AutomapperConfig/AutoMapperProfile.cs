using AutoMapper;
using Avalon.AccesoDatos;
using Avalon.ViewModel.Maestros;
using Avalon.ViewModel.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Avalon.API.AutomapperConfig
{
    public class AutoMapperProfile
    {
        public static MapperConfiguration MaperConfig()
        {
            return new MapperConfiguration(x => {
                x.AllowNullCollections = true;
                x.CreateMap<usuario, UsuarioViewModel>().ReverseMap();
                x.CreateMap<modulo, ModuloViewModel>().ReverseMap();
                x.CreateMap<menu, MenuViewModel>().ReverseMap();
                x.CreateMap<menuXperfil, MenuXPerfilViewModel>().ReverseMap();
                x.CreateMap<perfil, PerfilViewModel>().ReverseMap();
                x.CreateMap<usuarioXperfil, UsuarioXPerfilViewModel>().ReverseMap();
                x.CreateMap<banco, bancoViewModel>().ReverseMap();
                x.CreateMap<centroCostos, centroCostosViewModel>().ReverseMap();
                x.CreateMap<subCentroCostos, subCentroCostosViewModel>().ReverseMap();
                x.CreateMap<subSubCentroCostos, subSubCentroCostosViewModel>().ReverseMap();
                x.CreateMap<clase, claseViewModel>().ReverseMap();
                x.CreateMap<subClase, subClaseViewModel>().ReverseMap();
                x.CreateMap<subSubClase, subSubClaseViewModel>().ReverseMap();
                x.CreateMap<familia, familiaViewModel>().ReverseMap();
                x.CreateMap<subFamilia, subFamiliaViewModel>().ReverseMap();
                x.CreateMap<producto, productoViewModel>().ReverseMap();
                x.CreateMap<servicio, servicioViewModel>().ReverseMap();
                x.CreateMap<unidadMedida, unidadMedidaViewModel>().ReverseMap();

                x.CreateMap<socioNegocio, socioNegocioViewModel>().ReverseMap();
                x.CreateMap<tipoDocumentoIdentidad, tipoDocumentoIdentidadViewModel>().ReverseMap();
                x.CreateMap<condicionPago, condicionPagoViewModel>().ReverseMap();
            });
        }
    }
}