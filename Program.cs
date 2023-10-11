// 1.-Crear un loop que recorra del 1 al 255
int i = 1;
for(i = 1; i < 256; i++){
    Console.WriteLine(i);
}
Console.WriteLine("---------------------------------------");
// 2.-Crear un loop que imprima los valores del 1 al 100 que sean divisibles por 5

int x = 1;
for(x = 1; x < 101; x++){
    if (x % 5 == 0){
        Console.Write(x);}
}

Console.WriteLine("---------------------------------------");
// 3.-Crear un loop que imprima los valores del 1 al 100 que sean divisibles por 3 indicando FIZZ y 5 indicando FUZZ

int f = 1;
for(f = 1; f <= 100; f++){
    if ((f%3==0) && !(f%5==0)){
        Console.Write("FizzBuzz");
}
else if (f % 3 == 0) {
        Console.WriteLine("Fizz");
    }
    else if (f % 5 == 0) {
        Console.WriteLine("Buzz");
    }
}
                //Ciclo While 

// 1.-Crear un loop que recorra del 1 al 255

int=1;
while(i < 256){
    Console.WriteLine(i);
    i++;
}
Console.WriteLine("---------------------------------------");

//2.- Crear un loop que imprima los valores del 1 al 100 que sean divisibles por 5

int x=1;
while(x < 101){
    if (x % 5==0){
        Console.Write(x);
        }
        x++;
}

Console.WriteLine("---------------------------------------");
//3.- Crear un loop que imprima los valores del 1 al 100 que sean divisibles por 3 indicando FIZZ y 5 indicando FUZZ

int f=1;
while(f <= 100){
    if ((f%3==0) && !(f%5==0)){
        Console.Write("FizzBuzz");
}
else if (f % 3== 0) {
        Console.WriteLine("Fizz");
    }
    else if (f % 5==0) {
        Console.WriteLine("Buzz");
    }
    f++;
}



