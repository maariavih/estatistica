using Microsoft.VisualStudio.TestTools.UnitTesting;
using EstatisticaAPI;

namespace EstatisticaTest
{
    [TestClass]
    public class EstatisticaTest
    {

        [TestMethod]
        public void MediaSequenciaImpar()
        {
            Estatistica estatistica = new Estatistica();
            double[] valores = {2,9,7,1,5};
            double esperando = 5;
            double resultado;
        }
    }
}