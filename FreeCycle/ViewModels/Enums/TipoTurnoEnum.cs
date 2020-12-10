using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EdinsaWebServer.ViewModels.Enums
{
    public enum TipoTurnoEnum : int
    {
        EnPlataforma = 0,
        EnOtraPlataforma = 1,
        IncapacidadMenos3Dias = 2,
        IncapacidadMayor3Dias = 3,
        LicenciaPaternidad = 4,
        LicenciaNoRemunerada = 5,
        EPS = 6,
        CalamidadDomestica = 7,
        Compensando = 8,

        Vacaciones = 9,
        Falto = 10,

        Suspencion = 11,
        TerminacionContrato = 12,
        Renuncia = 13,
        
    }
}
