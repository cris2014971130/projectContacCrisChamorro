namespace ProjectContact;

public class Contact{

    public string name;
    public string phone;
    public string cellphone;

    public Contact(string name, string phone, string cellphone){
        this.name = name;
        this.phone = phone;
        this.cellphone = cellphone;
    }

    public override string ToString(){
        return "Nombre: " + name + " Telefono: " + phone + " Celular: " + cellphone;
    }
}