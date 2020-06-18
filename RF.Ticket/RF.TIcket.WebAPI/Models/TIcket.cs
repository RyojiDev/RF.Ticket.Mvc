using RF.TIcket.WebAPI.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RF.TIcket.WebAPI.Models
{
    public class Ticket
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public DateTime DataHoraAtendimento { get; set; }

        public Status Status { get; set; }

        public Ticket()
        {

        }

        public Ticket(string nome, string descricao, DateTime data, Status status)
        {
            Nome = nome;
            Descricao = descricao;
            DataHoraAtendimento = data;
            Status = status;
        }


    }
}