// See https://aka.ms/new-console-template for more information
namespace ControleAcesso.Class
{
    class MainClass {

        private static List<Movimento> mov = new();
        public static void Continuar(string msg)
        {
            Console.WriteLine($"\n**** {msg} ****");
            Console.WriteLine("");
            Console.WriteLine("\n**** PRESSIONE QUALQUER TECLA PARA CONTINUAR ****");
            Console.ReadKey();

        }

        public static void Main(string[] args)
        {
            Veiculos veiculos;
            Pessoas pessoas;


            string opcao = "S";
            string sentido;
            ESentido esentido;
            ETipoMovimento etipoMovimento = ETipoMovimento.ENTRADAFUNCIONARIO;
            EStatusMovimento statusMovimento = EStatusMovimento.ABERTO;
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
            string msg;

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

                        Console.WriteLine("Digite sentido (1 - Entrada/2 - Saida):");
                        sentido = Console.ReadLine();

                        Console.WriteLine("Digite a data (Formato DD/MM/AAAA - Obrigatorio):");
                        data = Console.ReadLine();

                        Console.WriteLine("Digite uma observacao:");
                        obs = Console.ReadLine();

                        Console.WriteLine("Digite a Placa do veiculo (7 digitos -  Obrigatorio):");
                        placa = Console.ReadLine();

                        Console.WriteLine("Digite a Modelo do veiculo:");
                        modelo = Console.ReadLine();

                        Console.WriteLine("Digite o Documento da pessoa (11 digitos -  Obrigatorio):");
                        doc = Console.ReadLine();

                        Console.WriteLine("Digite o Nome da pessoa (Obrigatorio)");
                        nome = Console.ReadLine();

                        Validacao validacao = new();

                        msg = validacao.ValidaDadosMovimento(sentido, data, placa, doc, nome);

                        if(msg == "") 
                        {
                            veiculos = new(placa, modelo);

                            pessoas = new(doc, nome);

                            if(sentido == "1")
                            {
                                esentido = ESentido.ENTRADA;
                            }
                            else
                            {
                                esentido = ESentido.SAIDA;
                            }
                        }
                        else
                        {
                            Continuar(msg);
                            break;

                        }

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

                                Console.WriteLine("Digite o numero da NF (Numerico -  Obrigatorio):");
                                nf = Console.ReadLine();

                                Console.WriteLine("Digite o peso de chegada do caminhao (Numerico -  Obrigatorio):");
                                pesocgd = Console.ReadLine();

                                Console.WriteLine("Digite o peso de saida do caminhao (Numerico -  Obrigatorio):");
                                pesosai = Console.ReadLine();

                                Console.WriteLine("Digite o peso da NF (Numerico -  Obrigatorio):");
                                pesonf = Console.ReadLine();

                                msg = validacao.ValidaDadosPesoNf(nf, pesocgd, pesosai, pesonf);

                                if(msg == "")
                                { 

                                    Console.WriteLine("Escolha uma opção");
                                    Console.WriteLine("R - Recebimento");
                                    Console.WriteLine("E - Expedição");
                                    opcao = Console.ReadKey().KeyChar.ToString().ToUpper();

                                    switch (opcao)
                                    {
                                        case "E":
                                            Expedicao exp = new(nf, double.Parse(pesosai), double.Parse(pesocgd), double.Parse(pesonf), esentido, etipoMovimento, statusMovimento, data, veiculos, pessoas, obs);
                                            mov.Add(exp);
                                            Continuar("MOVIMENTAÇÃO DE EXPEDIÇÂO REGISTRADA");
                                            break;

                                        case "R":
                                            Recebimento rec = new(nf, double.Parse(pesocgd), double.Parse(pesosai), double.Parse(pesonf), esentido, etipoMovimento, statusMovimento, data, veiculos, pessoas, obs);
                                            mov.Add(rec);
                                            Continuar("MOVIMENTAÇÃO DE RECEBIMENTO REGISTRADA");
                                            break;

                                        default:
                                            Continuar("NÃO FOI DIGITADO UMA OPÇÃO VALIDA, NENHUMA AÇÃO FOI EFETUADA");
                                            break;
                                    }
                                }
                                else
                                {
                                    Continuar(msg);
                                }

                                break;

                            case "2":

                                Console.WriteLine("**** REGISTRO DE MOVIMENTAÇÃO SAIDA DE CARRO DA EMPRESA ****\n");

                                Console.WriteLine("Digite o KM de saida (Numerico -  Obrigatorio):");
                                kms = Console.ReadLine();

                                Console.WriteLine("Digite o nivel de combustivel (Numerico -  Obrigatorio):");
                                nivcmbs = Console.ReadLine();

                                Console.WriteLine("Digite a hora da saida (Formato HH:MM -  Obrigatorio):");
                                hrs = Console.ReadLine();

                                Console.WriteLine("Digite destino (Obrigatorio):");
                                des = Console.ReadLine();

                                msg = validacao.ValidaDadosSaidaCarroEmpresa(kms, nivcmbs, hrs, des);

                                if(msg == "")
                                {
                                    SaidaCarroEmpresa sec = new(Int32.Parse(kms), Int32.Parse(nivcmbs), hrs, des, esentido, etipoMovimento, statusMovimento, data, veiculos, pessoas, obs);
                                    mov.Add(sec);
                                    Continuar("MOVIMENTAÇÃO DE SAIDA REGISTRADA");                                 

                                }
                                else
                                {
                                    Continuar(msg);
                                }
                                break;


                            case "3":

                                EntradaFuncionarios ent = new(ESentido.ENTRADA, etipoMovimento, statusMovimento, data, veiculos, pessoas, obs);
                                mov.Add(ent);
                                Continuar("MOVIMENTAÇÃO DE ENTRADA DE FUNCIONARIO REGISTRADA");
                                break;
                            case "S":

                                break;
                            default:
                                Continuar("NÃO FOI DIGITADO UMA OPÇÃO VALIDA, NENHUMA AÇÃO FOI EFETUADA");
                                break;
                        }

                        break;
                    case "2":
                        Console.WriteLine("\n**** EXIBINDO MOVIMENTAÇÕES ****\n");

                        foreach (var ent in mov)
                        {
                            ent.Mostrardados();
                        }

                        Console.WriteLine("\n**** PRESSIONE QUALQUER TECLA PARA CONTINUAR ****");
                        Console.ReadKey();
                        break;
                    case "S":

                        op = false;
                        break;

                    default:
                        Continuar("NÃO FOI DIGITADO UMA OPÇÃO VALIDA, NENHUMA AÇÃO FOI EFETUADA");
                        break;

                }                

            }while (op);           
           
        }
    }

}
