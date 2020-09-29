using System;

namespace CursoSolid_ModeloAnemico1
{
    public class Item
    {
        public Item(int itemId, int pedidoId, string itemNome, decimal itemPreco)
        {
            if (pedidoId <= 0)
            {
                throw new ArgumentException("O código do Pedido deve ser informado com valor " +
                 "maior que zero");
            }

            if (itemId <= 0)
            {
                throw new ArgumentException("O código do Item deve ser informado com valor " +
                "maior que zero");
            }

            this.PedidoId = pedidoId;
            this.ItemId = itemId;
            this.ItemNome = itemNome;
            this.ItemPreco = itemPreco;
        }

        public int ItemId { get; private set; }
        public int PedidoId { get; private set; }

        private string _itemNome;
        public string ItemNome 
        {
            get => this._itemNome;
            private set
            {
                this._itemNome = (value.Length > 100 ) ?
                     throw new ArgumentOutOfRangeException(nameof(ItemNome),
                     "O nome do item não pode exceder 100 caracteres") : value;
            }
        }

        private decimal _itemPreco;
        public decimal ItemPreco 
        {
            get => this._itemPreco;
            private set
            {
                this._itemPreco = (value <= 0) ?
                  throw new ArgumentOutOfRangeException(nameof(ItemPreco),
                  "O preço deve ser maior que zero") : value;
            }
        }        
    }
}
