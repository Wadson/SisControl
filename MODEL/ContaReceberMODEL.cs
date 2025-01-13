﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisControl.MODEL
{
    //public class ContaReceberModel
    //{
    //    //public int ContaReceberID { get; set; }
    //    public Guid ContaReceberID { get; set; } // Usando GUID como chave primária
    //    public int VendaID { get; set; }
    //    public int ParcelaID { get; set; }
    //    public DateTime? DataRecebimento { get; set; } // Permite valores nulos
    //    public decimal ValorRecebido { get; set; }
    //    public decimal SaldoRestante { get; set; }
    //    public bool Pago { get; set; }


    //}
    public class ContaReceberModel
    {
        public Guid ContaReceberID { get; set; } // Usando GUID como chave primária
        public int VendaID { get; set; } // Ajustando para GUID
        public Guid ParcelaID { get; set; } // Ajustando para GUID
        public DateTime? DataRecebimento { get; set; } // Permite valores nulos
        public decimal ValorRecebido { get; set; }
        public decimal SaldoRestante { get; set; }
        public bool Pago { get; set; }

        public ParcelaModel Parcela { get; set; } // Adicionando a propriedade Parcela

        // Implementação implícita de conversão de ParcelaModel para ContaReceberModel
        public static implicit operator ContaReceberModel(ParcelaModel parcela)
        {
            return new ContaReceberModel
            {
                ContaReceberID = Guid.NewGuid(), // Gerar um novo GUID para ContaReceberID
                ParcelaID = parcela.ParcelaID,
                VendaID = parcela.VendaID,
                DataRecebimento = null,
                ValorRecebido = 0,
                SaldoRestante = parcela.ValorParcela,
                Pago = false,
                Parcela = parcela
            };
        }
    }

}