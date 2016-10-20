using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptCs.Wpf
{
    public class Option
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class StringOption : Option
    {
        public string Placeholder { get; set; }

        public StringOption(string name, string value, string placeholder = null)
        {
            Name = name;
            Value = value;
            Placeholder = placeholder;
        }
    }

    public class ButtonOption : Option
    {
        public List<string> Values { get; set; }

        public ButtonOption(string name, string value1)
        {
            Name = name;
            Values = new List<string>();
            Values.Add(value1);
            Value = value1;
        }

        public ButtonOption(string name, params string[] values)
        {
            Name = name;
            Values = new List<string>(values);
            Value = String.Join(", ", values);
        }

    }
}
