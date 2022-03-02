using System;
using System.Collections.Generic;
using System.Text;

namespace AtivSem02
{
    public class InjDep
    {
        public interface IBancos
        {
            double Metodo1();
            void Metodo2(double num);
        }

        public class Itau : IBancos
        {
            int numeroAgencia { get; }
            double saldo = 8684168541684.81;
            public double Metodo1()
            {
                return saldo;
            }

            public void Metodo2(double num)
            {
                saldo += num;
            }
        }

        public class Santander : IBancos
        {
            int numeroAgencia { get; }
            double saldo = 15465469413.54;
            public double Metodo1()
            {
                return saldo;
            }

            public void Metodo2(double num)
            {
                saldo += num;
            }
        }

        public class Nubank : IBancos
        {
            private double saldo = 6321321651.49;
            public double Metodo1()
            {
                return saldo;
            }

            public void Metodo2(double num)
            {
                saldo += num;
            }
        }

        public class TransferenciasBancarias
        {
            IBancos bancoDeposita;
            IBancos bancoRetira;
            public TransferenciasBancarias(IBancos Deposita, IBancos Retira)
            {
                this.bancoDeposita = Deposita;
                this.bancoRetira = Retira;
            }
            public void Transferir(double montante)
            {
                bancoDeposita.Metodo2(-montante);
                bancoRetira.Metodo2(montante);
            }
        }
    }
}
