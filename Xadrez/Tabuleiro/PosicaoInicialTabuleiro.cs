using System.Collections.Immutable;
using System.Runtime.ConstrainedExecution;
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
        ColocarPeoesBrancos();

        ColocarRei(Cor.Preta);
        ColocarDama(Cor.Preta);
        ColocarBispos(Cor.Preta);
        ColocarCavalos(Cor.Preta);
        ColocarTorres(Cor.Preta);
        ColocarPeoesPretos();

        DeixarOutrasPoicoesVazias();

        return _posicaoPeca.ToImmutableDictionary();
    }



    private static void ColocarRei(Cor cor)
    {
        var rei = PecaFactory.Get(TipoPeca.Rei, cor);
        var posicao = (cor == Cor.Branca) ? 
                            PosicaoFactory.Get("E1")! : 
                            PosicaoFactory.Get("E8")!;

        _posicaoPeca.Add(posicao, rei);
    }


    private static void ColocarDama(Cor cor)
    {
        var dama = PecaFactory.Get(TipoPeca.Dama, cor);
        var posicao = (cor == Cor.Branca) ?
                            PosicaoFactory.Get("D1")! :
                            PosicaoFactory.Get("D8")!;

        _posicaoPeca.Add(posicao, dama);
    }

    private static void ColocarBispos(Cor cor)
    {
        var bispo = PecaFactory.Get(TipoPeca.Bispo, cor);
        var posicoes = (cor == Cor.Branca) ?  
            new Posicao[] { PosicaoFactory.Get("C1")!, PosicaoFactory.Get("F1")! } : 
            new Posicao[] { PosicaoFactory.Get("C8")!, PosicaoFactory.Get("F8")! };

        ColocarNoTabuleiro(posicoes, bispo);
    }


    private static void ColocarNoTabuleiro(Posicao[] posicoes, Peca peca)
    {
        foreach (var posicao in posicoes)
            _posicaoPeca.Add(posicao, peca);
    }


    private static void ColocarCavalos(Cor cor)
    {
        var cavalo = PecaFactory.Get(TipoPeca.Cavalo, cor);
        var posicoes = (cor == Cor.Branca) ?
            new Posicao[] { PosicaoFactory.Get("B1")!, PosicaoFactory.Get("G1")! } :
            new Posicao[] { PosicaoFactory.Get("B8")!, PosicaoFactory.Get("G8")! };

        ColocarNoTabuleiro(posicoes, cavalo);
    }


    private static void ColocarTorres(Cor cor)
    {
        var torre = PecaFactory.Get(TipoPeca.Torre, cor);
        var posicoes = (cor == Cor.Branca) ?
            new Posicao[] { PosicaoFactory.Get("A1")!, PosicaoFactory.Get("H1")! } :
            new Posicao[] { PosicaoFactory.Get("A8")!, PosicaoFactory.Get("H8")! };

        ColocarNoTabuleiro(posicoes, torre);
    }


    private static void ColocarPeoesBrancos()
    {
        var peao = PecaFactory.Get(TipoPeca.Peao, Cor.Branca);

        var posicoes = new Posicao[] {
            PosicaoFactory.Get("A2")!,
            PosicaoFactory.Get("B2")!,
            PosicaoFactory.Get("C2")!,
            PosicaoFactory.Get("D2")!,
            PosicaoFactory.Get("E2")!,
            PosicaoFactory.Get("F2")!,
            PosicaoFactory.Get("G2")!,
            PosicaoFactory.Get("H2")!
        };

        ColocarNoTabuleiro(posicoes, peao);
    }

    private static void ColocarPeoesPretos()
    {
        var peao = PecaFactory.Get(TipoPeca.Peao, Cor.Preta);

        var posicoes = new Posicao[] {
            PosicaoFactory.Get("A7")!,
            PosicaoFactory.Get("B7")!,
            PosicaoFactory.Get("C7")!,
            PosicaoFactory.Get("D7")!,
            PosicaoFactory.Get("E7")!,
            PosicaoFactory.Get("F7")!,
            PosicaoFactory.Get("G7")!,
            PosicaoFactory.Get("H7")!
        };

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
