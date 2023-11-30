using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace putty_color_theme_gui
{
    internal class Core
    {
        private static readonly Core Instance = new Core();
        public List<Theme> ThemeList { get; private set; }

        private Core()
        {
            ThemeList = GetThemeLIst();
        }

        public static Core getInstance()
        {
            return Instance;
        }

        public string GetPuttyLocation()
        {
            return Properties.Settings.Default.PuttyLocationDir;
        }

        public bool CheckIfPuttyInstalled()
        {
            return File.Exists(GetPuttyLocation());
        }

        public List<Theme> GetThemeLIst()
        {
            var themes = new List<Theme>();
            themes.Add(new Theme("01. Apple Terminal", "https://putty.org.ru/themes/apple-terminal"));
            themes.Add(new Theme("02. Argonaut", "https://putty.org.ru/themes/argonaut"));
            themes.Add(new Theme("03. Birds Of Paradise", "https://putty.org.ru/themes/birds-of-paradise"));
            themes.Add(new Theme("04. Blazer", "https://putty.org.ru/themes/blazer"));
            themes.Add(new Theme("05. Chalkboard", "https://putty.org.ru/themes/chalkboard"));
            themes.Add(new Theme("06. Ciapre", "https://putty.org.ru/themes/ciapre"));
            themes.Add(new Theme("07. Dark Pastel", "https://putty.org.ru/themes/dark-pastel"));
            themes.Add(new Theme("08. Desert", "https://putty.org.ru/themes/desert"));
            themes.Add(new Theme("09. Espresso", "https://putty.org.ru/themes/espresso"));
            themes.Add(new Theme("10. Fish Of Paradise", "https://putty.org.ru/themes/fish-of-paradise"));
            themes.Add(new Theme("11. Fish Tank", "https://putty.org.ru/themes/fish-tank"));
            themes.Add(new Theme("12. Github", "https://putty.org.ru/themes/github"));
            themes.Add(new Theme("13. Grass", "https://putty.org.ru/themes/grass"));
            themes.Add(new Theme("14. Highway", "https://putty.org.ru/themes/highway"));
            themes.Add(new Theme("15. Homebrew", "https://putty.org.ru/themes/homebrew"));
            themes.Add(new Theme("16. Hurtado", "https://putty.org.ru/themes/hurtado"));
            themes.Add(new Theme("17. Ic Green Ppl", "https://putty.org.ru/themes/ic-green-ppl"));
            themes.Add(new Theme("18. Idletoes", "https://putty.org.ru/themes/idletoes"));
            themes.Add(new Theme("19. Igvita Desert", "https://putty.org.ru/themes/igvita-desert"));
            themes.Add(new Theme("20. Igvita Light", "https://putty.org.ru/themes/igvita-light"));
            themes.Add(new Theme("21. Invisibone", "https://putty.org.ru/themes/invisibone"));
            themes.Add(new Theme("22. Kibble", "https://putty.org.ru/themes/kibble"));
            themes.Add(new Theme("23. Liquid Carbon", "https://putty.org.ru/themes/liquid-carbon"));
            themes.Add(new Theme("24. Liquid Carbon Transparent", "https://putty.org.ru/themes/liquid-carbon-transparent"));
            themes.Add(new Theme("25. Liquid Carbon Transparent Inverse", "https://putty.org.ru/themes/liquid-carbon-transparent-inverse"));
            themes.Add(new Theme("26. Man Page", "https://putty.org.ru/themes/man-page"));
            themes.Add(new Theme("27. Monokai Soda", "https://putty.org.ru/themes/monokai-soda"));
            themes.Add(new Theme("28. Monokai Dimmed", "https://putty.org.ru/themes/monokai-dimmed"));
            themes.Add(new Theme("29. Monokai Stevelosh", "https://putty.org.ru/themes/monokai-stevelosh"));
            themes.Add(new Theme("30. Neopolitan", "https://putty.org.ru/themes/neopolitan"));
            themes.Add(new Theme("31. Novel", "https://putty.org.ru/themes/novel"));
            themes.Add(new Theme("32. Ocean", "https://putty.org.ru/themes/ocean"));
            themes.Add(new Theme("33. Papirus Dark", "https://putty.org.ru/themes/papirus-dark"));
            themes.Add(new Theme("34. Pro", "https://putty.org.ru/themes/pro"));
            themes.Add(new Theme("35. Red Sands", "https://putty.org.ru/themes/red-sands"));
            themes.Add(new Theme("36. Seafoam Pastel", "https://putty.org.ru/themes/seafoam-pastel"));
            themes.Add(new Theme("37. Solarized Dark", "https://putty.org.ru/themes/solarized-dark"));
            themes.Add(new Theme("38. Solarized Light", "https://putty.org.ru/themes/solarized-light"));
            themes.Add(new Theme("39. Solarized Darcula", "https://putty.org.ru/themes/solarized-darcula"));
            themes.Add(new Theme("40. Sundried", "https://putty.org.ru/themes/sundried"));
            themes.Add(new Theme("41. Symfonic", "https://putty.org.ru/themes/symfonic"));
            themes.Add(new Theme("42. Teerb", "https://putty.org.ru/themes/teerb"));
            themes.Add(new Theme("43. Terminal Basic", "https://putty.org.ru/themes/terminal-basic"));
            themes.Add(new Theme("44. Thayer", "https://putty.org.ru/themes/thayer"));
            themes.Add(new Theme("45. Tomorrow", "https://putty.org.ru/themes/tomorrow"));
            themes.Add(new Theme("46. Tomorrow Night", "https://putty.org.ru/themes/tomorrow-night"));
            themes.Add(new Theme("47. Twilight", "https://putty.org.ru/themes/twilight"));
            themes.Add(new Theme("48. Vaughn", "https://putty.org.ru/themes/vaughn"));
            themes.Add(new Theme("49. X Dotshare", "https://putty.org.ru/themes/x-dotshare"));
            themes.Add(new Theme("50. Zenburn", "https://putty.org.ru/themes/zenburn"));
            return themes;
        }

        public List<Session> GetPuttySessionList()
        {
            // https://stackoverflow.com/a/44952225/5676460

            var names = new List<Session>();

            var key = Registry.CurrentUser.OpenSubKey(Properties.Settings.Default.PuttySessionRegistrySubPath);
            if (key is not null)
            {
                foreach (var name in key.GetSubKeyNames())
                {
                    names.Add(new Session(WebUtility.UrlDecode(name), name));
                }
            }
            return names;
        }

        public void SetPuttySessionTheme(Session session, Theme theme)
        {
            foreach (var prop in theme.Properties)
            {
                String prefix = $"HKEY_CURRENT_USER\\{Properties.Settings.Default.PuttySessionRegistrySubPath}\\{session.Key}";
                Registry.SetValue(prefix, prop.Key, prop.Value);
            }
        }
    }
}
