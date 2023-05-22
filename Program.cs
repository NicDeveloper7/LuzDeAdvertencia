    //By NicholasDev

    //Variáveis de resposta
    string sensortemperature, sensorpression, sensorrotation;

    //Configuração da cor do console
    Console.ForegroundColor = ConsoleColor.DarkMagenta;

    //Mensagem de boas-vindas
    Console.WriteLine("");
    Console.WriteLine("---- Bem-Vindo ao Simulador de Luz de Advertência ----");
    Console.ResetColor();

    //Solicitação do estado dos sensores
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine();
    Console.WriteLine("Digite o estado de cada um dos sensores");
    Console.WriteLine();

    //Indicação das opções
    Console.WriteLine("[D]esativado ou [A]tivado");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("Sensor de temperatura...:");
    sensortemperature = Console.ReadLine()!.ToUpper();

    //Verificação do estado do sensor de temperatura
        if (sensortemperature == "A")
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Sensor de pressão.......: ");
            sensorpression = Console.ReadLine()!.ToUpper();

            //Verificação do estado do sensor de pressão
            if (sensorpression == "A")
            {
                Console.WriteLine("Sensor de rotação.......: ");
                sensorrotation = Console.ReadLine()!.ToUpper();
                Console.Clear();
                Console.ResetColor();


                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;

                //Mostra os estados dos sensores e a ativação da luz de advertência
                Console.WriteLine("---- Simulador de Luz de Advertência ----");
                Console.WriteLine();

                Console.WriteLine("[A]tivado, [D]esativado");

                Console.WriteLine($"Sensor de temeperatura.....: {sensortemperature}");
                Console.WriteLine($"Sensor de pressão..........: {sensorpression}");
                Console.WriteLine($"Sensor de rotação..........: {sensorrotation}");

                Console.WriteLine();

                Console.WriteLine("A luz de advertência estará ATIVADA");

                Console.ResetColor();

            }

            //Verificação do estado do sensor de pressão quando está desativado
            if (sensorpression == "D")
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Sensor de rotação.......: ");
                sensorrotation = Console.ReadLine()!.ToUpper();

                //Verificação do estado do sensor de rotação quando está desativado
                if (sensorrotation == "D")
                {
                    Console.Clear();
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                    //Mostra os estados dos sensores e a ativação da luz de advertência
                    Console.WriteLine("---- Simulador de Luz de Advertência ----");
                    Console.WriteLine();

                    Console.WriteLine("[A]tivado, [D]esativado");
                    Console.WriteLine();

                    Console.WriteLine($"Sensor de temeperatura.....: {sensortemperature}");
                    Console.WriteLine($"Sensor de pressão..........: {sensorpression}");
                    Console.WriteLine($"Sensor de rotação..........: {sensorrotation}");

                    Console.WriteLine();
                    Console.WriteLine("A luz de advertência estará ATIVADA");

                    Console.ResetColor();
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;

                    //Mostra os estados dos sensores e o desligamento da luz de advertência
                    Console.WriteLine("---- Simulador de Luz de Advertência ----");
                    Console.WriteLine();

                    Console.WriteLine("[A]tivado, [D]esativado");
                    Console.WriteLine();

                    Console.WriteLine($"Sensor de temeperatura.....: {sensortemperature}");
                    Console.WriteLine($"Sensor de pressão..........: {sensorpression}");
                    Console.WriteLine($"Sensor de rotação..........: {sensorrotation}");

                    Console.WriteLine();
                    Console.WriteLine("A luz de advertência estará DESATIVADA");

                    Console.ResetColor();
                }

            }
        }

//Verificação do estado do sensor de temperatura quando está desativado
if (sensortemperature == "D")
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Sensor de temperatura desativado ou você escolheu uma opção inválida");
}
