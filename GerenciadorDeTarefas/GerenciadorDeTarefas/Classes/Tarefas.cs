using GerenciadorDeTarefas.Enum;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeTarefas.Classes
{
    public class Tarefas
    {
        public string Titulo {  get; set; }
        public string Descricao { get; set;}
        public DateTime DataDeConclusao { get; set;}
        public status Status { get; set;}

        public Tarefas (string titulo, string descricao, DateTime dataDeConclusao)
        {
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.DataDeConclusao = dataDeConclusao;
            this.Status = status.Pendente;
        }

        public string StatusVencimento()
        {
            TimeSpan diferenca = DataDeConclusao.Subtract(DateTime.Now);

            double dias = diferenca.TotalDays;
            if (Status != status.Concluída && Status != status.Cancelada)
            {
                if (dias < 0)
                {
                    return "[!] Atenção!! A tarefa está vencida!";
                } else if (dias == 0)
                {
                    return "[!] Atenção!! A tarefa vence hoje!";
                }else if (dias > 0 && dias < 2)
                {
                    return "[!] Atenção!! A tarefa está próxima do vencimento!";
                } else
                {
                    return "Continue a trabalhar na tarefa!";
                }
            }
            return null;
        }

        public void VisualizarTarefa()
        {
            Console.WriteLine("\nDetalhes da tarefa:");
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Descrição: {Descricao}");
            Console.WriteLine($"Data de conclusão: {DataDeConclusao}");
            Console.WriteLine($"Status: {Status}");
            Console.WriteLine(StatusVencimento());
        }
    }
        

}

