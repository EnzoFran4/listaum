using System;
 public class program
{


    static void Main(string[] args)
    {
        List<Aluno> alunos = new List<Aluno>();
        

        while (true)
        {
            Console.WriteLine("Deseja cadastrar um aluno?");
            Console.WriteLine("0 - Sim");
            Console.WriteLine("1 - Não");
            Console.WriteLine("2 - Sair");
            int resposta = Convert.ToInt32(Console.ReadLine());

            if (resposta == 0)
            {
                Console.WriteLine("Informe o nome do aluno:");
                Aluno aluno1 = new Aluno();
                aluno1.Nome = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Informe a matricula do aluno:");
                aluno1.Matricula = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Informe o cpf do aluno:");
                aluno1.Cpf = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Informe a data de nascimento do aluno:");
                aluno1.DataNascimento = DateOnly.Parse(Console.ReadLine());

               

                Console.WriteLine("Voce deseja parar?");
                Console.WriteLine("1 - Sim");
                Console.WriteLine("2 - Não");
                int respostaoutra = Convert.ToInt32(Console.ReadLine());
                
                if(respostaoutra == 1)
                {
                    foreach (Aluno aluno in alunos)
                    {
                        Console.WriteLine(aluno1.Nome + " " + aluno1.Matricula + " " + aluno1.Cpf + " " + aluno1.DataNascimento);
                    }
                }

                if (respostaoutra == 2)
                {
                   

                }

            }
            if(resposta == 1)
            {
                Console.WriteLine("Ok");

            }
            else if(resposta ==2)
            {
                break;
            }
            
        }
        





    }
}

/*while (true);
Console.WriteLine("Deseja cadastrar um aluno?");
Console.WriteLine("0 - Sim");
Console.WriteLine("1 - Não");
int resposta = Convert.ToInt32(Console.ReadLine());

if(resposta == 0)
{
    Console.WriteLine("Informe o nome do aluno:");
    Aluno aluno1 = new Aluno();
    aluno1.Nome = Convert.ToString(Console.ReadLine());
    Console.WriteLine("Informe a matricula do aluno:");
    aluno1.Matricula = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Informe o cpf do aluno:");
    aluno1.Cpf = Convert.ToString(Console.ReadLine());
    Console.WriteLine("Informe a data de nascimento do aluno:");
    aluno1.DataNascimento = Convert.ToDateTime(Console.ReadLine());
}

Aluno aluno1 = new Aluno();
aluno1.Nome = "Enzo";
aluno1.Cpf = "00693058200";

Aluno aluno2 = new Aluno(11, "Enzo", "00693058200", new DateOnly(1985, 07, 22));

List<Aluno> alunos = new List<Aluno>();
alunos.Add(aluno1);
alunos.Add(aluno2);

foreach (Aluno aluno in alunos)
{
    Console.WriteLine("O nome é " + aluno.Nome + "" + aluno.Cpf);
}*/






