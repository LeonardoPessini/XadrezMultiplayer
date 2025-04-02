using System.Text;

namespace Xadrez.Posicoes;

public class PosicaoHandler
{
    private char _colunaAtual;
    private char _linhaAtual;

    public Posicao? Posicao
    {
        get => PosicaoFactory.Get(_colunaAtual.ToString() + _linhaAtual.ToString());
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
}
