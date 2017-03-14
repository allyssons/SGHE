using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGHE.Controller {
    internal static class ControladorHoras {

        public static int CalculaHoras(string text1, string text2, string text3, string text4) {
            string horaA = text1.Split(':')[0];
            string minutoA = text1.Split(':')[1];
            int hora1 = Int32.Parse(horaA);
            int minuto1;
            if (minutoA == "") minuto1 = 0;
            else minuto1 = Int32.Parse(minutoA);

            string horaB = text2.Split(':')[0];
            string minutoB = text2.Split(':')[1];
            int hora2 = Int32.Parse(horaB);
            int minuto2;
            if (minutoB == "") minuto2 = 0;
            else minuto2 = Int32.Parse(minutoB);

            string horaC = text3.Split(':')[0];
            string minutoC = text3.Split(':')[1];
            int hora3 = Int32.Parse(horaC);
            int minuto3;
            if (minutoC == "") minuto3 = 0;
            else minuto3 = Int32.Parse(minutoC);

            string horaD = text4.Split(':')[0];
            string minutoD = text4.Split(':')[1];
            int hora4 = Int32.Parse(horaD);
            int minuto4;
            if (minutoD == "") minuto4 = 0;
            else minuto4 = Int32.Parse(minutoD);

            int minutosResultantes = 0;

            //Calcula o valor dos minutos resultantes

            if (hora1 == hora2) {

                minutosResultantes += minuto2 - minuto1;

            }else if(hora1 > hora2) {

                if (minuto1 == 0) minuto1 = 60;
                else hora1++;

                minutosResultantes += (60 - minuto1) + minuto2;

                minutosResultantes += (24 - hora1 + hora2) * 60;

            } else {

                if (minuto1 == 0) minuto1 = 60;
                else hora1++;

                minutosResultantes += (60 - minuto1) + minuto2;

                minutosResultantes += (hora2 - (hora1)) * 60;
                Console.WriteLine(minutosResultantes);

            }



            if (hora3 == hora4) {

                minutosResultantes += minuto4 - minuto3;

            } else if (hora3 > hora4)
            {

                if (minuto3 == 0) minuto3 = 60;
                else hora3++;

                minutosResultantes += (60 - minuto3) + minuto4;

                minutosResultantes += (24 - hora3 + hora4) * 60;

            } else {

                if (minuto3 == 0) minuto3 = 60;
                else hora3++;

                minutosResultantes += (60 - minuto3) + minuto4;

                minutosResultantes += (hora4 - (hora3)) * 60;
                Console.WriteLine(minutosResultantes);

            }

            return minutosResultantes;
        }

        public static double CalculaHorasExtras(double minutosTrabalhados, int minutosPrimeroExtra) {

            double minutosExtras = 0;

            if(minutosTrabalhados <= 480) {

                return 0;

            }else {

                minutosExtras = minutosTrabalhados - 480;
            }

            return minutosExtras;
        }

        public static int IdentificaHorasNoturnas (string text1, string text2, string text3, string text4) {
            string horaA = text1.Split(':')[0];
            string minutoA = text1.Split(':')[1];
            int hora1 = int.Parse(horaA);
            int minuto1;
            if (minutoA == "") minuto1 = 0;
            else minuto1 = Int32.Parse(minutoA);

            string horaB = text2.Split(':')[0];
            string minutoB = text2.Split(':')[1];
            int hora2 = Int32.Parse(horaB);
            int minuto2;
            if (minutoB == "") minuto2 = 0;
            else minuto2 = Int32.Parse(minutoB);

            string horaC = text3.Split(':')[0];
            string minutoC = text3.Split(':')[1];
            int hora3 = Int32.Parse(horaC);
            int minuto3;
            if (minutoC == "") minuto3 = 0;
            else minuto3 = Int32.Parse(minutoC);

            string horaD = text4.Split(':')[0];
            string minutoD = text4.Split(':')[1];
            int hora4 = Int32.Parse(horaD);
            int minuto4;
            if (minutoD == "") minuto4 = 0;
            else minuto4 = Int32.Parse(minutoD);

            int minutosResultantes = 0;

            bool flag = false;

           if (hora1 >= 22 || hora1 < 5) {
                flag = true;
                if (hora2 >= 5 && hora2 < 22) {
                    hora2 = 5;
                    minuto2 = 0;
                }
            }
            if(hora2 >= 22 || hora2 < 5) {
                flag = true;
                if (hora1 >= 5 && hora1 < 22) {
                    hora1 = 22;
                    minuto1 = 0;
                }
            }
            if (!flag) {
                if (hora2 > 5 && hora1 < 22 && (hora2 - hora1 > 7 || hora2 - hora1 < 0)) {
                    flag = true;
                    hora1 = 22;
                    minuto1 = 0;
                    hora2 = 5;
                    minuto2 = 0;
                }
            }
            
            if (!flag) {
                hora1 = 0;
                minuto1 = 0;
                hora2 = 0;
                minuto2 = 0;
            }

            flag = false;


            if (hora3 >= 22 || hora3 < 5) {
                flag = true;
                if (hora4 >= 5 && hora4 < 22) {
                    hora4 = 5;
                    minuto4 = 0;
                }
            }
            if (hora4 >= 22 || hora4 < 5) {
                flag = true;
                if (hora3 >= 5 && hora3 < 22) {
                    hora3 = 22;
                    minuto3 = 0;
                }
            }
            if (!flag) {
                if (hora4 > 5 && hora3 < 22 && (hora4 - hora3 > 7 && hora4 - hora3 < 0)) {
                    flag = true;
                    hora3 = 22;
                    minuto3 = 0;
                    hora4 = 5;
                    minuto4 = 0;
                }
            }

            if (!flag) {
                hora3 = 0;
                minuto3 = 0;
                hora4 = 0;
                minuto4 = 0;
            }

            string a = hora1 + ":" + minuto1;
            string b = hora2 + ":" + minuto2;
            string c = hora3 + ":" + minuto3;
            string d = hora4 + ":" + minuto4;
            Console.WriteLine("HORA1:" + a);
            Console.WriteLine("HORA2:" + b);
            Console.WriteLine("HORA3:" + c);
            Console.WriteLine("HORA4:" + d);
            minutosResultantes = CalculaHoras(a, b, c, d);

            return minutosResultantes;
        }

        public static double CalculaHorasNoturnas(int minutosTrabalhados) {
            int horas = (int) (minutosTrabalhados / 52.5);

            double a = minutosTrabalhados / 52.5;

            a = a - horas;

            int minutos = (int) (a / 0.016667);

            a = a / 0.016667;

            a = a - minutos;
            
            double resul = (horas * 60 + minutos) + a;

            return resul;


        }

        public static double CalculaValorHoraExtra(double horasExtras, double percentHEI, double percentHE, int segundaHE, double salario) {
            double salarioN = salario;
            if (horasExtras > 120) {
                salarioN += (salario * (percentHEI / 100));
                salarioN = salarioN * 2;
                horasExtras -= 120;
                salarioN += (salario * (percentHE / 100));
                salarioN = salarioN * (horasExtras/60);
            }
            else {
                salarioN += (salario * (percentHEI / 100));
                salarioN = salarioN * (horasExtras / 60);
            }
            return salarioN;
        }

        public static double CalculaValorHoraNoturna(double horaNoturna, double percentHN, double salario) {
            double salarioN = salario;
            salarioN += salario * (percentHN / 100);
            salarioN = salarioN * (horaNoturna / 60);
            return salarioN;
        }

        public static double CalculaValorSalario(double salario, double salarioHE, double salarioHN, double horasTrabalhadas) {
            double salarioN = salario * (horasTrabalhadas / 60);
            Console.WriteLine(salarioN+" "+salarioHE+" "+ salarioHN);
            return salarioN + salarioHE + salarioHN;
        }
    }
}
