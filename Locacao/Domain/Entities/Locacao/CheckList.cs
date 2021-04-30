using Locacao.Domain.Entities;

namespace Locacao
{
    public class CheckList : Entity
    {
        public bool CarroLimpo { get; set; }

        public bool TanqueCheio { get; set; }

        public bool Amassado { get; set; }

        public bool Arranhoes { get; set; }

    }
}