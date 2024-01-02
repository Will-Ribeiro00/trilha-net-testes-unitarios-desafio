using TestesUnitarios_Desafio.Services;

namespace TestesUnitarios_Testes
{
    public class ValidacoesStringTests
    {
        private ValidacoesString _validacoes = new();
        [Fact]
        public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
        {
            //TODO: Corrigir a vari�vel "texto" e "resultadoEsperado" da se��o Arrange

            // Arrange
            var texto = "Matrix";
            var resultadoEsperado = 6;

            // Act
            var resultado = _validacoes.RetornarQuantidadeCaracteres(texto);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void DeveContemAPalavraQualquerNoTexto()
        {
            // Arrange
            var texto = "Esse � um texto qualquer";
            var textoProcurado = "qualquer";

            //TODO: Corrigir a chamada do m�todo "ContemCaractere" da se��o Act
            // Act
           var resultado =  _validacoes.ContemCaractere(texto, textoProcurado);

            // Assert
            //TODO: Corrigir o Assert.True com base no retorno da chamada ao m�todo
            Assert.True(resultado);
        }

        [Fact]
        public void NaoDeveConterAPalavraTesteNoTexto()
        {
            // Arrange
            var texto = "Esse � um texto qualquer";
            var textoProcurado = "teste";

            // Act
            var resultado = _validacoes.ContemCaractere(texto, textoProcurado);

            // Assert
            //TODO: Corrigir o Assert.False com base no retorno da chamada ao m�todo
            Assert.False(resultado);
        }

        //TODO: Corrigir a anota��o [Fact]
        public void TextoDeveTerminarComAPalavraProcurado()
        {
            //TODO: Corrigir a vari�vel "textoProcurado" se��o Arrange

            // Arrange
            var texto = "Come�o, meio e fim do texto procurado";
            var textoProcurado = "procurado";

            // Act
            var resultado = _validacoes.TextoTerminaCom(texto, textoProcurado);

            // Assert
            Assert.True(resultado);
        }
    }
}