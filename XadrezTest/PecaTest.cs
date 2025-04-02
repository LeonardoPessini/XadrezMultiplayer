using System.Security.Cryptography.X509Certificates;
using Xadrez.Pecas;

namespace XadrezTest;

public class PecaTest
{
    [Theory]
    [InlineData(Cor.Branca,TipoPeca.Rei)]
    [InlineData(Cor.Branca, TipoPeca.Dama)]
    [InlineData(Cor.Branca, TipoPeca.Bispo)]
    [InlineData(Cor.Branca, TipoPeca.Cavalo)]
    [InlineData(Cor.Branca, TipoPeca.Torre)]
    [InlineData(Cor.Branca, TipoPeca.Peao)]
    [InlineData(Cor.Preta, TipoPeca.Rei)]
    [InlineData(Cor.Preta, TipoPeca.Dama)]
    [InlineData(Cor.Preta, TipoPeca.Bispo)]
    [InlineData(Cor.Preta, TipoPeca.Cavalo)]
    [InlineData(Cor.Preta, TipoPeca.Torre)]
    [InlineData(Cor.Preta, TipoPeca.Peao)]

    public void New_DeveCriarPeca(Cor cor, TipoPeca peca)
    {
        var pecaCriada = new Peca(peca, cor);

        Assert.Equal(cor, pecaCriada.Cor);
        Assert.Equal(peca, pecaCriada.Tipo);
    }

}
