using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaVeterinaria
{
    public class Consulta
    {
        public int idConsulta { get; private set; } //autoincrement
        public string? dataConsulta { get; set; }
        public string? horaConsulta { get; set; }
        public string? triagem {  get; set; }
        public string? situacao { get; set; }
        public Animal animal = new Animal();
        public Tutor tutor = new Tutor();
        public Veterinario veterinario = new Veterinario();

        public void AgendarConsulta(List<Animal> ListaAnimaisCadastrados) 
        {
            bool animalExiste = false;

                Console.Write("Digite o id do animal: ");
                animal.IdAnimal = int.Parse(Console.ReadLine()!);
                foreach (Animal animalCadastrado in ListaAnimaisCadastrados)
                {
                    if (animal.IdAnimal == animalCadastrado.IdAnimal)
                    {
                        animalExiste = true;
                    }
                    
                }

                if (animalExiste == false)
                {
                    Console.WriteLine("Animal não cadastrado!");
                }

        }
    }
}
