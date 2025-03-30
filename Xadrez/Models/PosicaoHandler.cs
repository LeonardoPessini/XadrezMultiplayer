using System.Text;

namespace Xadrez.Models;

public class PosicaoHandler
{
    public Posicao Posicao { get; private set; }

    public PosicaoHandler(Posicao posicao)
    {
        Posicao = posicao;
    }

    public void IncrementarColuna()
    {
        var ascii = Posicao.Coluna + 1;
        Posicao = PosicaoComNovaColuna((char)ascii);
    }

    public void DecrementarColuna()
    {
        var ascii = Posicao.Coluna - 1;
        Posicao = PosicaoComNovaColuna((char)ascii);
    }

    private Posicao PosicaoComNovaColuna(char coluna)
    {
        var novaPosicao = coluna.ToString() + Posicao.Linha.ToString();
        return new Posicao(novaPosicao);
    }


    public void IncrementarLinha()
    {
        var ascii = Posicao.Linha + 1;
        Posicao = PosicaoComNovaLinha((char)ascii);
    }

    public void DecrementarLinha()
    {
        var ascii = Posicao.Linha - 1;
        Posicao = PosicaoComNovaLinha((char)ascii);
    }

    private Posicao PosicaoComNovaLinha(char linha)
    {
        var novaPosicao = Posicao.Coluna.ToString() + linha.ToString();
        return new Posicao(novaPosicao);
    }
}
