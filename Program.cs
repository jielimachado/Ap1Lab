        do
        {
            Console.Write("Digite o nome da pessoa: ");//Solicita que a pessoa digite seu nome
            string nome = Console.ReadLine(); //Armazena o que usuário digitou na variável

            Console.Write("Digite a idade da pessoa: ");// Solicita que a pessoa digite a idade da pessoa
            int idade = int.Parse(Console.ReadLine());//Armazena o que usuário digitou na variável

            Console.Write("Digite a altura da pessoa (em centimetros): ");// Solicita a altura da pessoa em centimetros
            double altura = double.Parse(Console.ReadLine());//Armazena o que usuário digitou na variável

            Console.Write("Digite o peso da pessoa (em quilogramas): "); // Solicita o peso da pessoa em quilogramas
            double peso = double.Parse(Console.ReadLine());//Armazena o que usuário digitou na variável

            double imc = peso / (altura * altura);//Com os dados das variáveis ele calcula o IMC

            // Exibe o relatório
            Console.WriteLine($"Nome: {nome}");//exibe o nome digitado
            Console.WriteLine($"Idade: {idade} anos");//exibe a idade digitado
            Console.WriteLine($"IMC: {imc:F2}");//exibe o cálculo do IMC

            string faixaEtaria;//roda o controle de fluxo
            if (idade < 12) //se idade for menor que 12 exebirá criança. 
            {
                faixaEtaria = "Criança";
            }
            else if (idade < 18) //se idade entre 12 e 18 exebirá adolescente 
            {
                faixaEtaria = "Adolescente";
            }
            else if (idade < 60)//se idade entre 18 a 60 exebirá adulto
            {
                faixaEtaria = "Adulto";
            }
            else
            {
                faixaEtaria = "Idoso"; //se idade > 60 exebirá idoso
            }

            Console.WriteLine($"Faixa Etária: {faixaEtaria}");

            // Pergunta se deseja gerar um novo relatórioo
            Console.Write("Deseja gerar um novo relatório para outra pessoa? (S/N): ");
            string resposta = Console.ReadLine(); //se resposta S inicia o loop.
            if (resposta.ToUpper() != "S")
            {
                break; // Encerra o programa se a resposta não for 'S'
            }
        } while (true);