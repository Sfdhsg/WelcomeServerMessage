using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Interfaces;
using Exiled.API.Features;
using System.ComponentModel;


namespace Broadcasts
{
    public class Config : IConfig
    {
        [Description("Включен ли плагин")]
        public bool IsEnabled { get; set; } = true;

        [Description("Включен ли дебагмод")]
        public bool Debug { get; set; } = false;

        [Description("время бродкаста")]
        public ushort Duration { get; set; } = 10;

        [Description("текст бродкаста")]
        public string Text { get; set; } = "<color=green>welcome to the server</color>";

        [Description("текст броадкаста о побеге человека")]
        public string TextEscape { get; set; } = "You Escape";

        [Description("текст броадкаста о Смерти")]
        public string TextDie { get; set; } = "Ypu die";

        [Description("текст броадкаста о Смерти")]
        public string TextEndRound { get; set; } = "Round End";
    }
}
