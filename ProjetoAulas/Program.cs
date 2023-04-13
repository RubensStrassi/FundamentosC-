// Console.WriteLine("Primeiro Programa!");

// int idade = 33;
// Console.WriteLine(idade);
// string nomePessoa = "Rubens";
// Console.WriteLine(nomePessoa);
// decimal valor = 200.99m;
// Console.WriteLine(valor);
// double valorDouble = 200.99;
// Console.WriteLine(valorDouble);
// float valorFloat = 200.99f;
// Console.WriteLine(valorFloat);
// var idadeNova = 35;
// Console.WriteLine(idadeNova);
// char flag = 'Y';
// Console.WriteLine(flag);
// bool ativo = false;
// Console.WriteLine(ativo);
// const string descricao = "Curso";
// Console.Write(descricao);

// var numero1 = 1;
// var numero2 = 2;
// var soma = numero1 + numero2;
// Console.WriteLine(soma);

// var subtracao = numero1 - numero2;
// Console.WriteLine(subtracao);

// var multiplicacao = numero1 * numero2;
// Console.WriteLine(multiplicacao);

// var divisao = numero1 / numero2;
// Console.WriteLine(divisao);

// bool igual = numero1 == numero2;
// Console.WriteLine(igual);

// bool maior = numero1 > numero2;
// Console.WriteLine(maior);

// bool menor = numero1 < numero2;
// Console.WriteLine(menor);

// bool diferente = numero1 != numero2;
// Console.WriteLine(diferente);


// var numero1 = 1;
// var numero2 = 2;

// bool valido = numero2 > numero1 && 6>7;
// Console.WriteLine(valido);

// bool valido2 = numero2 > numero1 || 6>7;
// Console.WriteLine(valido2);

// bool valido3 = !(numero2 > 1) ;
// Console.WriteLine(valido3);

// bool ativo = false;
// string status = ativo ? "Ativo" : "Inativo";
// Console.WriteLine(status);

// Escrever();

// void Escrever() {
//     var nome = EscreverNomeCompleto();
//     var soma = Somar();

//     Console.WriteLine(nome);
//     Console.WriteLine(soma);
// }

// string EscreverNomeCompleto()
// {
//     string primeriroNome = "Rubens";
//     string segundoNome = "Strassi";
//     return primeriroNome + " " + segundoNome;
// }

// int Somar()
// {
//     return 8-2;
// }

var soma = Somar(8,3);
Console.WriteLine(soma);

var nomee = NomeIdade("Rubens",27);
Console.WriteLine(nomee);

int Somar(int a, int b)
{
    return a + b;
}

string NomeIdade(string nome, int idade)
{
    return "Meu nome é " + nome + " minha idade é "+ idade;
}

