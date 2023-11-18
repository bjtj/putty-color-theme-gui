using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace putty_color_theme_gui
{
    public class Session
    {
        public String Name { get; }
        public String Key { get; }

        public Session(String name, String key) {
            this.Name = name;
            this.Key = key;
        }
    }
}
