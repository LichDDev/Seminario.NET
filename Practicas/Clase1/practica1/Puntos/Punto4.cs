
class Punto4{
    public void p4(){
        Console.WriteLine("ingrese su nombre: ");
        String name = Console.ReadLine();
        if(String.IsNullOrWhiteSpace(name)) //esta funcion devuelve si hay una linea en blanco o null
        {
            Console.WriteLine("hola mundo");
        }
        else{
            Console.WriteLine($"hola {name} como estas ");
        }
    }
}