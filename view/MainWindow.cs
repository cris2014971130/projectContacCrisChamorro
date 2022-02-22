namespace ProjectContact;

public class MainWindow{

    public Contact requestInfo(){
        
        Console.WriteLine("Escriba el nombre del contacto");
        string name = Console.ReadLine();
        Console.WriteLine("Escriba el telefono del contacto");
        string phone = Console.ReadLine();
        Console.WriteLine("Escriba el celular del contacto");
        string cellphone = Console.ReadLine();        
        return new Contact(name, phone, cellphone);
    }

    public string requestInfoName(){
        Console.WriteLine("Escriba el nombre del contacto");
        return Console.ReadLine();
    }

    public void requestKeyToContinue(){
        Console.WriteLine("Oprima una tecla para continuar");
        Console.ReadKey();
    }

    public int requestSize(){
        int size;
        bool isFinish=false;
        do{
            Console.WriteLine("Cordial saludo. Escribe el numero de datos que tendra el directorio");
            bool isNumber = Int32.TryParse(Console.ReadLine(), out size);
            if (isNumber==true && size <= 10 && size >=1){
                isFinish = true;
            }else{
                //mayusculas
                Console.WriteLine("Por favor escriba numeros validos. Intente de nuevo");
            }
        } while (isFinish==false);
        return size;
    }

    public int requestOption(){
        int option;
        bool isFinish=false;
        do{
            Console.WriteLine("Escriba la opcion ");
            bool isNumber = Int32.TryParse(Console.ReadLine(), out option);
            if (isNumber==true && option >= 1 && option <=8){
                isFinish = true;
            }else{
                //mayusculas
                Console.WriteLine("Por favor elija una opcion entre 1 y 8");
            }
        } while (isFinish==false);
        return option;
    }

    public void showInfoFinish(){
        Console.WriteLine("Vuelva Pronto y Ten un buen Día :)");
    }

    public void showInfoContactFound(Contact contact){
        if (contact != null){
            Console.WriteLine(contact.ToString());
        }else{
            Console.WriteLine("NO se encontro este contacto. Revisa que se encuentre bien escrito");
        }
    }

    public void showContactExist(bool isExist){
        if (isExist){
            Console.WriteLine("Si existe este contacto");
        }else{
            Console.WriteLine("No existe este contacto");
        }
    }

    public void showInfoFilled(bool isFilled){
        if (isFilled){
            Console.WriteLine("Esta llena, no hay mas espacios :C");
        }else{
            Console.WriteLine("Aun quedan espacios :D");
        }
    }

    public void infoMenu(){
        Console.WriteLine("Bienvenido a la agenda telefonica " + "\n1. Agregar Contacto" + "\n2. Listar Contactos" + "\n3. Buscar Contacto" + "\n4. Existira dicho Contacto? :O" + "\n5. Eliminar Contacto" + "\n6. Hay Espacio Disponible para mas contactos :D?" + "\n7. Esta llena la memoria? :c" + "\n8. Salir");
    }
}