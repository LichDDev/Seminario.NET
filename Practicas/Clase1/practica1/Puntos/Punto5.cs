
class Punto5{
    public void p5a(){
        String name =  Console.ReadLine();
        if(String.IsNullOrWhiteSpace(name)==false){
            if(name.Equals("Juan")){
                Console.WriteLine("Hola amigo!!");
            }
            else if(name.Equals("Maria")){
                Console.WriteLine("Buen dia señora");
            }
            else if(name.Equals("Alberto")){
                Console.WriteLine("Hola Alberto");
            }
            else{
                Console.WriteLine($"buen dia {name}");
            }
        }
        else{
            Console.WriteLine("buen dia mundo");
        }
    }
    public void p5b(){
        String name =  Console.ReadLine();
        switch (name.Trim()) //remueve los espacion en blanco del String
        {
            case "Juan":
                Console.WriteLine("!Hola amigo!");
            break;
            case "Maria":
                Console.WriteLine("Buen dia ,Señora");
            break;
            case "Alberto":
                Console.WriteLine("Hola Alberto");
            break;
            case null or "":
                Console.WriteLine("Buen Dia Mundo");
            break;
            default:
                Console.WriteLine($"Buen dia {name}");
                break;
        }
    }
}