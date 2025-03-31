

namespace Xadrez.Models.Pecas;

public class Rei : PecaBase
{
    
    public Rei(Cor cor) :base(TipoPeca.Rei, cor)
    {
        if (cor == Cor.Branca)
            PosicaoAtual = new Posicao("e1");
        else
            PosicaoAtual = new Posicao("e8");
    }

    public override IEnumerable<Posicao> MovimentosPossiveis
    {
        get
        {
            var movimentosPossiveis = new List<Posicao>();
            var posicaoHandler = new PosicaoHandler(PosicaoAtual);

            return [];

        }
    }

    public override void Mover(Posicao posicaoDesejada)
    {
        base.Mover(posicaoDesejada);
    }

}
