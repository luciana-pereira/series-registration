using System;
using series.registration;

namespace series_registration
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
            string userOption = GetUserOption();

            while (userOption.ToUpper() != "X")
            {
                switch (userOption)
                {
                    case "1":
                        ListSeries();
                        break;
                    case "2":
                        ListSeries();
                        break;
                    case "3":
                        ListSeries();
                        break;
                    case "4":
                        ListSeries();
                        break;
                    case "5":
                        ListSeries();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();

                }

                userOption = GetUserOption();
            }

            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();
        }

        private static void ListSeries()
        {
            Console.WriteLine("Listar séries");

            var list = repositorio.List();

            if (list.Count == 0)
            {
                Console.WriteLine("Não há, nenhuma série cadastrada, \ndigite a opção 2 para cadastrar nova série.");
                return;
            }

            foreach (var serie in list)
            {
                var excluded = serie.returnDeleted();
                Console.WriteLine(
                    "#ID {0}: - {1} {2}", 
                    serie.returnId(), 
                    serie.returnTitle(), 
                    (excluded ? "*Excluído*" : "")
                );

            }
        }

        private static void InsertSeries()
        {
	        Console.WriteLine("Inserir nova série");

	       foreach (int i in Enum.GetValues(typeof(Genero)))
           {
               Console.WriteLine("{0} {1}", i, Enum.GetName(typeof(Genero), i));
           }

	        Console.Write("Digite o gênero entre as opções acima: ");
	        int entradaGenero = int.Parse(Console.ReadLine());

	        Console.Write("Digite o Título da Série: ");
	        string entradaTitulo = Console.ReadLine();

	        Console.Write("Digite o Ano de Início da Série: ");
	        int entradaAno = int.Parse(Console.ReadLine());

	        Console.Write("Digite a Descrição da Série: ");
	        string entradaDescricao = Console.ReadLine();

	        Serie newSeries = new Serie(id: repositorio.NextId(),
								genero: (Genero)entradaGenero,
								titulo: entradaTitulo,
								ano: entradaAno,
								descricao: entradaDescricao);

	        repositorio.Insert(newSeries);
        }

        private static void DeleteSeries()
        {
	        Console.Write("Digite o id da série: ");
	        int indexSeries = int.Parse(Console.ReadLine());
	        Console.WriteLine("Deseja mesmo excluir está série: ");
	        var serie = repositorio.ReturnById(indexSeries);
	        if (serie != null)
	        {
		        Console.WriteLine(serie);
		        Console.WriteLine("Digite sim para confirmar: ");
		        string resposta = Console.ReadLine();
		        if (resposta == "sim")
		        {
			        repositorio.Delet(indexSeries);
			        Console.WriteLine("Série excluída com sucesso!");
		        }
		        else
		        {
			        Console.WriteLine("Série não foi excluida!");
		        }
	        }
	        else
            {
		        throw new ArgumentOutOfRangeException($"Id {indexSeries} não encontrado");
            }
	
        }

        private static void ViewSerie()
        {
	        Console.Write("Digite o id da série: ");
	        int indexSeries = int.Parse(Console.ReadLine());
	
	        var serie = repositorio.ReturnById(indexSeries);
	        if (serie != null)
		        Console.WriteLine(serie);
	        else
		        throw new ArgumentOutOfRangeException($"Id {indexSeries} não encontrado");
        }

        private static void updateSeries()
        {
	        Console.Write("Digite o id da série: ");
	        int indexSeries = int.Parse(Console.ReadLine());

	        Console.Write("Digite o gênero entre as opções acima: ");
	        int entradaGenero = int.Parse(Console.ReadLine());
	        var ancient_series = repositorio.ReturnById(indexSeries);
	        if (ancient_series != null)
	        {
		        Console.Write("Digite o Título da Série: ");
		        string entryTitle = Console.ReadLine();

		        Console.Write("Digite o Ano de Início da Série: ");
		        int yearInput  = int.Parse(Console.ReadLine());

		        Console.Write("Digite a Descrição da Série: ");
		        string inputDescription = Console.ReadLine();

		        Serie updateSeries = new Serie(id: indexSeries,
									genero: (Genero)entradaGenero,
									titulo: entryTitle,
									ano: yearInput,
									descricao: inputDescription);

		        repositorio.Update(indexSeries, updateSeries);

	        }
	    else
		throw new ArgumentOutOfRangeException($"Id {indexSeries} não encontrado");
        }

        private static string GetUserOption()
        {
            Console.WriteLine();
            Console.WriteLine("Séries a seu dispor!!!");
            Console.WriteLine("Informe a opção desejada");

            Console.WriteLine("1 - Listar séries");
            Console.WriteLine("2 - Inserir nova série");
            Console.WriteLine("3 - Atualizar série");
            Console.WriteLine("4 - Excluir série");
            Console.WriteLine("5 - Visualizar série");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string userOption = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return userOption;
        }
    }
}
