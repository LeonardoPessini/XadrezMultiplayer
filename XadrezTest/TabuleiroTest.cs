using Xadrez.Pecas;
using Xadrez.Posicoes;
using Xadrez.Tabuleiro;

namespace XadrezTest;

public class TabuleiroTest
{
    private Tabuleiro _tabuleiro;
    private string[] _posicoesComPecasIniciais;
    private string[] _posicoesSemPecasIniciais;
    public TabuleiroTest()
    {
        _tabuleiro = new Tabuleiro();

        _posicoesComPecasIniciais =
        [
            "A1","B1","C1","D1","E1","F1","G1","H1",
            "A2","B2","C2","D2","E2","F2","G2","H2",

            "A7","B7","C7","D7","E7","F7","G7","H7",
            "A8","B8","C8","D8","E8","F8","G8","H8"
        ];

        _posicoesSemPecasIniciais =
        [
            "A3","B3","C3","D3","E3","F3","G3","H3",
            "A4","B4","C4","D4","E4","F4","G4","H4",
            "A5","B5","C5","D5","E5","F5","G5","H5",
            "A6","B6","C6","D6","E6","F6","G6","H6"
        ];
    }

    [Fact]
    public void TemPeca_DeveRetornarAPecaSeTiver()
    {
        foreach (var posicao in _posicoesComPecasIniciais)
            Assert.True(_tabuleiro.TemPeca(PosicaoFactory.Get(posicao)!));
    }

    [Fact]
    public void TemPeca_DeveRetornarFalseCasoNaoTenha()
    {
        foreach (var posicao in _posicoesSemPecasIniciais)
            Assert.False(_tabuleiro.TemPeca(PosicaoFactory.Get(posicao)!));
    }

    [Fact]
    public void ObterPecaDaPosicao_DeveRetornarReiCorretamente()
    {
        var reiBranco = _tabuleiro.ObterPecaDaPosicao(PosicaoFactory.Get("E1")!);
        var reiPreto = _tabuleiro.ObterPecaDaPosicao(PosicaoFactory.Get("E8")!);

        Assert.NotNull(reiBranco);
        Assert.NotNull(reiPreto);
        Assert.Equal(reiBranco, PecaFactory.Get(TipoPeca.Rei, Cor.Branca));
        Assert.Equal(reiPreto, PecaFactory.Get(TipoPeca.Rei, Cor.Preta));
    }

    [Fact]
    public void ObterPecaDaPosicao_DeveRetornarDamaCorretamente()
    {
        var damaBranco = _tabuleiro.ObterPecaDaPosicao(PosicaoFactory.Get("D1")!);
        var damaPreto = _tabuleiro.ObterPecaDaPosicao(PosicaoFactory.Get("D8")!);

        Assert.NotNull(damaBranco);
        Assert.NotNull(damaPreto);
        Assert.Equal(damaBranco, PecaFactory.Get(TipoPeca.Dama, Cor.Branca));
        Assert.Equal(damaPreto, PecaFactory.Get(TipoPeca.Dama, Cor.Preta));
    }


    [Fact]
    public void ObterPecaDaPosicao_DeveRetornarBispoCorretamente()
    {
        var bispoBranco1 = _tabuleiro.ObterPecaDaPosicao(PosicaoFactory.Get("C1")!);
        var bispoBranco2 = _tabuleiro.ObterPecaDaPosicao(PosicaoFactory.Get("F1")!);
        var bispoPreto1 = _tabuleiro.ObterPecaDaPosicao(PosicaoFactory.Get("C8")!);
        var bispoPreto2 = _tabuleiro.ObterPecaDaPosicao(PosicaoFactory.Get("F8")!);

        Assert.NotNull(bispoBranco1);
        Assert.NotNull(bispoBranco2);
        Assert.NotNull(bispoPreto1);
        Assert.NotNull(bispoPreto2);
        Assert.Equal(bispoBranco1, PecaFactory.Get(TipoPeca.Bispo, Cor.Branca));
        Assert.Equal(bispoBranco2, PecaFactory.Get(TipoPeca.Bispo, Cor.Branca));
        Assert.Equal(bispoPreto1, PecaFactory.Get(TipoPeca.Bispo, Cor.Preta));
        Assert.Equal(bispoPreto2, PecaFactory.Get(TipoPeca.Bispo, Cor.Preta));
    }


    [Fact]
    public void ObterPecaDaPosicao_DeveRetornarCavaloCorretamente()
    {
        var cavaloBranco1 = _tabuleiro.ObterPecaDaPosicao(PosicaoFactory.Get("B1")!);
        var cavaloBranco2 = _tabuleiro.ObterPecaDaPosicao(PosicaoFactory.Get("G1")!);
        var cavaloPreto1 = _tabuleiro.ObterPecaDaPosicao(PosicaoFactory.Get("B8")!);
        var cavaloPreto2 = _tabuleiro.ObterPecaDaPosicao(PosicaoFactory.Get("G8")!);

        Assert.NotNull(cavaloBranco1);
        Assert.NotNull(cavaloBranco2);
        Assert.NotNull(cavaloPreto1);
        Assert.NotNull(cavaloPreto2);
        Assert.Equal(cavaloBranco1, PecaFactory.Get(TipoPeca.Cavalo, Cor.Branca));
        Assert.Equal(cavaloBranco2, PecaFactory.Get(TipoPeca.Cavalo, Cor.Branca));
        Assert.Equal(cavaloPreto1, PecaFactory.Get(TipoPeca.Cavalo, Cor.Preta));
        Assert.Equal(cavaloPreto2, PecaFactory.Get(TipoPeca.Cavalo, Cor.Preta));
    }


    [Fact]
    public void ObterPecaDaPosicao_DeveRetornarTorreCorretamente()
    {
        var torreBranco1 = _tabuleiro.ObterPecaDaPosicao(PosicaoFactory.Get("A1")!);
        var torreBranco2 = _tabuleiro.ObterPecaDaPosicao(PosicaoFactory.Get("H1")!);
        var torrePreto1 = _tabuleiro.ObterPecaDaPosicao(PosicaoFactory.Get("A8")!);
        var torrePreto2 = _tabuleiro.ObterPecaDaPosicao(PosicaoFactory.Get("H8")!);

        Assert.NotNull(torreBranco1);
        Assert.NotNull(torreBranco2);
        Assert.NotNull(torrePreto1);
        Assert.NotNull(torrePreto2);
        Assert.Equal(torreBranco1, PecaFactory.Get(TipoPeca.Torre, Cor.Branca));
        Assert.Equal(torreBranco2, PecaFactory.Get(TipoPeca.Torre, Cor.Branca));
        Assert.Equal(torrePreto1, PecaFactory.Get(TipoPeca.Torre, Cor.Preta));
        Assert.Equal(torrePreto2, PecaFactory.Get(TipoPeca.Torre, Cor.Preta));
    }


    [Fact]
    public void ObterPecaDaPosicao_DeveRetornarPeoesCorretamente()
    {
        string[] PosicaoPeoesBrancos = ["A2", "B2", "C2", "D2", "E2", "F2", "G2", "H2"];
        string[] PosicaoPeoesPretos = ["A7", "B7", "C7", "D7", "E7", "F7", "G7", "H7"];

        foreach (var posicao in PosicaoPeoesBrancos)
        {
            var peao = _tabuleiro.ObterPecaDaPosicao(PosicaoFactory.Get(posicao)!);
            Assert.NotNull(peao);
            Assert.Equal(peao, PecaFactory.Get(TipoPeca.Peao, Cor.Branca));
        }

        foreach (var posicao in PosicaoPeoesPretos)
        {
            var peao = _tabuleiro.ObterPecaDaPosicao(PosicaoFactory.Get(posicao)!);
            Assert.NotNull(peao);
            Assert.Equal(peao, PecaFactory.Get(TipoPeca.Peao, Cor.Preta));
        }
    }


    [Fact]
    public void ObterPecaDaPosicao_DeveRetornarORestanteDasposicoesVaziasComoNull()
    {
        foreach (var casa in _posicoesSemPecasIniciais)
        {
            Assert.Null(_tabuleiro.ObterPecaDaPosicao(PosicaoFactory.Get(casa)!));
        }
    }
}
