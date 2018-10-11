using System;
using System.Collections.Generic;
using System.Text;

namespace XF.Hello
{
    public class Configuracao
    {
        public bool RastrearLocalizacao { get; set; }
        public bool PermitirCookies { get; set; }
        public bool DisponibilizarMural { get; set; }
        public bool EnviarEmail { get; set; }
        public bool ReceberSMS { get; set; }

    }
}
