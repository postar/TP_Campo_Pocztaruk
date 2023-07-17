using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class LANGUAJECONTROL
    {
        private string languaje;
        private string idControl;
        private string translation;

        public string Languaje { get => languaje; set => languaje = value; }
        public string IdControl { get => idControl; set => idControl = value; }
        public string Translation { get => translation; set => translation = value; }
    }
}