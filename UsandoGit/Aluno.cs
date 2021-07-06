using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsandoGit.Interfaces;

namespace UsandoGit

{
    public class Aluno:IAtividades
    {
        public int DiasDeAtividades { get; set; }

        public void Andar()
        {
            throw new NotImplementedException();
        }

        public void Correr()
        {
            throw new NotImplementedException();
        }

        public void Nadar()
        {
            throw new NotImplementedException();
        }

        public void Saltar()
        {
            throw new NotImplementedException();
        }
    }
}
