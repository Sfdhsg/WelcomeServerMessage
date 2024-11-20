using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Interfaces;


namespace Broadcasts
{
    public class Config : IConfig
    {
         public bool IsEnabled { get; set; } = true;

         public bool Debug { get; set; } = false;
         public ushort Duration { get; set; } = 10;
        public string Text { get; set; } = "<color=green>welcome to the server</color>";
    }
}
