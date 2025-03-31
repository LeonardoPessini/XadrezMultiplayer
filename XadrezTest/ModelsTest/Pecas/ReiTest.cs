using Xadrez.Models;
using Xadrez.Models.Pecas;

namespace XadrezTest.ModelsTest.Pecas;

public class ReiTest
{
    [Theory]
    [InlineData(Cor.Branca)]
    [InlineData(Cor.Preta)]
    public void New_DeveCriarPeca(Cor cor)
    {
        var rei = new Rei(cor);

        var posicaoInicial = cor == Cor.Branca ? new Posicao("e1") : new Posicao("e8");

        Assert.Equal(TipoPeca.Rei, rei.Tipo);
        Assert.Equal(cor, rei.Cor);
        Assert.Equal(posicaoInicial, rei.PosicaoAtual);
    }



}
