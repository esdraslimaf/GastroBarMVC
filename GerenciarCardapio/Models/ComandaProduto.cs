﻿namespace GerenciarCardapio.Models
{
    public class ComandaProduto
    {
        public int Id { get; set; }
        public int ComandaId { get; set; }
        public Comanda? Comanda { get; set; }
        public int ProdutoId { get; set; }
        public Produto? Produto { get; set; }
    }
}
