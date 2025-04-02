﻿

namespace Xadrez.Models.Pecas;

public class Torre : PecaBase
{
    public Torre(Cor cor) : base(TipoPeca.Torre, cor)
    {
    }

    public override IEnumerable<Posicao> MovimentosPossiveisAPartirDe(Posicao posicaoInicial)
    {
        throw new NotImplementedException();
    }
}
