namespace EstatisticaAPI.Models
{
    public interface IEstatistica
    {
        double media(string[] valores);
        double mediana(string[] valores);
        double maximo(string[] valores);
        double minimo(string[] valores);
        double moda(string[] valores);
    
    } 
}