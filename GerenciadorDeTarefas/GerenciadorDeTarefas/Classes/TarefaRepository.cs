using GerenciadorDeTarefas.Enum;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeTarefas.Classes
{
    public class TarefaRepository<T>
    {
        public List<T> tarefas = new List<T>();

    }
}
