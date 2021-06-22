﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    public class Aluno
    { //metodos contrutor
        public Aluno(int id=0, string nome=null, string email=null, string telefone=null, string senha=null, bool ativo=false)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Senha = senha;
            this.ativo = ativo;
        }

        // propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Senha { get; set; }
        public bool ativo { get; set; }

    
    public void Inserir()
    {
        var cmd = Banco.Abrir();
    }
}