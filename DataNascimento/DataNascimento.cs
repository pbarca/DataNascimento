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
                string frase = "O dia da Semana em que você nasceu é ";
                frase += data.ToString("dddd") + ".\n";
                return frase;
            }
        }
        private string idade
        {
            get
            {
                return "Tem 99 anos e meio. \n";
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
