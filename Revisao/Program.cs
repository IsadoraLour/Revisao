using Revisao;

Funcionario fun = new Funcionario();
Dependente den = new Dependente();
Automovel aut = new Automovel("1234567");

string ValorMatricula = fun.ValorMatricula();

Console.Clear();
Console.WriteLine($"A sua matricula é {ValorMatricula}");

if (fun.verificarVeiculo(aut))
{
    Console.WriteLine("A placa tem o tamanho de 7 caracteres");
}

else
{
    Console.WriteLine("A placa que não tem o tamanho de 7 caracteres");
   
}

