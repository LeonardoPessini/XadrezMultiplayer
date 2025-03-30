namespace Xadrez.Models;

public interface IPeca
{
    TipoPeca Tipo { get; }
    public Cor Cor { get; }
    public Posicao PosicaoAtual { get; }
    public IEnumerable<Posicao> MovimentosPossiveis { get; }
    public void Mover(Posicao posicaoDesejada);
}
