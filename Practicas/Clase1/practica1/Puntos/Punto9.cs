class Punto9{
    public void p9(){
        String st= Console.ReadLine();
        String st1 = Console.ReadLine();

        if(st.Length == st1.Length){
            if((st[0] == st1[st.Length-1])&&(st[st.Length-1]==st1[0])){
               Console.WriteLine("son simetricos"); 
            }
            else{
                Console.WriteLine("no son simetricos");
            }
        }
        else{
            Console.WriteLine("no poseen la misma longitud");
        }
    }
}