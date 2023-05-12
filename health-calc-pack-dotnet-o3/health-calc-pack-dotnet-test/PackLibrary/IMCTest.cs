using health_calc_pack_dotnet_pack;
using health_calc_pack_dotnet_pack.Interfaces;

namespace health_calc_pack_dotnet_test.PackLibrary
{
    public class IMCTest
    {
        [Fact]
        public void CalculaIMC_QuandoDadosValidos_EntaoRetornaIncide()
        {
            //Arrange
            IIMC imc = new IMC();
            double Height = 1.71;
            double Weight = 94.5;
            double ExpectedIMC = 32.32;

            //Act
            var result = imc.Calc(Height, Weight);

            //Asserts
            Assert.Equal(ExpectedIMC, result);
        }

        [Fact]
        public void ValidaDadosIMC_QuandoDadosValidos_EntaoRetornaVerdadeiro()
        {
            //Arrange
            IIMC imc = new IMC();
            double Height = 10.0;
            double Weight = 400.0;
            bool Expected = false;

            //Act
            var result = imc.IsValidData(Height, Weight);

            //Asserts
            Assert.Equal(Expected, result);
        }

        [Fact]
        public void RetornaCategoriaIMC_QuandoIndiceValido_EntaoRetornaDescricao()
        {
            //Arrange
            IIMC imc = new IMC();
            double ValorIMC = 30.55;
            string Expected = "OBSIDADE";

            //Act
            var result = imc.GetIMCCategory(ValorIMC);

            //Asserts
            Assert.Equal(Expected, result);
        }
    }
}