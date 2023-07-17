using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class USERCONTROL
    {
        private string controlId;
        private string description;

        public string ControlId { get => controlId; set => controlId = value; }
        public string Description { get => description; set => description = value; }
    }
}