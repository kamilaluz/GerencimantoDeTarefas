using GerenciadorDeTarefas.Enum;
using System;
using System.Collections.Generic;
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
        public void StatusVencimento()
        {
            if ((DataDeConclusao.Date < DateTime.Today) && (Status != status.Concluída || Status != status.Cancelada))
            {
                Console.WriteLine("[!] Atenção!! A tarefa está vencida!");
            } else if ((DataDeConclusao.Date == DateTime.Today) && (Status != status.Concluída || Status != status.Cancelada))
            {
                Console.WriteLine("[!] Atenção!! A tarefa vence hoje!");

            } else if ((DataDeConclusao.Date > DateTime.Today) && (DataDeConclusao.Date < DateTime.Today.AddDays(2)) && (Status != status.Concluída || Status != status.Cancelada))
            {
                Console.WriteLine("[!] Atenção!! A tarefa está próxima do vencimento!");
            }
        }
        public void VisualizarTarefa()
        {
            Console.WriteLine("\nDetalhes da tarefa:");
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Descrição: {Descricao}");
            Console.WriteLine($"Data de conclusão: {DataDeConclusao}");
            Console.WriteLine($"Status: {Status}");
            StatusVencimento();
        }
    }
}
