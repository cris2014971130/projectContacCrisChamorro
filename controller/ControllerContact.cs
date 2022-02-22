namespace ProjectContact;

public class ControllerContact{

    public List<Contact> listContacts;
    public int tamanio;

    public ControllerContact(int tamanio){
        listContacts = new List<Contact>(tamanio);
        this.tamanio = tamanio;
    }

    public void addContact(Contact contact){
        if (!isExistContact(contact.name)){
            listContacts.Add(contact);
            Console.WriteLine("Se agrego correctamente el contacto");
        }else{
            Console.WriteLine("El contacto ya existe");
        }
    }

    public bool isExistContact(string name){
        if (leastOne()){
            foreach (var contactAux in listContacts){
                if (contactAux != null){
                    if (contactAux.name.ToLower().Equals(name.ToLower())){
                        return true;
                    }
                }
            }
        }
        return false;
    }

    public void listContact(){
        if (leastOne()){
            foreach (Contact contact in listContacts){
                Console.WriteLine(contact.ToString());
            }
        }else{
            Console.WriteLine("No hay contactos en la lista");
        }
    }

    public Contact searchContact(string contactName){
        if (leastOne()){
            for (int i = 0; i < listContacts.Count(); i++){
                if (listContacts.ElementAt(i).name.ToLower().Equals(contactName.ToLower())){
                    return listContacts.ElementAt(i);
                }
            }
        }
        return null;
    }

    public void deleteContact(Contact contact){
        if (contact != null && searchContact(contact.name) != null){
            listContacts.RemoveAt(listContacts.IndexOf(contact));
            Console.WriteLine("contacto eliminado");
        }else{
            Console.WriteLine("No se encontro el contacto que se quiere eliminar");
        }
    }

    public bool isFilled(){
        if (listContacts.Count() == tamanio){
            return true;
        }else{
            return false;
        }
    }

    public int spaceFree(){
        if (leastOne()){
            return listContacts.Capacity - listContacts.Count();
        }else{
            return listContacts.Capacity;
        }
    }

    /**
        Retorna verdadero o falso si existe al menos un contacto en la lista.
    */
    public bool leastOne(){
        if(listContacts.Count() > 0) return true;
        return false;
    }
}

