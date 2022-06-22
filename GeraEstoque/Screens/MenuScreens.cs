namespace GeraEstoque.Screens;

public static class MenuScreens
{
  public static void Iniciar()
  {
    Console.Clear();

    Console.WriteLine("Seja bem vindo ao GeraEstoque 1.0");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("1  Cadastrar produto");
    Console.WriteLine("2  Consultar produto");
    Console.WriteLine("3  Modificar produto");
    Console.WriteLine("4  Excluir produto");
    Console.WriteLine("0  Sair");

    Console.WriteLine(string.Empty);

    Console.Write("Digite a opção: ");

    switch (Console.ReadLine())
    {
      case "0": Console.Clear(); Environment.Exit(0); break;

      case "1": CriarProdutoScreen.Iniciar(); Iniciar(); break;

      case "2": Iniciar(); break;

      case "3": Iniciar(); break;

      case "4": Iniciar(); break;

      default: Environment.Exit(0); break;
    }
  }


}