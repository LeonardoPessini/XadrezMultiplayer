using Xadrez.Exceptions;
using Xadrez.Posicoes;


namespace XadrezTest;

public class PosicaoTest
{
    [Theory]
    [InlineData("a1")]
    [InlineData("a8")]
    [InlineData("h1")]
    [InlineData("h8")]
    public void New_DeveCriarPosicao(string posicao)
    {
        var posicaoCriada = PosicaoFactory.Get(posicao);

        Assert.NotNull(posicaoCriada);
        Assert.Equal(posicao[0], posicaoCriada.Coluna);
        Assert.Equal(posicao[1], posicaoCriada.Linha);
    }


    [Theory]
    [InlineData("A1")]
    [InlineData("A8")]
    [InlineData("H1")]
    [InlineData("H8")]
    public void New_DeveCriarComCaracteresMinusculos(string posicao)
    {
        var colunaMaiuscula = char.ToLower(posicao[0]);
        var posicaoCriada = new Posicao(posicao);

        Assert.NotNull(posicaoCriada);
        Assert.Equal(colunaMaiuscula, posicaoCriada.Coluna);
    }


    [Theory]
    [InlineData("i1")]
    [InlineData("@1")]
    [InlineData("a0")]
    [InlineData("a9")]
    [InlineData("a11")]
    public void New_NaoDeveCriarPosicaoInvalida(string posicao)
    {
        Assert.Throws<PosicaoException>(() => new Posicao(posicao));
    }


    [Fact]
    public void Equal_DeveCompararDuasPosicoesCorretamente()
    {
        var posicaoStringA = "a1";
        var posicaoStringB = "h8";

        var posicao1 = new Posicao(posicaoStringA);
        var posicao2 = new Posicao(posicaoStringA);
        var posicao3 = new Posicao(posicaoStringB);

        Assert.True(posicao1.Equals(posicao2));
        Assert.False(posicao1.Equals(posicao3));
    }


}
