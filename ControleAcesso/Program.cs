// See https://aka.ms/new-console-template for more information
namespace ControleAcesso.Class
{
    class MainClass {

        private static List<Movimento> mov = new List<Movimento>();
        public static void Main(string[] args)
        {
            string opcao = "S";
            string sentido;
            string data;
            string obs;
            string placa;
            string modelo;
            string doc;
            string nome;
            bool op = true;

            do 
            {
                Console.Clear();
                Console.WriteLine("1 - Lançar um novo movimento");
                Console.WriteLine("2 - Listar Movimentos");
                Console.WriteLine("S - Sair");
                opcao = Console.ReadKey().KeyChar.ToString().ToUpper();

                switch (opcao)
                {
                    case "1":                        

                        Console.WriteLine("Digite sentido (1 - Entrada/2 - Saida:");
                        sentido = Console.ReadLine();

                        if (String.IsNullOrEmpty(sentido))
                        {
                            throw new Exception("Sentido sem valor atribuido");
                        }

                        Console.WriteLine("Digite a data:");
                        data = Console.ReadLine();

                        if (String.IsNullOrEmpty(data))
                        {
                            throw new Exception("Data sem valor atribuido");
                        }
                        Console.WriteLine("Digite uma observacao:");
                        obs = Console.ReadLine();

                        Console.WriteLine("Digite a Placa do veiculo:");
                        placa = Console.ReadLine();

                        if (String.IsNullOrEmpty(placa))
                        {
                            throw new Exception("Placa sem valor atribuido");
                        }


                        Console.WriteLine("Digite a Modelo do veiculo:");
                        modelo = Console.ReadLine();

                        if (String.IsNullOrEmpty(modelo))
                        {
                            throw new Exception("Modelo sem valor atribuido");
                        }                        

                        Console.WriteLine("Digite o Documento da pessoa:");
                        doc = Console.ReadLine();

                        if (String.IsNullOrEmpty(doc))
                        {
                            throw new Exception("Documento sem valor atribuido");
                        }


                        Console.WriteLine("Digite o Nome da pessoa");
                        nome = Console.ReadLine();

                        if (String.IsNullOrEmpty(nome))
                        {
                            throw new Exception("Nome sem valor atribuido");
                        }

                        Veiculos veiculos = new Veiculos(placa,modelo);

                        Pessoas pessoas = new Pessoas((int)Int64.Parse(doc), nome);

                        Console.WriteLine("Escolha uma opção");
                        Console.WriteLine("1 - Recebimento");
                        Console.WriteLine("2 - Expedição");
                        Console.WriteLine("3 - Entrada Funcionário");
                        Console.WriteLine("4 - Saida Carro Empresa");
                        Console.WriteLine("");
                        Console.WriteLine("S - Sair");
                        opcao = Console.ReadKey().KeyChar.ToString().ToUpper();

                        switch (opcao)
                        {
                            case "1":

                                break;
                            case "2":

                                break;
                            case "3":

                                break;
                            case "4":
                                EntradaFunc ent = new EntradaFunc(Int32.Parse(sentido), data, veiculos, pessoas, obs);
                                mov.Add(ent);

                                break;
                            case "S":

                                break;
                        }

                        break;
                    case "2":
                        break;
                    case "S":
                        op = false;
                        break;
                        
                }                

            }while (op);
            
            
            
            
            
            
            /*Recebimento func = new Recebimento("motorista");

            func.ConferePesagemRec();

            func.Mostrardados();*/
        }
    }

}
