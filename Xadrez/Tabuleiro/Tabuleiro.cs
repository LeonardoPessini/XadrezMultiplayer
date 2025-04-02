using Xadrez.Pecas;
using Xadrez.Posicoes;

namespace Xadrez.Tabuleiro;

public class Tabuleiro
{
    private readonly Dictionary<Posicao, Peca> _posicaoPecas;

    public Tabuleiro()
    {
        _posicaoPecas = PosicaoInicialTabuleiro.Get();
    }

}
