using System;

public class Program {
    static void Main(string[] args) {
        //TIPOS DE VARIAVEIS
        //TODO Fazer programa que receba um valor e retorne o melhor tipo de variavel a ser usado.     
        Console.WriteLine("Lembre-se que o programa se baseia no número exato que você digitar, caso haja alteração no numero dentro do seu codigo o melhor a se usar é int por padrão.");
        bool continuar = true;
        while (continuar) {
            Console.WriteLine("Digite o número que você deseja saber o melhor tipo de variavel a ser armazenado:");
            string input = Console.ReadLine();
            if (input == "sair") { 
                continuar = false;
            }
            bool sucessoConversaoDouble = double.TryParse(input, out double valorDigitadoDouble);
            bool sucessoConversaoDecimal = decimal.TryParse(input, out decimal valorDigitadoDecimal);
            bool sucessoConversaoLong = long.TryParse(input, out long valorDigitadoLong);


            if (sucessoConversaoLong) {
                if (valorDigitadoLong >= -128 && valorDigitadoLong <= 127) {
                    Console.WriteLine($"O melhor tipo de variavel para {valorDigitadoLong} seria sbyte");
                    Console.WriteLine("Para encerrar o programa digite sair");
                }
                else if (valorDigitadoLong >= -32768 && valorDigitadoLong <= 32767) {
                    Console.WriteLine($"O melhor tipo de variavel para {valorDigitadoLong} seria short");
                    Console.WriteLine("Para encerrar o programa digite sair");
                }
                else if (valorDigitadoLong >= -2147483648 && valorDigitadoLong <= 2147483647) {
                    Console.WriteLine($"O melhor tipo de variavel para {valorDigitadoLong} seria int");
                    Console.WriteLine("Para encerrar o programa digite sair");
                }
                else if (valorDigitadoLong >= -9223372036854775808 && valorDigitadoLong <= 9223372036854775807) {
                    Console.WriteLine($"O melhor tipo de variavel para {valorDigitadoLong} seria long");
                    Console.WriteLine("Para encerrar o programa digite sair");
                }
                else {
                    Console.WriteLine("Seu valor é muito grande e não existe variavel para isso.");
                    Console.WriteLine("Para encerrar o programa digite sair");
                }
            }
            else if (sucessoConversaoDecimal || sucessoConversaoDouble) {
                if (valorDigitadoDouble >= -3.4028235E+38 && valorDigitadoDouble <= 3.4028235E+38) {
                    Console.WriteLine($"O melhor tipo de variavel para {valorDigitadoDouble} seria float (com ~6 - 9 digitos de precisão)");
                    Console.WriteLine("Para encerrar o programa digite sair");
                }
                else if (valorDigitadoDouble >= -1.7976931348623157E+308 && valorDigitadoDouble <= 1.7976931348623157E+308) {
                    Console.WriteLine($"O melhor tipo de variavel para {valorDigitadoDouble} seria double(com ~15 - 17 digitos de precisão)");
                    Console.WriteLine("Para encerrar o programa digite sair");
                }
                else if (valorDigitadoDecimal >= -79228162514264337593543950335M && valorDigitadoDecimal <= 79228162514264337593543950335M) {
                    Console.WriteLine($"O melhor tipo de variavel para {valorDigitadoDecimal} seria decimal(com 28 - 29 digitos de precisão");
                    Console.WriteLine("Para encerrar o programa digite sair");
                }
                else {
                    Console.WriteLine("Seu valor é muito grande e não existe variavel para isso.");
                }
            }    
    }



        //        Tipos integrais com sinal:
        //sbyte  : -128 to 127
        //short  : -32768 to 32767
        //int    : -2147483648 to 2147483647
        //long   : -9223372036854775808 to 9223372036854775807

        //Tipos integrais sem sinal:
        //byte   : 0 to 255
        //ushort : 0 to 65535
        //uint   : 0 to 4294967295
        //ulong  : 0 to 18446744073709551615

        //Tipos decimais:
        //float  : -3,4028235E+38 to 3,4028235E+38(com ~6 - 9 digitos de precisão)
        //double : -1,7976931348623157E+308 to 1,7976931348623157E+308(with ~15 - 17 digits of precision)
        //decimal: -79228162514264337593543950335 to 79228162514264337593543950335(with 28 - 29 digits of precision)












        //Console.WriteLine("Tipos integrais com sinal:");

        //Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
        //Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
        //Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
        //Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

        //Console.WriteLine("");
        //Console.WriteLine("Tipos integrais sem sinal:");

        //Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
        //Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
        //Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
        //Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

        //Console.WriteLine("");
        //Console.WriteLine("Tipos decimais:");
        //Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (com ~6-9 digitos de precisão)");
        //Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
        //Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

        //ALTERAR VARIAVEIS
        //Console.WriteLine("Exemplo Parse Normal");

        //string first = "5";
        //string second = "20";
        //int sum = int.Parse(first) + int.Parse(second);
        //Console.WriteLine(sum);

        //Console.WriteLine("Exemplo TryParse");

        //string value = "102";
        //int result = 0;
        //if (int.TryParse(value, out result)) {
        //    Console.WriteLine($"Measurement: {result}");
        //}
        //else {
        //    Console.WriteLine("Unable to report the measurement.");
    }
}
