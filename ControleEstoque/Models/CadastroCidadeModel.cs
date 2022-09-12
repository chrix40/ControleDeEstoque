using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleEstoque.Models
{
    public class CadastroCidadeModel
    {
        public int Id { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
    }
}