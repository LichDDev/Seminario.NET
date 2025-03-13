

class Punto1{
    public void p1(){
        Console.Write("hola mundo");//escribe sin ocupar una linea completa
        Console.WriteLine("hola mundo ln"); // escribe ocupando una linea entera sin importar el mensaje
        Console.ReadKey(); //obtiene la siguiente tecla presionada para luego seguir con la siguiente instruccion, con el parametro TRUE no se muestra la tecla ingresada y FALSE si se muestra
        
        String mensaje = "Hola Randoms digo Mundo";

        for(int i = 0;i<mensaje.Length;i++){
            Console.Write(mensaje[i]+"");
            Console.ReadKey(true);   
        }
    }
}