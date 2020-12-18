namespace POO_Interface.Classes
{
    public interface ICarrinho
    {
        void Listar();
        
        void Cadastrar(Produto produto);

        void Alterar(int _codigo, Produto produto);

        void Deletar(Produto produto);

     }
}