using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaVeterinaria
{
    public class Animal
    {
        private int _idAnimal {  get; set; }
        public int IdAnimal { get { return _idAnimal; } set { _idAnimal = value; } }
        public string? nomeAnimal { get; set; }
        public string? tipoAnimal { get; set; }
        public string? racaAnimal { get; set; }
        private string? _dataNascimentoAnimal { get; set; }
        private string? _cpfTutor {  get; set; }

        //public Animal(int ctID, string ctNome, string ctTipo, string ctRaca, string ctData, string ctCPF)
        //{
        //    _idAnimal = ctID;
        //    nomeAnimal = ctNome;
        //    tipoAnimal = ctTipo;
        //    racaAnimal = ctRaca;
        //    _dataNascimentoAnimal = ctData;
        //    _cpfTutor = ctCPF;
        //    Console.WriteLine($"Animal: {nomeAnimal}, do tutor de cpf {_cpfTutor} foi cadastrado.");
        //}

        public void CadastrarAnimal()
        {

        }
    }
}
