using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentControl.Models
{
    public class Document
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Titulo { get; set; }
        public string Processo { get; set; }
        public string Categoria { get; set; }
        public bool StatusCadastro { get; set; }

        

        public Document()
        {

        }

    }
}
