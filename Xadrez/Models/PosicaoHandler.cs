using System.Text;

namespace Xadrez.Models;

public class PosicaoHandler
{
    private readonly Posicao _posicaoBase;
    public Posicao PosicaoAtual { get; private set; }

    public PosicaoHandler(Posicao posicao)
    {
        _posicaoBase = posicao;
        PosicaoAtual = new Posicao(_posicaoBase.Coluna.ToString() + _posicaoBase.Linha.ToString());
    }

    public void IncrementarColuna()
    {
        var ascii = PosicaoAtual.Coluna + 1;
        PosicaoAtual = PosicaoComNovaColuna((char)ascii);
    }

    public void DecrementarColuna()
    {
        var ascii = PosicaoAtual.Coluna - 1;
        PosicaoAtual = PosicaoComNovaColuna((char)ascii);
    }

    private Posicao PosicaoComNovaColuna(char coluna)
    {
        var novaPosicao = coluna.ToString() + PosicaoAtual.Linha.ToString();
        return new Posicao(novaPosicao);
    }


    public void IncrementarLinha()
    {
        var ascii = PosicaoAtual.Linha + 1;
        PosicaoAtual = PosicaoComNovaLinha((char)ascii);
    }

    public void DecrementarLinha()
    {
        var ascii = PosicaoAtual.Linha - 1;
        PosicaoAtual = PosicaoComNovaLinha((char)ascii);
    }

    private Posicao PosicaoComNovaLinha(char linha)
    {
        var novaPosicao = PosicaoAtual.Coluna.ToString() + linha.ToString();
        return new Posicao(novaPosicao);
    }
}
