using Xadrez.Posicoes;

namespace XadrezTest;

public class PosicaoHandlerTest
{
    private readonly PosicaoHandler _posicaoHandler;

    public PosicaoHandlerTest()
    {
        var posicao = PosicaoFactory.Get("d4");
        _posicaoHandler = new PosicaoHandler(posicao!);
    }


    [Fact]
    public void IncrementarColuna_DeveAumentarACoulunaEm1()
    {
        var posicaoEsperada1 = PosicaoFactory.Get("e4")!;
        var posicaoEsperada2 = PosicaoFactory.Get("f4")!;

        _posicaoHandler.IncrementarColuna();
        Assert.Equal(posicaoEsperada1.Coluna, _posicaoHandler.Posicao!.Coluna);
        Assert.Equal(posicaoEsperada1.Linha, _posicaoHandler.Posicao!.Linha);

        _posicaoHandler.IncrementarColuna();
        Assert.Equal(posicaoEsperada2.Coluna, _posicaoHandler.Posicao.Coluna);
        Assert.Equal(posicaoEsperada2.Linha, _posicaoHandler.Posicao.Linha);
    }


    [Fact]
    public void DecrementarColuna_DeveDiminuirAColunaEm1()
    {
        var posicaoEsperada1 = PosicaoFactory.Get("c4")!;
        var posicaoEsperada2 = PosicaoFactory.Get("b4")!;

        _posicaoHandler.DecrementarColuna();
        Assert.Equal(posicaoEsperada1.Coluna, _posicaoHandler.Posicao!.Coluna);
        Assert.Equal(posicaoEsperada1.Linha, _posicaoHandler.Posicao.Linha);

        _posicaoHandler.DecrementarColuna();
        Assert.Equal(posicaoEsperada2.Coluna, _posicaoHandler.Posicao.Coluna);
        Assert.Equal(posicaoEsperada2.Linha, _posicaoHandler.Posicao.Linha);
    }


    [Fact]
    public void IncrementarLinha_DeveAumentarALinhaEm1()
    {
        var posicaoEsperada1 = PosicaoFactory.Get("d5")!;
        var posicaoEsperada2 = PosicaoFactory.Get("d6")!;

        _posicaoHandler.IncrementarLinha();
        Assert.Equal(posicaoEsperada1.Coluna, _posicaoHandler.Posicao!.Coluna);
        Assert.Equal(posicaoEsperada1.Linha, _posicaoHandler.Posicao.Linha);

        _posicaoHandler.IncrementarLinha();
        Assert.Equal(posicaoEsperada2.Coluna, _posicaoHandler.Posicao.Coluna);
        Assert.Equal(posicaoEsperada2.Linha, _posicaoHandler.Posicao.Linha);
    }


    [Fact]
    public void DecrementarLinha_DeveDiminuirALinhaEm1()
    {
        var posicaoEsperada1 = PosicaoFactory.Get("d3")!;
        var posicaoEsperada2 = PosicaoFactory.Get("d2")!;

        _posicaoHandler.DecrementarLinha();
        Assert.Equal(posicaoEsperada1.Coluna, _posicaoHandler.Posicao!.Coluna);
        Assert.Equal(posicaoEsperada1.Linha, _posicaoHandler.Posicao.Linha);

        _posicaoHandler.DecrementarLinha();
        Assert.Equal(posicaoEsperada2.Coluna, _posicaoHandler.Posicao.Coluna);
        Assert.Equal(posicaoEsperada2.Linha, _posicaoHandler.Posicao.Linha);
    }


    [Fact]
    public void DeveRetornarNullQuandoNaoForPossivelRealizarAOperacao()
    {
        var posicaoinvalida = PosicaoFactory.Get("h8")!;
        var handler = new PosicaoHandler(posicaoinvalida);

        //Tira o handler do tabuleiro
        handler.IncrementarColuna();

        Assert.Null(handler.Posicao);
    }
}
