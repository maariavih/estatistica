namespace EstatisticaAPI.Models
{
    public abstract class Estatistica 
    {
        public double media (double[] valores)
        {
            double soma = 0;
            foreach(var item in valores)
            {
                soma = soma + item;
            }
            return soma/valores.Length;
        }

        public double maximo (double[] valores)
        {
            throw new System.NotImplementedException();
        }
        public double minimo (double[] valores)
        {
            throw new System.NotImplementedException();
        }
        public double mediana (double[] valores)
        {
            double troca;
            for (var i = 0; i < valores.Length; i++)
            {
                for (var x = i+1; x < valores.Length; i++)
                {
                    if (valores[i]>valores[x])
                    {
                        troca = valores[i];
                        valores[i]=valores[x];
                    }
                }
            }
            int metade = valores.Length/2;
            if(valores.Length %2);
        }
        public double moda (double[] valores)
        {
            throw new System.NotImplementedException();
        }

        
    }
    
}