using ConsoleApp23;

class program
{
    static void Main()
    {
        List<Produto> produto = new List<Produto>();


        double total = 0;

        Produto CocaCola = new Produto();
        CocaCola. NomedoProduto = "1 - Coca-Cola";
        CocaCola.Preco = 8.00;
        produto.Add(CocaCola);

        Produto Pepsi = new Produto();
        Pepsi.NomedoProduto = "2 - Pepsi";
        Pepsi.Preco = 5.00;
        produto.Add(Pepsi);

        Produto Guaraná = new Produto();
        Guaraná.NomedoProduto = "3 - Guaraná";
        Guaraná.Preco = 7.00;
        produto.Add(Guaraná);

        Produto XBurger = new Produto();
        XBurger.NomedoProduto = "4 - X-Burger";
        XBurger.Preco = 15.00;
        produto.Add(XBurger);

        Produto XBacon = new Produto();
        XBacon.NomedoProduto = " 5 - X-Bacon";
        XBacon.Preco = 16.00;
        produto.Add(XBacon);

        Produto XTudo = new Produto();
        XTudo.NomedoProduto = "6 - X-Tudo";
        XTudo.Preco = 18.00;
        produto.Add(XTudo);

        Produto BatataP = new Produto();
        BatataP.NomedoProduto = "7 - Batata Pequena";
        BatataP.Preco = 8.00;
        produto.Add(BatataP);

        Produto BatataM = new Produto();
        BatataM.NomedoProduto = "8 - Batata Medía";
        BatataM.Preco = 11.00;
        produto.Add(BatataM);

        Produto BatataG = new Produto();
        BatataG.NomedoProduto = "9 - Batata Grande";
        BatataG.Preco = 15.00;
        produto.Add(BatataG);



        Console.WriteLine("CARDAPIO\n---------------------------------------------------------------");
        foreach (Produto Item in produto)
        {
            Console.WriteLine($"{Item.NomedoProduto.PadRight(30)} = R${Item.Preco}");
        }
        Console.WriteLine("------------------------------------------------------------------------");

        Console.WriteLine("Diga quantos itens tera seu pedido");
        int quandidadedePedidos = int.Parse(Console.ReadLine());
        int i = 0;

        while (i < quandidadedePedidos)
        {
            i++;
            Console.WriteLine("Diga o numero do seu pedido ");
            int pedidoFeito = int.Parse(Console.ReadLine());
      

            }
        }



    }
}


