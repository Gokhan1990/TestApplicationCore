using System;
using System.Collections.Generic;

#nullable disable

namespace TestUygulama2.DataDB
{
    public partial class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int? Age { get; set; }

        public string Height { get; set; }
    }
}
