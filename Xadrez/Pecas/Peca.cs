using Xadrez.Exceptions;
using Xadrez.Posicoes;

namespace Xadrez.Pecas;

public class Peca(TipoPeca tipo, Cor cor)
{
    public TipoPeca Tipo { get; init; } = tipo;
    public Cor Cor { get; init; } = cor;
}
