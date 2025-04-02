using System.Collections.Concurrent;
using System.Collections.Immutable;
using Xadrez.Exceptions;

namespace Xadrez.Posicoes;

public static class PosicaoFactory
{
    static readonly ImmutableDictionary<string, Posicao> Posicoes;

    static PosicaoFactory()
    {
        var posicoes = new SortedDictionary<string, Posicao>();
        var colunaInicial = 'a';
        var linhaInicial = '1';
        var colunaFinal = 'h';
        var linhaFinal = '8';

        for (char coluna = colunaInicial; coluna <= colunaFinal; ++coluna)
        {
            for (char linha = linhaInicial; linha <= linhaFinal; ++linha)
            {
                var posicao = coluna.ToString() + linha.ToString();
                posicoes.Add(posicao, new Posicao(posicao));
            }
        }

        Posicoes = posicoes.ToImmutableDictionary();
    }

    public static Posicao? Get(string posicao)
    {
        var posicaoComLetrasMinusculas = posicao.ToLower();
        return Posicoes.ContainsKey(posicaoComLetrasMinusculas) ? Posicoes[posicaoComLetrasMinusculas] : null;
    }
}
