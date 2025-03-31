using System.Text;

namespace Xadrez.Models;

public class PosicaoHandler
{
    private char _colunaAtual;
    private char _linhaAtual;
    public Posicao Posicao { get; private set; }

    public PosicaoHandler(Posicao posicao)
    {
        _colunaAtual = posicao.Coluna;
        _linhaAtual = posicao.Linha;
        Posicao = new Posicao(_colunaAtual.ToString() + _linhaAtual.ToString());
    }

    public void IncrementarColuna()
    {
        var ascii = _colunaAtual + 1;
        Posicao = PosicaoComNovaColuna((char)ascii);
    }

    public void DecrementarColuna()
    {
        var ascii = _colunaAtual - 1;
        Posicao = PosicaoComNovaColuna((char)ascii);
    }

    private Posicao PosicaoComNovaColuna(char coluna)
    {
        _colunaAtual = coluna;
        var novaPosicao = coluna.ToString() + Posicao.Linha.ToString();
        return new Posicao(novaPosicao);
    }


    public void IncrementarLinha()
    {
        var ascii = _linhaAtual + 1;
        Posicao = PosicaoComNovaLinha((char)ascii);
    }

    public void DecrementarLinha()
    {
        var ascii = _linhaAtual - 1;
        Posicao = PosicaoComNovaLinha((char)ascii);
    }

    private Posicao PosicaoComNovaLinha(char linha)
    {
        _linhaAtual = linha;
        var novaPosicao = Posicao.Coluna.ToString() + linha.ToString();
        return new Posicao(novaPosicao);
    }


    public bool TryIncrementarColuna()
    {
        try{
            IncrementarColuna();
            return true;
        }catch{
            return false;
        }
    }

    public bool TryDecrementarColuna()
    {
        try{
            DecrementarColuna();
            return true;
        }catch{
            return false;
        }
    }

    public bool TryIncrementarLinha()
    {
        try{
            IncrementarLinha();
            return true;
        }catch{
            return false;
        }
    }

    public bool TryDecrementarLinha()
    {
        try{
            DecrementarLinha();
            return true;
        }catch{
            return false;
        }
    }
}
