using Xadrez.Models.Pecas;
using Xadrez.Models;

namespace XadrezTest.ModelsTest;

public class PecaBaseTest
{
    [Theory]
    [InlineData(Cor.Branca)]
    [InlineData(Cor.Preta)]
    public void Equals_DeveCompararPeca(Cor cor)
    {
        IPeca peca1 = new Rei(cor);
        IPeca peca2 = new Rei(cor);

        Assert.True(peca1.Equals(peca2));
    }
}
