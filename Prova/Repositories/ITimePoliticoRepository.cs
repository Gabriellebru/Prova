using Prova.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prova.Repositorys
{
    interface ITimePoliticoRepository
    {

        public IList<TimePolitico> ListarTodasCategorias();

        public void InserirCategoria(TimePolitico time);
    }
}
