using System.Collections.Immutable;
using Xadrez.Pecas;
using Xadrez.Posicoes;

namespace Xadrez.Tabuleiro;

public static class PosicaoInicialTabuleiro
{
    private static readonly ImmutableDictionary<Posicao, Peca?> _estadoInicialDoTabuleiro;
    private static readonly Dictionary<Posicao, Peca?> _posicaoPeca;

    static PosicaoInicialTabuleiro()
    {
        _posicaoPeca = [];
        _estadoInicialDoTabuleiro = GerarEstadoInicial();
    }

    public static Dictionary<Posicao,Peca?> Get()
    {
        return _estadoInicialDoTabuleiro.ToDictionary();
    }


    private static ImmutableDictionary<Posicao, Peca?> GerarEstadoInicial()
    {
        ColocarRei(Cor.Branca);
        ColocarDama(Cor.Branca);
        ColocarBispos(Cor.Branca);
        ColocarCavalos(Cor.Branca);
        ColocarTorres(Cor.Branca);
        ColocarPeoes(Cor.Branca);

        ColocarRei(Cor.Preta);
        ColocarDama(Cor.Preta);
        ColocarBispos(Cor.Preta);
        ColocarCavalos(Cor.Preta);
        ColocarTorres(Cor.Preta);
        ColocarPeoes(Cor.Preta);

        DeixarOutrasPoicoesVazias();

        return _posicaoPeca.ToImmutableDictionary();
    }


    private static void ColocarRei(Cor cor)
    {
        var rei = PecaFactory.Get(TipoPeca.Rei, cor);
        var posicao = (cor == Cor.Branca) ? "E1" : "E8";

        _posicaoPeca.Add(PosicaoFactory.Get(posicao)!, rei);
    }


    private static void ColocarDama(Cor cor)
    {
        var dama = PecaFactory.Get(TipoPeca.Dama, cor);
        var posicao = (cor == Cor.Branca) ? "D1" : "D8";

        _posicaoPeca.Add(PosicaoFactory.Get(posicao)!, dama);
    }


    private static void ColocarBispos(Cor cor)
    {
        var bispo = PecaFactory.Get(TipoPeca.Bispo, cor);
        string[] posicoes = (cor == Cor.Branca) ? [ "C1", "F1" ] : [ "C8", "F8" ];

        ColocarNoTabuleiro(posicoes, bispo);
    }


    private static void ColocarNoTabuleiro(string[] posicoes, Peca peca)
    {
        foreach (var posicao in posicoes)
            _posicaoPeca.Add(PosicaoFactory.Get(posicao)!, peca);
    }


    private static void ColocarCavalos(Cor cor)
    {
        var cavalo = PecaFactory.Get(TipoPeca.Cavalo, cor);
        string[] posicoes = (cor == Cor.Branca) ? ["B1", "G1"] : ["B8", "G8"];

        ColocarNoTabuleiro(posicoes, cavalo);
    }


    private static void ColocarTorres(Cor cor)
    {
        var torre = PecaFactory.Get(TipoPeca.Torre, cor);
        string[] posicoes = (cor == Cor.Branca) ? ["A1", "H1"] : ["A8", "H8"];

        ColocarNoTabuleiro(posicoes, torre);
    }


    private static void ColocarPeoes(Cor cor)
    {
        var peao = PecaFactory.Get(TipoPeca.Peao, cor);
        string[] posicoes = (cor == Cor.Branca) ?
            ["A2", "B2", "C2", "D2", "F2", "E2", "G2", "H2"] :
            ["A7", "B7", "C7", "D7", "E7", "F7", "G7", "H7"];

        ColocarNoTabuleiro(posicoes, peao);
    }


    private static void DeixarOutrasPoicoesVazias()
    {
        var posicoesVazias = new string[]
        {
            "A3", "A4", "A5", "A6",
            "B3", "B4", "B5", "B6",
            "C3", "C4", "C5", "C6",
            "D3", "D4", "D5", "D6",
            "E3", "E4", "E5", "E6",
            "F3", "F4", "F5", "F6",
            "G3", "G4", "G5", "G6",
            "H3", "H4", "H5", "H6"
        };

        foreach (var posicaoVazia in posicoesVazias)
            _posicaoPeca.Add(PosicaoFactory.Get(posicaoVazia)!, null);
    }
}
