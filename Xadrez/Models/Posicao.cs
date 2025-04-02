using Xadrez.Exceptions;

namespace Xadrez.Models;

public class Posicao
{
    private readonly char _coluna;
    private readonly char _linha;


    public Posicao(string posicaonoTabuleiro)
    {
        if (posicaonoTabuleiro.Length != 2)
            throw new PosicaoException();

        Coluna = posicaonoTabuleiro[0];
        Linha = posicaonoTabuleiro[1];
    }


    public char Coluna 
    { 
        get => _coluna; 
        init
        {
            var charUpper = char.ToLower(value);

            if (charUpper >= 'a' && charUpper <= 'h')
                _coluna = charUpper;

            else throw new PosicaoException();
        }
    }

    public char Linha 
    { 
        get => _linha; 
        init
        {
            if(value >= '1' && value <= '8')
                _linha = value;

            else throw new PosicaoException();
        }
    }

    public override bool Equals(object? obj)
    {
        var posicao = obj as Posicao;

        if (posicao == null)
            return false;

        return this.Linha.Equals(posicao.Linha) && this.Coluna.Equals(posicao.Coluna);
    }

    public override int GetHashCode()
    {
        return Linha.GetHashCode() + Coluna.GetHashCode();
    }

    public override string ToString()
    {
        return _coluna.ToString() + _linha.ToString();
    }
}
