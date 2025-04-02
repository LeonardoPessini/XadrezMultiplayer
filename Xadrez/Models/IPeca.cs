namespace Xadrez.Models;

public interface IPeca
{
    TipoPeca Tipo { get; }
    Cor Cor { get; }
    Posicao PosicaoAtual { get; }
    IEnumerable<Posicao> MovimentosPossiveisAPartirDe(Posicao posicaoInicial);
}
