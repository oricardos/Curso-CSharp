using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulaProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Produtos(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
                "Values('Coca-cola', 'Refrigerante sabor cola', 5.00, 'coca-cola.jpg', 100, GETDATE(), (Select CategoriaId from Categorias where Nome = 'Bebidas'))");

            mb.Sql("Insert into Produtos(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
                "Values('X-Burguer', 'Hambúrguer com queijo e bacon', 15.00, 'x-burguer.jpg', 50, GETDATE(), (Select CategoriaId from Categorias where Nome = 'Lanches'))");

            mb.Sql("Insert into Produtos(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
                "Values('Pudim', 'Sobremesa de leite condensado', 7.00, 'pudim.jpg', 30, GETDATE(), (Select CategoriaId from Categorias where Nome = 'Sobremesas'))");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Produtos");
        }
    }
}
