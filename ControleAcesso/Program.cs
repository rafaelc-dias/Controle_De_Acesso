// See https://aka.ms/new-console-template for more information
namespace ControleAcesso.Class
{
    class MainClass {

        private static List<Movimento> mov = new();
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
            string kms;
            string nivcmbs;
            string hrs;
            string des;
            string nf;
            string pesocgd;
            string pesosai;
            string pesonf;
            bool op = true;

            do 
            {
                Console.Clear();
                Console.WriteLine("**** Lançamentos do Controle de Acesso ****\n");
                Console.WriteLine("**** Selecione uma opção para iniciar ****\n");
                Console.WriteLine("1 - Lançar um novo movimento");
                Console.WriteLine("2 - Listar Movimentos");
                Console.WriteLine("S - Sair");
                opcao = Console.ReadKey().KeyChar.ToString().ToUpper();

                switch (opcao)
                {
                    case "1":

                        Console.WriteLine("\n**** Lançamento dados basicos do movimento ****\n");

                        Console.WriteLine("Digite a data:");
                        data = Console.ReadLine();

                        Console.WriteLine("Digite a data:");
                        data = Console.ReadLine();

                        Console.WriteLine("Digite uma observacao:");
                        obs = Console.ReadLine();

                        Console.WriteLine("Digite a Placa do veiculo:");
                        placa = Console.ReadLine();

                        Console.WriteLine("Digite a Modelo do veiculo:");
                        modelo = Console.ReadLine();

                        Console.WriteLine("Digite o Documento da pessoa:");
                        doc = Console.ReadLine();

                        Console.WriteLine("Digite o Nome da pessoa");
                        nome = Console.ReadLine();

                        Validacao validacao = new();

                        validacao.ValidaDadosMov(sentido,data,placa,doc,nome)

                        
                        Veiculos veiculos = new(placa,modelo);

                        Pessoas pessoas = new(doc, nome);

                        Console.WriteLine("\nEscolha uma opção");
                        Console.WriteLine("1 - Recebimento / Expedição");
                        Console.WriteLine("2 - Saida Carro Empresa");
                        Console.WriteLine("3 - Entrada Funcionário");
                        Console.WriteLine("");
                        Console.WriteLine("S - Sair");
                        opcao = Console.ReadKey().KeyChar.ToString().ToUpper();

                        switch (opcao)
                        {
                            case "1":
                                
                                Console.WriteLine("\n**** REGISTRO DE MOVIMENTAÇÃO DE RECEBIMENTO / EXPEDIÇÂO ****\n");

                                Console.WriteLine("Digite o numero da NF:");
                                nf = Console.ReadLine();

                                if (String.IsNullOrEmpty(nf))
                                {
                                    throw new Exception("KM de saida sem valor atribuido");
                                }


                                Console.WriteLine("Digite o peso de chegada do caminhao");
                                pesocgd = Console.ReadLine();

                                if (String.IsNullOrEmpty(pesocgd))
                                {
                                    throw new Exception("Nivel de combustivel sem valor atribuido");
                                }


                                Console.WriteLine("Digite o peso de saida do caminha:");
                                pesosai = Console.ReadLine();

                                if (String.IsNullOrEmpty(pesosai))
                                {
                                    throw new Exception("Hora sem valor atribuido");
                                }


                                Console.WriteLine("Digite o peda da NF:");
                                pesonf = Console.ReadLine();

                                if (String.IsNullOrEmpty(pesonf))
                                {
                                    throw new Exception("Destino sem valor atribuido");
                                }

                                Console.WriteLine("Escolha uma opção");
                                Console.WriteLine("R - Recebimento");
                                Console.WriteLine("E - Expedição");
                                opcao = Console.ReadKey().KeyChar.ToString().ToUpper();

                                switch (opcao)
                                {
                                    case "E":
                                        
                                        Expedicao exp = new(nf, double.Parse(pesosai), double.Parse(pesocgd), double.Parse(pesonf), Int32.Parse(sentido), data, veiculos, pessoas, obs);
                                        mov.Add(exp);
                                        Console.WriteLine("\n**** MOVIMENTAÇÃO DE EXPEDIÇÂO REGISTRADO****");
                                        Console.ReadKey();
                                        break;

                                    case "R":
                                        Recebimento rec = new(nf, double.Parse(pesocgd), double.Parse(pesosai), double.Parse(pesonf), Int32.Parse(sentido), data, veiculos, pessoas, obs);
                                        mov.Add(rec);
                                        Console.WriteLine("\n**** MOVIMENTAÇÃO DE RECEBIMENTO REGISTRADO****");
                                        Console.ReadKey();
                                        break;

                                    default:
                                        Console.WriteLine("\n**** NÃO FOI DIGITADO UMA OPÇÃO VALIDA, NENHUMA AÇÃO FOI EFETUADA****");
                                        Console.ReadKey();
                                        break;
                                }                               

                                break;

                            case "2":

                                Console.WriteLine("**** REGISTRO DE MOVIMENTAÇÃO SAIDA DE CARRO DA EMPRESA ****\n");

                                Console.WriteLine("Digite o KM de saida:");
                                kms = Console.ReadLine();

                                if (String.IsNullOrEmpty(kms))
                                {
                                    throw new Exception("KM de saida sem valor atribuido");
                                }


                                Console.WriteLine("Digite o nivel de combustivel:");
                                nivcmbs = Console.ReadLine();

                                if (String.IsNullOrEmpty(nivcmbs))
                                {
                                    throw new Exception("Nivel de combustivel sem valor atribuido");
                                }


                                Console.WriteLine("Digite a hora da saida:");
                                hrs = Console.ReadLine();

                                if (String.IsNullOrEmpty(hrs))
                                {
                                    throw new Exception("Hora sem valor atribuido");
                                }


                                Console.WriteLine("Digite destino:");
                                des = Console.ReadLine();

                                if (String.IsNullOrEmpty(des))
                                {
                                    throw new Exception("Destino sem valor atribuido");
                                }

                                SaidaCarroEmp sec = new(Int32.Parse(kms), Int32.Parse(nivcmbs), hrs, des, Int32.Parse(sentido), data, veiculos, pessoas, obs);
                                mov.Add(sec);
                                Console.WriteLine("\n**** MOVIMENTAÇÃO DE SAIDA REGISTRADO****");
                                Console.ReadKey();

                                break;

                            case "3":

                                Console.WriteLine("\n**** REGISTRO DE MOVIMENTAÇÃO ENTRADA DE FUNCIONARIO ****\n");

                                EntradaFunc ent = new(Int32.Parse(sentido), data, veiculos, pessoas, obs);
                                Console.WriteLine(ent.Sent.GetValue(0));
                                mov.Add(ent);
                                Console.WriteLine("\n**** MOVIMENTAÇÃO DE ENTRADA REGISTRADO****");
                                Console.ReadKey();                                

                                break;
                            case "S":

                                break;
                            default:
                                Console.WriteLine("\n**** NÃO FOI DIGITADO UMA OPÇÃO VALIDA, NENHUMA AÇÃO FOI EFETUADA****");
                                Console.ReadKey();
                                break;
                        }

                        break;
                    case "2":
                        Console.WriteLine("\n**** EXIBINDO MOVIMENTAÇÕES ****\n");

                        foreach (var ent in mov)
                        {
                            ent.Mostrardados();
                        }
                       
                        Console.ReadKey();
                        break;
                    case "S":

                        op = false;
                        break;

                    default:
                        Console.WriteLine("\n**** NÃO FOI DIGITADO UMA OPÇÃO VALIDA, NENHUMA AÇÃO FOI EFETUADA****");
                        Console.ReadKey();
                        break;

                }                

            }while (op);           
           
        }
    }

}
