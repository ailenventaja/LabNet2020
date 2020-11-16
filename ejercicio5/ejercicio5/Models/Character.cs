using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ejercicio5.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Species { get; set; }

        public string Gender { get; set; }
        public string Image { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public string Created { get; set; }

    }
}