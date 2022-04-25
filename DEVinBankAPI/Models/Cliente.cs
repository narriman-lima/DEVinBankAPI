﻿namespace DEVinBankAPI.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CPF { get; set; }
        public double RendaMensal { get; set; }
        public Endereco Endereco { get; set; }
    }
}