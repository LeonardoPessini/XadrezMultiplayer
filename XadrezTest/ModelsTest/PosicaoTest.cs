using Xadrez.Exceptions;
using Xadrez.Models;


namespace XadrezTest.ModelsTest;

public class PosicaoTest
{
    [Theory]
    [InlineData("A1")]
    [InlineData("A8")]
    [InlineData("H1")]
    [InlineData("H8")]
    public void New_DeveCriarPosicao(string posicao)
    {
        var posicaoCriada = new Posicao(posicao);

        Assert.NotNull(posicaoCriada);
        Assert.Equal(posicao[0], posicaoCriada.Coluna);
        Assert.Equal(posicao[1], posicaoCriada.Linha);
    }


    [Theory]
    [InlineData("a1")]
    [InlineData("a8")]
    [InlineData("h1")]
    [InlineData("h8")]
    public void New_DeveCriarComCaracteresMaiustulos(string posicao)
    {
        var colunaMaiuscula = char.ToUpper(posicao[0]);
        var posicaoCriada = new Posicao(posicao);

        Assert.NotNull(posicaoCriada);
        Assert.Equal(colunaMaiuscula, posicaoCriada.Coluna);
    }


    [Theory]
    [InlineData("I1")]
    [InlineData("@1")]
    [InlineData("A0")]
    [InlineData("A9")]
    [InlineData("A11")]
    public void New_NaoDeveCriarPosicaoInvalida(string posicao)
    {
        Assert.Throws<PosicaoException>(() => new Posicao(posicao));
    }


    [Fact]
    public void Equal_DeveCompararDuasPosicoesCorretamente()
    {
        var posicaoStringA = "A1";
        var posicaoStringB = "H8";

        var posicao1 = new Posicao(posicaoStringA);
        var posicao2 = new Posicao(posicaoStringA);
        var posicao3 = new Posicao(posicaoStringB);

        Assert.True(posicao1.Equals(posicao2));
        Assert.False(posicao1.Equals(posicao3));
    }


}
