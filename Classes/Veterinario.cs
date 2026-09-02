using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaVeterinaria
{
    public class Veterinario : Pessoa
    {
        public string? crmv {  get; set; }
        public string? especialidade { get; set; }

        public Veterinario()
        {
            
        }
    }
}
