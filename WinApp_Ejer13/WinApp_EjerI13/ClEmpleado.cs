using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinApp_EjerI13
{
    internal class ClEmpleado
    {
        private int horaLunes, horaMartes, horaMiercoles, horaJueves, horaViernes, horaSabado, horaDomingo;

        public ClEmpleado(int hLunes, int hMartes, int hMiercoles, int hJueves, int hViernes, int hSabado, int hDomingo)
        {
            this.horaLunes = hLunes;
            this.horaMartes = hMartes;
            this.horaMiercoles = hMiercoles;
            this.horaJueves = hJueves;
            this.horaViernes = hViernes;
            this.horaSabado = hSabado;
            this.horaDomingo = hDomingo;
        }
        public int CalcularSueldo()
        {
            int horasTrabajadas = horaLunes + horaMartes + horaMiercoles + horaJueves + horaViernes + horaSabado + horaDomingo;
            return horasTrabajadas * 4; // Suponiendo que el sueldo es de $3 por hora
        }

    }
}
