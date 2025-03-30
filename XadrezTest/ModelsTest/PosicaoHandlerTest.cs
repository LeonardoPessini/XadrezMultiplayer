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
        var novaPosicaoEsperada = new Posicao("e4");

        _posicaoHandler.IncrementarColuna();

        Assert.Equal(novaPosicaoEsperada.Coluna, _posicaoHandler.Posicao.Coluna);
        Assert.Equal(novaPosicaoEsperada.Linha, _posicaoHandler.Posicao.Linha);
    }

    [Fact]
    public void DecrementarColuna_DeveDiminuirAColunaEm1()
    {
        var novaPosicaoEsperada = new Posicao("c4");

        _posicaoHandler.DecrementarColuna();

        Assert.True(novaPosicaoEsperada.Equals(_posicaoHandler.Posicao));
    }

    [Fact]
    public void IncrementarLinha_DeveAumentarALinhaEm1()
    {
        var novaPosicaoEsperada = new Posicao("d5");

        _posicaoHandler.IncrementarLinha();

        Assert.True(novaPosicaoEsperada.Equals(_posicaoHandler.Posicao));
    }

    [Fact]
    public void DecrementarLinha_DeveDiminuirALinhaEm1()
    {
        var novaPosicaoEsperada = new Posicao("d3");

        _posicaoHandler.DecrementarLinha();

        Assert.True(novaPosicaoEsperada.Equals(_posicaoHandler.Posicao));
    }
}
