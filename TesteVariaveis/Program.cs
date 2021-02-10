
using System;
using System.Drawing;
using System.Text;

namespace TesteVariaveis
{
    struct Agenda
    {
        public DateTime dtAniversario;
        public string Nome;
    }


    class Program
    {

        static void Main(string[] args)
        {
            TesteDataStruct();

            TesteClsPessoa();

            TesteConcatString();

            ConversaoImplicita();

            ConversaoExplicita();

            ConversaoClasseAuxiliar();

            Boxing();

            Unboxing();

            TesteVar();

            Console.ReadLine();

        }

        public static void TesteDataStruct()
        {
            Agenda ag = new Agenda();
            ag.Nome = "Ellen";
            ag.dtAniversario = new DateTime(1986, 01, 28);

            Console.WriteLine("Short Date: " + ag.dtAniversario.ToString("d"));

            Console.WriteLine("Long Date: " + ag.dtAniversario.ToString("D"));

            Console.WriteLine("Full Date: " + ag.dtAniversario.ToString("F"));

            Console.WriteLine(" Year / Month: " + ag.dtAniversario.ToString("y"));

            Console.WriteLine("02 / 10 2021: " + ag.dtAniversario.ToString("“MM ‘/’ dd yyyy"));

            Console.WriteLine("10.02.2021: " + ag.dtAniversario.ToString("dd.MM.yyyy"));

            Console.WriteLine("10.02.2021 07:00 : " + ag.dtAniversario.ToString("MM.dd.yyyy HH: mm"));

            Console.WriteLine(" Wednesday @ 7:00 PM : " + ag.dtAniversario.ToString("dddd @ hh: mm tt", System.Globalization.CultureInfo.InvariantCulture));
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(" ");
        }

        public static void TesteClsPessoa()
        {
            clsPessoa objPessoa = new clsPessoa();
        }

        public static void TesteConcatString()
        {
            //Usando o operador “+”
            string FraseMais = "Estamos " + "iniciando " + "mais " + "um " + "semestre.";

            //Usando o método Concat
            string MetodoConcat = string.Concat("Estamos ", "iniciando ", "mais ", "um ", "semestre.");

            //Usando o método join
            string MetodoJoin = string.Join("Estamos ", "iniciando ", "mais ", "um ", "semestre.");

            //Usando a classe StringBuilder(System.Text)
            StringBuilder sb = new StringBuilder();
            sb.Append("Estamos ");
            sb.Append("iniciando ");
            sb.Append("mais ");
            sb.Append("um ");
            sb.Append("semestre.");

            string stringBuilder = sb.ToString();

            //Usando o método String.Format
            string MetodoFormat = string.Format("Estamos ", "iniciando ", "mais ", "um ", "semestre.");
            string MetodoFormat2 = string.Format("{0} {1} {2} {3} {4}", "Estamos ", "iniciando ", "mais ", "um ", "semestre.");

            //Usando o operador $
            string OperadorDolar = $"{ "Estamos "} { "iniciando "} { "mais "} { "um "} { "semestre."}";

            Console.WriteLine("+:" + FraseMais);
            Console.WriteLine("Concat: " + MetodoConcat);
            Console.WriteLine("Join: " + MetodoJoin);
            Console.WriteLine("stringBuilder: " + stringBuilder);
            Console.WriteLine("Fomrat: " + MetodoFormat);
            Console.WriteLine("Format 2 : " + MetodoFormat2);
            Console.WriteLine("$ : " + OperadorDolar);

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(" ");

        }

        public static void ConversaoImplicita()
        {
            int numero1 = 10;
            double double1 = numero1;

            Console.WriteLine(double1);

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(" ");

        }

        public static void ConversaoExplicita()
        {
            double dbl1 = 10.23;
            int number1 = (int)dbl1;
            Console.WriteLine("Conversao Explicita: " + number1);

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(" ");

        }

        public static void ConversaoClasseAuxiliar()
        {
            int numero1;
            numero1 = Convert.ToInt32("356");

            Console.WriteLine("Conversao implicita: " + numero1);

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(" ");
        }

        public static void Boxing()
        {
            int num = 123;
            object obj = num;
            Console.WriteLine("Boxing: " + obj);

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(" ");

        }

        public static void Unboxing()
        {
            int numero = 123;
            object obj = numero;
            int num;
            num = (int)obj;
            Console.WriteLine("unboxing: " + num);

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(" ");

        }

        public static void TesteVar()
        {
            var num = 10;
            Console.WriteLine("Var: " + num);

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(" ");
        }
    }



}
