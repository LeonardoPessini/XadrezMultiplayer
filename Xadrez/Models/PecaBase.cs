
using Xadrez.Exceptions;

namespace Xadrez.Models;

public abstract class PecaBase : IPeca
{
    public TipoPeca Tipo { get; init; }

    public Cor Cor { get; init; }

    public Posicao PosicaoAtual { get; protected set; } = null!;


    protected PecaBase(TipoPeca tipo, Cor cor)
    {
        Tipo = tipo;
        Cor = cor;
    }

    public override bool Equals(object? obj)
    {
        var peca = obj as IPeca;

        if (peca == null)
            return false;

        return peca.Tipo == this.Tipo
            && peca.Cor == this.Cor
            && peca.PosicaoAtual.Equals(this.PosicaoAtual);
    }


    public override int GetHashCode() =>
        Tipo.GetHashCode() + Cor.GetHashCode() + PosicaoAtual.GetHashCode();

    public abstract IEnumerable<Posicao> MovimentosPossiveisAPartirDe(Posicao posicaoInicial);
}
