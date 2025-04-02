using System.Collections.Immutable;
using System.Dynamic;

namespace Xadrez.Pecas;

public static class PecaFactory
{
    static readonly ImmutableList<Peca> Pecas;
    
    static PecaFactory()
    {
        var pecas = new List<Peca>();

        pecas.AddRange(
        [
            new(TipoPeca.Rei,Cor.Branca),
            new(TipoPeca.Dama,Cor.Branca),
            new(TipoPeca.Bispo,Cor.Branca),
            new(TipoPeca.Cavalo,Cor.Branca),
            new(TipoPeca.Torre,Cor.Branca),
            new(TipoPeca.Peao,Cor.Branca),
            new(TipoPeca.Rei, Cor.Preta),
            new(TipoPeca.Dama, Cor.Preta),
            new(TipoPeca.Bispo,Cor.Preta),
            new(TipoPeca.Cavalo,Cor.Preta),
            new(TipoPeca.Torre,Cor.Preta),
            new(TipoPeca.Peao,Cor.Preta),
        ]);

        Pecas = pecas.ToImmutableList();
    }

    public static Peca Get(TipoPeca tipo, Cor cor)
    {
        return Pecas.First(p => p.Tipo == tipo && p.Cor == cor);
    }

}
