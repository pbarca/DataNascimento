using System;

namespace DataNascimento
{
    class DataNascimento
    {
        private DateTime data;
        public string recebe
        {
            set
            {
                data = Convert.ToDateTime(value);
            }
        }

        private string diasemana
        {
            get
            {
                string frase = "O dia da Semana em que nasceu é ";
                frase += data.ToString("dddd") + ".\n";
                return frase;
            }
        }
        private string idade
        {
            get
            {
                DateTime hoje = DateTime.Now;
                TimeSpan dif = hoje - data;
                DateTime idade = DateTime.MinValue + dif;
                string frase = "A sua idade é ";
                frase += (idade.Year - 1) + " anos, ";
                frase += (idade.Month - 1) + " meses e ";
                frase += (idade.Day - 1) + " dias.\n";
                return frase;
            }
        }
        private string signo
        {
            get
            {
                return "O seu signo é Salsicha. \n";
            }
        }
        public string envia
        {
            get
            {
                return diasemana + idade + signo;
            }
        }

    }
}
