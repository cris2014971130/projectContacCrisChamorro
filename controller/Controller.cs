namespace ProjectContact;

public class Controller{

    private ControllerContact controllerContact;
    private MainWindow mainWindow;
    private Boolean isFinish;
    private int option;

    public Controller(){
        clearWindow();
        mainWindow = new MainWindow();
        isFinish = false;
        controllerContact = new ControllerContact(mainWindow.requestSize());
        do{
            clearWindow();
            mainWindow.infoMenu();
            menu(mainWindow.requestOption());
        } while (isFinish == false);
        mainWindow.showInfoFinish();
    }

    public void menu(int option){
        switch (option){
            case (int)EnumOptions.optionsMenu.optionAddContact:
                optionAddContact();
                break;
            case (int)EnumOptions.optionsMenu.optionListContact:
                optionListContact();
                break;
            case (int)EnumOptions.optionsMenu.optionSearchContact:
                optionSearchContact();
                break;
            case (int)EnumOptions.optionsMenu.optionIsExist:
                optionIsExist();
                break;
            case (int)EnumOptions.optionsMenu.optionDeleteContact:
                optionDeleteContact();
                break;
            case (int)EnumOptions.optionsMenu.optionSpaceExist:
                optionSpaceExist();
                break;
            case (int)EnumOptions.optionsMenu.optionSheduleFull:
                optionScheduleFull();
                break;
            case (int)EnumOptions.optionsMenu.optionExit:
                isFinish = true;
                break;
            default:
                break;
        }
    }

    private void optionAddContact(){
        if(!controllerContact.isFilled()){
            controllerContact.addContact(mainWindow.requestInfo());
        }else{
            mainWindow.showInfoFilled(controllerContact.isFilled());
        }
        mainWindow.requestKeyToContinue();
    }

    private void optionListContact(){
        controllerContact.listContact();
        mainWindow.requestKeyToContinue();
    }

    private void optionSearchContact(){
        Contact contact = controllerContact.searchContact(mainWindow.requestInfoName());
        if(contact != null){
             mainWindow.showInfoContactFound(contact);
        }else{
            Console.WriteLine("No se encontro el contacto");
        }
        mainWindow.requestKeyToContinue();
    }

    private void optionIsExist(){
        mainWindow.showContactExist(controllerContact.isExistContact(mainWindow.requestInfoName()));
        mainWindow.requestKeyToContinue();
    }

    private void optionDeleteContact(){
        controllerContact.deleteContact(controllerContact.searchContact(mainWindow.requestInfoName()));
        mainWindow.requestKeyToContinue();
    }

    private void optionSpaceExist(){
        Console.WriteLine("Hay " + controllerContact.spaceFree() + " espacios para guardar");
        mainWindow.requestKeyToContinue();
    }

    private void optionScheduleFull(){
        mainWindow.showInfoFilled(controllerContact.isFilled());
        mainWindow.requestKeyToContinue();
    }

    private void clearWindow(){
        Console.Clear();
    }
}