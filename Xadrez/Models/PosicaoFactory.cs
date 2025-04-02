using System.Collections.Concurrent;
using System.Collections.Immutable;
using Xadrez.Exceptions;

namespace Xadrez.Models;

public static class PosicaoFactory
{
    private static readonly ImmutableDictionary<string, Posicao> _posicoes;

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
                var posicao = ((char)coluna).ToString() + ((char)linha).ToString();
                posicoes.Add(posicao, new Posicao(posicao));
            }
        }

        _posicoes = posicoes.ToImmutableDictionary();
    }

    public static Posicao? Get(string posicao)
    {
        return _posicoes.ContainsKey(posicao) ? _posicoes[posicao] : null;
    }
}
