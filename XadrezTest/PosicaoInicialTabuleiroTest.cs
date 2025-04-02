using Xadrez.Pecas;
using Xadrez.Posicoes;
using Xadrez.Tabuleiro;

namespace XadrezTest;

public class PosicaoInicialTabuleiroTest
{
    Dictionary<Posicao, Xadrez.Pecas.Peca?> _posicaoInicial;
    public PosicaoInicialTabuleiroTest()
    {
        _posicaoInicial = PosicaoInicialTabuleiro.Get();
    }

    [Fact]
    public void Get_DeveColocarReiCorretamente()
    {
        var reiBranco = _posicaoInicial[PosicaoFactory.Get("E1")!];
        var reiPreto = _posicaoInicial[PosicaoFactory.Get("E8")!];

        Assert.NotNull(reiBranco);
        Assert.NotNull(reiPreto);
        Assert.Equal(Cor.Branca, reiBranco.Cor);
        Assert.Equal(Cor.Preta, reiPreto.Cor);
        Assert.Equal(TipoPeca.Rei, reiBranco.Tipo);
        Assert.Equal(TipoPeca.Rei, reiPreto.Tipo);
    }

    [Fact]
    public void Get_DeveColocarDamaCorretamente()
    {
        var damaBranco = _posicaoInicial[PosicaoFactory.Get("D1")!];
        var damaPreto = _posicaoInicial[PosicaoFactory.Get("D8")!];

        Assert.NotNull(damaBranco);
        Assert.NotNull(damaPreto);
        Assert.Equal(Cor.Branca, damaBranco.Cor);
        Assert.Equal(Cor.Preta, damaPreto.Cor);
        Assert.Equal(TipoPeca.Dama, damaBranco.Tipo);
        Assert.Equal(TipoPeca.Dama, damaPreto.Tipo);
    }


    [Fact]
    public void Get_DeveColocarBispoCorretamente()
    {
        var bispoBranco1 = _posicaoInicial[PosicaoFactory.Get("C1")!];
        var bispoBranco2 = _posicaoInicial[PosicaoFactory.Get("F1")!];
        var bispoPreto1 = _posicaoInicial[PosicaoFactory.Get("C8")!];
        var bispoPreto2 = _posicaoInicial[PosicaoFactory.Get("F8")!];

        Assert.NotNull(bispoBranco1);
        Assert.NotNull(bispoBranco2);
        Assert.NotNull(bispoPreto1);
        Assert.NotNull(bispoPreto2);
        Assert.Equal(Cor.Branca, bispoBranco1.Cor);
        Assert.Equal(Cor.Branca, bispoBranco2.Cor);
        Assert.Equal(Cor.Preta, bispoPreto1.Cor);
        Assert.Equal(Cor.Preta, bispoPreto2.Cor);
        Assert.Equal(TipoPeca.Bispo, bispoBranco1.Tipo);
        Assert.Equal(TipoPeca.Bispo, bispoBranco2.Tipo);
        Assert.Equal(TipoPeca.Bispo, bispoPreto1.Tipo);
        Assert.Equal(TipoPeca.Bispo, bispoPreto2.Tipo);
    }


    [Fact]
    public void Get_DeveColocarCavaloCorretamente()
    {
        var cavaloBranco1 = _posicaoInicial[PosicaoFactory.Get("B1")!];
        var cavaloBranco2 = _posicaoInicial[PosicaoFactory.Get("G1")!];
        var cavaloPreto1 = _posicaoInicial[PosicaoFactory.Get("B8")!];
        var cavaloPreto2 = _posicaoInicial[PosicaoFactory.Get("G8")!];

        Assert.NotNull(cavaloBranco1);
        Assert.NotNull(cavaloBranco2);
        Assert.NotNull(cavaloPreto1);
        Assert.NotNull(cavaloPreto2);
        Assert.Equal(Cor.Branca, cavaloBranco1.Cor);
        Assert.Equal(Cor.Branca, cavaloBranco2.Cor);
        Assert.Equal(Cor.Preta, cavaloPreto1.Cor);
        Assert.Equal(Cor.Preta, cavaloPreto2.Cor);
        Assert.Equal(TipoPeca.Cavalo, cavaloBranco1.Tipo);
        Assert.Equal(TipoPeca.Cavalo, cavaloBranco2.Tipo);
        Assert.Equal(TipoPeca.Cavalo, cavaloPreto1.Tipo);
        Assert.Equal(TipoPeca.Cavalo, cavaloPreto2.Tipo);
    }


    [Fact]
    public void Get_DeveColocarTorreCorretamente()
    {
        var torreBranco1 = _posicaoInicial[PosicaoFactory.Get("A1")!];
        var torreBranco2 = _posicaoInicial[PosicaoFactory.Get("H1")!];
        var torrePreto1 = _posicaoInicial[PosicaoFactory.Get("A8")!];
        var torrePreto2 = _posicaoInicial[PosicaoFactory.Get("H8")!];

        Assert.NotNull(torreBranco1);
        Assert.NotNull(torreBranco2);
        Assert.NotNull(torrePreto1);
        Assert.NotNull(torrePreto2);
        Assert.Equal(Cor.Branca, torreBranco1.Cor);
        Assert.Equal(Cor.Branca, torreBranco2.Cor);
        Assert.Equal(Cor.Preta, torrePreto1.Cor);
        Assert.Equal(Cor.Preta, torrePreto2.Cor);
        Assert.Equal(TipoPeca.Torre, torreBranco1.Tipo);
        Assert.Equal(TipoPeca.Torre, torreBranco2.Tipo);
        Assert.Equal(TipoPeca.Torre, torrePreto1.Tipo);
        Assert.Equal(TipoPeca.Torre, torrePreto2.Tipo);
    }


    [Fact]
    public void Get_DeveColocarPeoesCorretamente()
    {
        var peoesBrancos = _posicaoInicial.Where(v => v.Key.Linha == '2')
                                          .Select(p => p.Value);
        var peoesPretos = _posicaoInicial.Where(v => v.Key.Linha == '7')
                                  .Select(p => p.Value);

        Assert.Equal(8, peoesBrancos.Count());
        Assert.Equal(8, peoesPretos.Count());

        foreach(var peao in peoesBrancos)
        {
            Assert.NotNull(peao);
            Assert.Equal(Cor.Branca, peao.Cor);
            Assert.Equal(TipoPeca.Peao, peao.Tipo);
        }

        foreach (var peao in peoesPretos)
        {
            Assert.NotNull(peao);
            Assert.Equal(Cor.Preta, peao.Cor);
            Assert.Equal(TipoPeca.Peao, peao.Tipo);
        }
    }


    [Fact]
    public void Get_DeveDeixarORestanteDasposicoesVazias()
    {
        var casasVazias = _posicaoInicial
            .Where(c =>
                c.Key.Linha == '3' ||
                c.Key.Linha == '4' ||
                c.Key.Linha == '5' ||
                c.Key.Linha == '6'
            ).Select(c => c.Value);

        Assert.Equal(32, casasVazias.Count());

        foreach (var casa in casasVazias)
        {
            Assert.Null(casa);
        }
    }
}
