using System;
using Models;
using System.Collections.Generic;

namespace Controllers
{
    public class LocacaoController
    {
        public static LocacaoModels adcionarLocacao(ClienteModels cliente)
        {
            return new LocacaoModels(cliente, DateTime.Now);
        }

        public static DateTime calcularDataDevolucao(DateTime dtLocacao, ClienteModels cliente)
        {
            return dtLocacao.AddDays(cliente.DiasdeDevolucao);
        }

        public static LocacaoModels GetLocacaos(int LocacaoId)
        {
            return LocacaoModels.GetLocacao(LocacaoId);
        }

        public static List<LocacaoModels> GetLocacaos()
        {
            return LocacaoModels.GetLocacao();
        }
    }
}