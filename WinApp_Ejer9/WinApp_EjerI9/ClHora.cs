using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WinApp_EjerI9
{
    internal class ClHora
    {
        string h;
        public ClHora(string hora )
        {
            this.h = hora;
        }
        public string CalHr()
        {
            DateTime hr;
            if (DateTime.TryParseExact(h, "HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out hr))
            {
                // Sumar un segundo
                hr = hr.AddSeconds(1);

                // Verificar si los segundos superan los límites
                if (hr.Second >= 60)
                {
                    hr = hr.AddMinutes(1);
                    hr= hr.AddSeconds(-60);
                }

                // Verificar si los minutos superan los límites
                if (hr.Minute >= 60)
                {
                    hr = hr.AddHours(1);
                    hr = hr.AddMinutes(-60);
                }

                // Verificar si las horas superan los límites
                if (hr.Hour >= 24)
                {
                    hr = hr.AddHours(-24);
                }

                return  hr.ToString("HH:mm:ss"); ;
            }
            else
            {
                return "Formato de hora inválido" ;
            }
        }
    }
}
