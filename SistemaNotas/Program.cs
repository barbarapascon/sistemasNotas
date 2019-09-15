using System;
using System.IO;

namespace SistemaNotas
{
    class Program
    {

        static void Main(string[] args)
        {
            Menu();
        }
        static void Limpa()
        {
            ///esse metodo foi feito para otimiziar o comando "console.clear".
            Console.Clear();

        }
        static void Desenvolvedores()
        {
            Limpa();
            Console.WriteLine("RA: 081190008 - Nicolas Sonoda: /n" +
                "Cadastro de Alunos, Cadastro de Materias, Lançamento de Notas /n" +
                "Métodos, Análise de Complexidade Ciclomática e Identação /n" +
                "RA: 081190020 - Vinicius Prestes:" +
                "Alteração de Notas, Consulta de Notas, Consulta de Situação /n" +
                "Menu, Carregamento de dados e Revisão ");
            Console.ReadLine();
            Menu();
        }
        static void Menu()
        {
            Limpa();
            Console.WriteLine("Digite a opção desejada: \n" +
                "1 - Cadastrar Aluno \n" +
                "2 - Cadastrar Materias \n" +
                "3 - Lançar Notas \n" +
                "4 - Alteração de Nota \n" +
                "5 - Consulta de Nota \n" +
                "6 - Consulta de situação \n" +
                "7 - Desenvolvedores");
            string resp = Console.ReadLine();

            if (resp == "1")
            {
                CadastraAunos();
            }
            if (resp == "2")
            {
                CadastraMaterias();
            }
            if (resp == "3")
            {
                LancaNotas();
            }
            if (resp == "4")
            {
                AlteraNotas();
            }
            if (resp == "5")
            {
                MostraNotas();
            }
            if (resp == "6")
            {
                consutaDeSituacao();
            }
            if (resp == "7")
            {
                Desenvolvedores();
            }
        }
        public static void CadastraAunos()
        {
            Limpa();

            string resp;
            string[] texto = File.ReadAllLines("alunos.txt");
            int quantidade = texto.Length;
            do
            {
                string dados = "";
                File.AppendAllText("alunos.txt", dados);// escreve embaixo, se nao existe o arquivo, esse metodo cria
                
                int codAluno = texto.Length;

                string[] LinhasAluno = File.ReadAllLines("alunos.txt");
                Console.WriteLine($"digite o nome do aluno de cod{codAluno}:");
                string nomeAluno = Console.ReadLine();

                dados = codAluno.ToString() + "|" + nomeAluno + Environment.NewLine;

                try
                {
                    File.AppendAllText("alunos.txt", dados);// escreve embaixo
                    quantidade++;

                }
                catch
                {
                    Console.WriteLine("ocorreu um erro!");
                }

                Console.WriteLine("deseja cadastrar mais um aluno?s/n");
                resp = Console.ReadLine();
            } while (resp == "s" && quantidade<=40);

            Menu();

        }

        public static void CadastraMaterias()
        {
            Limpa();
            string resp;
            string[] texto = File.ReadAllLines("materias.txt");
            int quantidade = texto.Length;
            do
            {
                string dados = "";
                File.AppendAllText("materias.txt", dados);// escreve embaixo, se nao existe o arquivo, esse metodo cria
                
                int codMateria = texto.Length;

                string[] LinhasAluno = File.ReadAllLines("materias.txt");
                Console.WriteLine($"digite o nome da materia de cod{codMateria}:");
                string nomeMateria = Console.ReadLine();

                Console.WriteLine($"digite a sigla da materia de cod{codMateria}:");
                string siglaMateria = Console.ReadLine();

                dados = codMateria.ToString() + "|" + nomeMateria + "|" + siglaMateria + Environment.NewLine;

                try
                {
                    File.AppendAllText("materias.txt", dados);// escreve embaixo

                    File.AppendAllText($"{codMateria.ToString()}.txt", "");
                    quantidade++;

                }
                catch
                {

                    Console.WriteLine("ocorreu um erro!");
                }

                Console.WriteLine("deseja cadastrar mais um mateias?s/n");
                resp = Console.ReadLine();
            } while (resp == "s"&& quantidade<=5);
            Menu();


        }
        public static void LancaNotas()
        {
            Limpa();
            string resp;
            do
            {

                string[] materias = File.ReadAllLines("materias.txt");
                Console.WriteLine("Lista de Disciplinas:");
                for (int i = 0; i < materias.Length; i++)
                {
                    string[] dadosDisciplina = materias[i].Split('|');
                    Console.WriteLine(dadosDisciplina[0] + '|' + dadosDisciplina[2]);
                }
                Console.WriteLine("Digite o código da Disciplina para lançar as notas:");
                int codMateria = Convert.ToInt32(Console.ReadLine());
                if (codMateria == 0)
                {
                    string dados = "";
                    File.AppendAllText("0.txt", dados);
                    string[] notasMateria0 = File.ReadAllLines("0.txt");
                    string[] alunos = File.ReadAllLines("alunos.txt");

                    for (int i = 0; i < alunos.Length; i++)
                    {
                        string[] dadosAlunos = alunos[i].Split('|');
                        Console.WriteLine("insira nota do aluno: " + dadosAlunos[0] + '|' + dadosAlunos[1]);
                        string nota = Console.ReadLine();
                        if (nota == "" || nota.Length == 0)
                            nota = "-";
                        dados += dadosAlunos[0] + "|" + nota + Environment.NewLine;
                    }
                    try
                    {
                        File.AppendAllText("0.txt", dados);// escreve embaixo
                    }
                    catch
                    {

                        Console.WriteLine("ocorreu um erro!");
                    }

                }

                if (codMateria == 1)
                {
                    string dados = "";
                    File.AppendAllText("1.txt", dados);
                    string[] notasMateria0 = File.ReadAllLines("1.txt");
                    string[] alunos = File.ReadAllLines("alunos.txt");

                    for (int i = 0; i < alunos.Length; i++)
                    {
                        string[] dadosAlunos = alunos[i].Split('|');
                        Console.WriteLine("insira nota do aluno: " + dadosAlunos[0] + '|' + dadosAlunos[1]);
                        string nota = Console.ReadLine();
                        if (nota == "" || nota.Length == 0)
                            nota = "-";
                        dados += dadosAlunos[0] + "|" + nota + Environment.NewLine;
                    }
                    try
                    {
                        File.AppendAllText("1.txt", dados);// escreve embaixo
                    }
                    catch
                    {
                        Console.WriteLine("ocorreu um erro!");
                    }

                }
                if (codMateria == 2)
                {
                    string dados = "";
                    File.AppendAllText("2.txt", dados);
                    string[] notasMateria0 = File.ReadAllLines("2.txt");
                    string[] alunos = File.ReadAllLines("alunos.txt");

                    for (int i = 0; i < alunos.Length; i++)
                    {
                        string[] dadosAlunos = alunos[i].Split('|');
                        Console.WriteLine("insira nota do aluno: " + dadosAlunos[0] + '|' + dadosAlunos[1]);
                        string nota = Console.ReadLine();
                        if (nota == "" || nota.Length == 0)
                            nota = "-";
                        dados += dadosAlunos[0] + "|" + nota + Environment.NewLine;
                    }
                    try
                    {
                        File.AppendAllText("2.txt", dados);// escreve embaixo
                    }
                    catch
                    {
                        Console.WriteLine("ocorreu um erro!");
                    }

                }
                if (codMateria == 3)
                {
                    string dados = "";
                    File.AppendAllText("3.txt", dados);
                    string[] notasMateria0 = File.ReadAllLines("3.txt");
                    string[] alunos = File.ReadAllLines("alunos.txt");

                    for (int i = 0; i < alunos.Length; i++)
                    {
                        string[] dadosAlunos = alunos[i].Split('|');
                        Console.WriteLine("insira nota do aluno: " + dadosAlunos[0] + '|' + dadosAlunos[1]);
                        string nota = Console.ReadLine();
                        if (nota == "" || nota.Length == 0)
                            nota = "-";
                        dados += dadosAlunos[0] + "|" + nota + Environment.NewLine;
                    }
                    try
                    {
                        File.AppendAllText("3.txt", dados);// escreve embaixo
                    }
                    catch
                    {
                        Console.WriteLine("ocorreu um erro!");
                    }

                }
                if (codMateria == 4)
                {
                    string dados = "";
                    File.AppendAllText("4.txt", dados);
                    string[] notasMateria0 = File.ReadAllLines("4.txt");
                    string[] alunos = File.ReadAllLines("alunos.txt");

                    for (int i = 0; i < alunos.Length; i++)
                    {
                        string[] dadosAlunos = alunos[i].Split('|');
                        Console.WriteLine("insira nota do aluno: " + dadosAlunos[0] + '|' + dadosAlunos[1]);
                        string nota = Console.ReadLine();
                        if (nota == "" || nota.Length == 0)
                            nota = "-";
                        dados += dadosAlunos[0] + "|" + nota + Environment.NewLine;
                    }
                    try
                    {
                        File.AppendAllText("4.txt", dados);// escreve embaixo
                    }
                    catch
                    {
                        Console.WriteLine("ocorreu um erro!");
                    }

                }

                Console.WriteLine("deseja lancar mais notas?s/n");
                resp = Console.ReadLine();
            } while (resp == "s");
            Menu();

        }
        public static void AlteraNotas()
        {
            Limpa();

            string[] alunos = File.ReadAllLines("alunos.txt");
            Console.WriteLine("Lista de Alunos:");
            for (int i = 0; i < alunos.Length; i++)
            {
                string[] dadosAlunos = alunos[i].Split('|');
                Console.WriteLine(dadosAlunos[0] + '|' + dadosAlunos[1]);
            }
            Console.WriteLine("Digite o código do aluno para alterar as notas:");
            int codAluno = Convert.ToInt32(Console.ReadLine());

            string[] materias = File.ReadAllLines("materias.txt");
            Console.WriteLine("Lista de Disciplinas:");
            for (int i = 0; i < materias.Length; i++)
            {
                string[] dadosDisciplina = materias[i].Split('|');
                Console.WriteLine(dadosDisciplina[0] + '|' + dadosDisciplina[1]);
            }
            Console.WriteLine("Digite o código da Disciplina para alterar as notas:");
            int codMateria = Convert.ToInt32(Console.ReadLine());

            string[] notas = File.ReadAllLines($"{codMateria}.txt");
            for (int i = 0; i < notas.Length; i++)
            {
                string[] dadosNotas = notas[i].Split('|');
                if (Convert.ToInt32(dadosNotas[0]) == codAluno && dadosNotas[1] != "")
                {
                    Console.WriteLine("digite a novva nota do aluno:");
                    string novaNota = Console.ReadLine();
                    notas[i] = codAluno + "|" + novaNota;
                    File.WriteAllLines($"{codMateria}.txt", notas);
                    //break;
                }
                //else {Console.WriteLine("nao existe nota para alterar.");}
            }
            Menu();

        }
        public static void MostraNotas()
        {
            Limpa();
            Console.WriteLine("escolha a forma de visualização:" +
                "1 - Por Aluno \n" +
                "2 - Por Disciplina \n" +
                "3 - Mapa de Notas");
            int op = Convert.ToInt32(Console.ReadLine());
            if (op == 1)
            {
                Console.WriteLine("digite o codigo do aluno que voce quer vizualizar:");
                int codAluno = Convert.ToInt32(Console.ReadLine());
                string[] alunos = File.ReadAllLines("alunos.txt");
                string NomeMateria = "**";
                string[] materias = File.ReadAllLines("materias.txt");


                for (int i = 0; i < alunos.Length - 1; i++)
                {
                    string[] dadosAlunos = alunos[i].Split('|');
                    if (Convert.ToInt32(dadosAlunos[0]) == codAluno)
                        Console.WriteLine("nome do aluno: " + dadosAlunos[1]);
                }
                int cont = materias.Length - 1;
                do
                {
                    for (int i = 0; i < materias.Length; i++)
                    {
                        string[] dadosDisciplina = materias[i].Split('|');
                        if (Convert.ToInt32(dadosDisciplina[0]) == cont)
                            NomeMateria = dadosDisciplina[1];
                    }
                    //fazer um structure pra armazenar temporariamente o nome das materias.
                    string[] materia = File.ReadAllLines($"{cont}.txt");

                    for (int i = 0; i < materia.Length - 1; i++)
                    {
                        string[] dadosMateria = materia[i].Split('|');
                        if (Convert.ToInt32(dadosMateria[0]) == codAluno)
                            Console.WriteLine(NomeMateria + ": " + dadosMateria[1]);
                        
                    }
                    cont--;
                }
                while (cont >= 0);//verificar
                Console.ReadLine();
            }
            if (op == 2)
            {
                string[] materias = File.ReadAllLines("materias.txt");
                Console.WriteLine("Lista de Disciplinas:");
                for (int i = 0; i < materias.Length; i++)
                {
                    string[] dadosDisciplina = materias[i].Split('|');
                    Console.WriteLine(dadosDisciplina[0] + '|' + dadosDisciplina[2]);
                }
                Console.WriteLine("Digite o código da Disciplina para consulta:");
                int codMateria = Convert.ToInt32(Console.ReadLine());

                string[] notas = File.ReadAllLines($"{codMateria}.txt");
                string[] alunos = File.ReadAllLines("alunos.txt");
                for (int i = 0; i < notas.Length; i++)
                {
                    string[] dadosNotas = notas[i].Split('|');
                    for (int a = 0; a < alunos.Length; a++)
                    {
                        string[] dadosAlunos = alunos[a].Split('|');
                        if (dadosNotas[0] == dadosAlunos[0])
                        {
                            Console.WriteLine("RA:" + dadosAlunos[0] + " - nome Aluno: " + dadosAlunos[1] + " - nota da disciplina: " + dadosNotas[1]);
                            
                        }

                    }
                }
                Console.ReadLine();
            }
            if (op == 3)
            {

            }
            Menu();
        }
        public static void consutaDeSituacao()
        {
            Limpa();
            string[] alunos = File.ReadAllLines("alunos.txt");
            string[] materias = File.ReadAllLines("materias.txt");


            for (int a = 0; a < alunos.Length - 1; a++)
            {
                string[] dadosAlunos = alunos[a].Split('|');
                string status = "aprovado";
                int cont = materias.Length - 1;
                do
                {
                   string[] materia = File.ReadAllLines($"{cont}.txt");
                   
                    for (int i = 0; i < materia.Length - 1; i++)
                    {
                        string[] dadosMateria = materia[i].Split('|');
                        if (Convert.ToInt32(dadosMateria[0]) == a && Convert.ToInt32(dadosMateria[1]) >= 5)
                            status = "aprovado";
                        if (Convert.ToInt32(dadosMateria[0]) == a && Convert.ToInt32(dadosMateria[1]) <= 5)
                        {
                            status = "reprovado";
                            break;
                        }

                    }
                    cont--;
                }
                while (cont >= 0);//verificar
                Console.WriteLine(dadosAlunos[0] + " - " + dadosAlunos[1] + " - " + status);
            }
            Console.ReadLine();

            Menu();
        }
    }
}

