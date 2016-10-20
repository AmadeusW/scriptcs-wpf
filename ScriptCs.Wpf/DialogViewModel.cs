using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptCs.Wpf
{
    public class DialogViewModel
    {
        public IEnumerable<Option> Options { get; set; }

        public string this[string index] => Options.SingleOrDefault(n => n.Name == index)?.Value;

        public DialogViewModel(params Option[] options)
        {
            Options = options;
        }
    }
}
