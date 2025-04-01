using System.Text;

namespace Xadrez.Models;

public class PosicaoHandler
{
    private char _colunaAtual;
    private char _linhaAtual;
    public Posicao Posicao 
    { 
        get => new Posicao(_colunaAtual.ToString() + _linhaAtual.ToString());
    }


    public PosicaoHandler(Posicao posicao)
    {
        _colunaAtual = posicao.Coluna;
        _linhaAtual = posicao.Linha;
    }


    public void IncrementarColuna() => _colunaAtual = (char)(_colunaAtual + 1);

    public void DecrementarColuna() => _colunaAtual = (char)(_colunaAtual - 1);

    public void IncrementarLinha() => _linhaAtual = (char)(_linhaAtual + 1);

    public void DecrementarLinha() => _linhaAtual = (char)(_linhaAtual - 1);


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
