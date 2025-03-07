﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalon.ViewModel.Maestros
{
    public class centroCostosViewModel
    {
        public centroCostosViewModel()
        {
            this.subCentroCostos = new List<subCentroCostosViewModel>();
        }

        public int id { get; set; }
        public string nombre { get; set; }
        public string nombreCorto { get; set; }
        public Nullable<bool> estado { get; set; }

        public List<subCentroCostosViewModel> subCentroCostos { get; set; }
    }
}
