using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProjCoreFinal.Models
{
    public class Fornecedor
    {
        #region Properties

        public int Id { get; set; }
        public string NomeFantasia { get; set; }
        public int CNPJ { get; set; }
        #endregion
    }
}
