using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace putty_color_theme_gui
{
    public class Theme
    {
        public String Name { get; }
        public String Url { get; }
        public Dictionary<String, String> Properties { get; } = new Dictionary<string, string>();

        public Theme(String name, String url)
        {
            this.Name = name;
            this.Url = url;

            

            IConfiguration config = new ConfigurationBuilder()
                .AddIniFile($"{AppContext.BaseDirectory}\\themes\\{name}.ini")
                .Build();

            foreach (var item in config.AsEnumerable())
            {
                if (item.Value is not null)
                {
                    var key = item.Key.Split(':')[1];
                    this.Properties.Add(key, item.Value);
                }
            }
        }
    }
}
