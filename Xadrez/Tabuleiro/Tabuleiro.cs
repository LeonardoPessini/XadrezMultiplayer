using Xadrez.Exceptions;
using Xadrez.Pecas;
using Xadrez.Posicoes;

namespace Xadrez.Tabuleiro;

public class Tabuleiro
{
    private readonly Dictionary<Posicao, Peca?> _posicaoPecas;

    public Tabuleiro()
    {
        _posicaoPecas = PosicaoInicialTabuleiro.Get();
    }

    public bool TemPeca(Posicao posicao)
    {
        VerificaSePosicaoExisteNoTabuleiro(posicao);
        return _posicaoPecas[posicao] != null;
    }

    private void VerificaSePosicaoExisteNoTabuleiro(Posicao posicao)
    {
        if ( !_posicaoPecas.ContainsKey(posicao) )
            throw new TabuleiroOutOfRangeException();
    }

    public Peca? ObterPecaDaPosicao(Posicao posicao)
    {
        VerificaSePosicaoExisteNoTabuleiro(posicao);
        return _posicaoPecas[posicao];
    }
}
