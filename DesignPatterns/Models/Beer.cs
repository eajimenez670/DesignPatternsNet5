using System;
using System.Collections.Generic;

#nullable disable

namespace DesignPatterns.Models
{
    public partial class Beer : EntityBase
    {        
        public string Name { get; set; }
        public string Style { get; set; }
    }
}
