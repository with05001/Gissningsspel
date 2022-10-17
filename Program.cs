Random Rnd = new Random();
int Rätt, input;
Rätt = Rnd.Next(101);
int Räknare = 0;
do{
    Console.WriteLine("Gissa ett tal från 1-100");
    input = int.Parse(Console.ReadLine());
    if(input<Rätt){
        Console.WriteLine("Tallet är för lågt");
    }
    else if(input>Rätt){
        Console.WriteLine("Tallet är för högt");
    }
    else{
        Console.WriteLine("Du gissade rätt!");
    }
    Räknare++;
}while(input!=Rätt);
Console.WriteLine("Det tog dig "+ Räknare +" försök!");