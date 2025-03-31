
namespace Xadrez.Models.Pecas;

public class Bispo : PecaBase
{
    public Bispo(Cor cor) : base(TipoPeca.Bispo, cor)
    {
    }

    public override IEnumerable<Posicao> MovimentosPossiveis => throw new NotImplementedException();
}
