﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Locadora5.Dominio.LocacaoModule
{
    public enum MarcadorCombustivelEnum : int
    {
        Vazio = 1,           // 0
        UmQuarto = 2,        // 1/4
        MeioTanque = 3,      // 1/2
        TresQuartos = 4,     // 3/4
        Completo = 5         // 4/4
    }
}
