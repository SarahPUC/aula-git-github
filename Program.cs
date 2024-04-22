//Fazer um programa leia uma sequência de valores inteiros
//fornecida pelo usuário em uma linha de entrada e conte o número de valores positivos, negativos e zeros.

int positivo=0,negativos=0,zeros=0,num=0;
while(num!=12345){
    Console.WriteLine("Escreva um valor: ");
    num=int.Parse(Console.ReadLine());
        if(num>0){
        positivo++;
        }
        else if(num<0){
        negativos++;
        }
        else{
        zeros++;
        }
Console.WriteLine("Quantidade de números positivos: {0}, negativos: {1} e zeros: {2}",positivo,negativos,zeros);
}
