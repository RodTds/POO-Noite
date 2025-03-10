using ArrayFuncionario;
//  detalhe da string declara com strng? eleimina o warning amaerelo no terminal
Funcionario[] vetF = new Funcionario[3];

for(int x =0;x < vetF.Length;x++){
    console.WriteLine("CAdastre os funcionarios ")
    vetF[x] = new Funcionario();
    Console.Write("Digite O codigo:  ");
    vetF[x].codigo = Convert.ToInt32(Console.ReadLine());
    Console.Write("Digite O Nome:  ");
    vetF[x].nome = Console.ReadLine();
    Console.Write("Digite O Salário:  ");
    vetF[x].salario = Convert.ToDouble(Console.ReadLine());

}

foreach (Funcionario f in vetF)
{
    f.Mostrar();
}
