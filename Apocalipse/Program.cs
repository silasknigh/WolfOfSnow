
/*

void Mensagem(){
   
    Console.WriteLine("olá caos");
    return;
}
Mensagem();

void Escreva(string msg){
    Console.WriteLine(msg);
}

Escreva("olá triângulo quadrado");
Escreva("its normal:)");
Escreva( "Miqueas coringando :o");

void MostarIdade(string hadassa, int 16){
    Escreva($"{hadassa} tem [{16} anos");
int MaiorEntre( int a,int b 
{
    if(a )


*/
void Soma(float a, float b){
    float resultado = a + b;
    Console.WriteLine($"{a} + {b} = {resultado}");
} 

void Subtração(float a, float b){
    float resultado = a - b;
    Console.WriteLine($"{a} - {b} = {resultado}");
}

void Multiplicação(float a, float b){
    float resultado = a * b;
    Console.WriteLine($"{a} * {b} = {resultado}");
}

void Divisão(float a, float b){
    if(b == 0){
            Console.WriteLine("Erro de divisão por zero");
            return;
    }
    float resultado = a / b;
    Console.WriteLine($"{a} / {b} = {resultado}");
}

//Variáveis globais
float a;
float b;

void  DigitarAeB()
{
    Console.WriteLine($"Digite o valor de a");
    a =  float.Parse(Console.ReadLine());
    Console.WriteLine($"Digite o valor de b");
    b =  float.Parse(Console.WriteLine());
}

//MENU
Console.WrirteLine("--- CALCULADORA ---");
Console.WriteLine("1 - Soma");
Console.WriteLine("2 - Subtração");
Console.WriteLine("3 - Multiplicação");
Console.WriteLine("4 - Divisão");
Console.WriteLine("5 - Sair");
Console.WtriteLine("--------------------");
Console.Writeline("digite a opção desejada:");

int opção = int.Parse(Console.ReadLine());




