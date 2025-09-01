using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Bancario
{
    public interface Icontabancaria
    {
        bool Sacar(double valor);
        void Depositar(double valor );
        void ConsultarSaldo();
    }
}
