using Xadrez.Models;

namespace XadrezTest.ModelsTest;

public class PosicaoHandlerTest
{
    private PosicaoHandler _posicaoHandler;

    public PosicaoHandlerTest()
    {
        var posicao = new Posicao("d4");
        _posicaoHandler = new PosicaoHandler(posicao);
    }


    [Fact]
    public void IncrementarColuna_DeveAumentarACoulunaEm1()
    {
        var posicaoEsperada1 = new Posicao("e4");
        var posicaoEsperada2 = new Posicao("f4");

        _posicaoHandler.IncrementarColuna();
        Assert.Equal(posicaoEsperada1.Coluna, _posicaoHandler.Posicao.Coluna);
        Assert.Equal(posicaoEsperada1.Linha, _posicaoHandler.Posicao.Linha);

        _posicaoHandler.IncrementarColuna();
        Assert.Equal(posicaoEsperada2.Coluna, _posicaoHandler.Posicao.Coluna);
        Assert.Equal(posicaoEsperada2.Linha, _posicaoHandler.Posicao.Linha);
    }


    [Fact]
    public void DecrementarColuna_DeveDiminuirAColunaEm1()
    {
        var posicaoEsperada1 = new Posicao("c4");
        var posicaoEsperada2 = new Posicao("b4");

        _posicaoHandler.DecrementarColuna();
        Assert.Equal(posicaoEsperada1.Coluna, _posicaoHandler.Posicao.Coluna);
        Assert.Equal(posicaoEsperada1.Linha, _posicaoHandler.Posicao.Linha);

        _posicaoHandler.DecrementarColuna();
        Assert.Equal(posicaoEsperada2.Coluna, _posicaoHandler.Posicao.Coluna);
        Assert.Equal(posicaoEsperada2.Linha, _posicaoHandler.Posicao.Linha);
    }


    [Fact]
    public void IncrementarLinha_DeveAumentarALinhaEm1()
    {
        var posicaoEsperada1 = new Posicao("d5");
        var posicaoEsperada2 = new Posicao("d6");

        _posicaoHandler.IncrementarLinha(); 
        Assert.Equal(posicaoEsperada1.Coluna, _posicaoHandler.Posicao.Coluna);
        Assert.Equal(posicaoEsperada1.Linha, _posicaoHandler.Posicao.Linha);

        _posicaoHandler.IncrementarLinha();
        Assert.Equal(posicaoEsperada2.Coluna, _posicaoHandler.Posicao.Coluna);
        Assert.Equal(posicaoEsperada2.Linha, _posicaoHandler.Posicao.Linha);
    }


    [Fact]
    public void DecrementarLinha_DeveDiminuirALinhaEm1()
    {
        var posicaoEsperada1 = new Posicao("d3");
        var posicaoEsperada2 = new Posicao("d2");

        _posicaoHandler.DecrementarLinha();
        Assert.Equal(posicaoEsperada1.Coluna, _posicaoHandler.Posicao.Coluna);
        Assert.Equal(posicaoEsperada1.Linha, _posicaoHandler.Posicao.Linha);

        _posicaoHandler.DecrementarLinha();
        Assert.Equal(posicaoEsperada2.Coluna, _posicaoHandler.Posicao.Coluna);
        Assert.Equal(posicaoEsperada2.Linha, _posicaoHandler.Posicao.Linha);
    }


    [Fact]
    public void TryIncrementarCluna_DeveretornarValorCorreto()
    {
        var posicaoinicial = new Posicao("g4");
        var handler = new PosicaoHandler(posicaoinicial);

        Assert.True(handler.TryIncrementarColuna());
        Assert.False(handler.TryIncrementarColuna());
    }


    [Fact]
    public void TryIncrementarLinha_DeveretornarValorCorreto()
    {
        var posicaoinicial = new Posicao("d7");
        var handler = new PosicaoHandler(posicaoinicial);

        Assert.True(handler.TryIncrementarLinha());
        Assert.False(handler.TryIncrementarLinha());
    }


    [Fact]
    public void TryDecrementarColuna_DeveretornarValorCorreto()
    {
        var posicaoinicial = new Posicao("b4");
        var handler = new PosicaoHandler(posicaoinicial);

        Assert.True(handler.TryDecrementarColuna());
        Assert.False(handler.TryDecrementarColuna());
    }


    [Fact]
    public void TryDecrementarlinha_DeveretornarValorCorreto()
    {
        var posicaoinicial = new Posicao("d2");
        var handler = new PosicaoHandler(posicaoinicial);

        Assert.True(handler.TryDecrementarLinha());
        Assert.False(handler.TryDecrementarLinha());
    }
}
