using CommunityToolkit.Mvvm.ComponentModel;

using System.Collections.ObjectModel;

namespace FirstAvaloniaProject.ViewModels;

using CommunityToolkit.Mvvm.Input;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty] private string _name = "";

    [ObservableProperty] private string _display = "Benvenuto argazzo";

    [ObservableProperty] private string _buttonText = "LOGIN";

    [ObservableProperty] private bool _logged = false;
    
    [ObservableProperty] ObservableCollection<string> _lista = new();

    [RelayCommand] 
    private void Aggiungi() 
    { 
        Lista.Add("Nuovo Elemento"); 
    }

    [RelayCommand]
    private void Login()
    {

        if (!_logged)
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                Display = Display;
                return;
            }
            
            
            
            Display = $"Benvenuto/a {Name}";
            ButtonText = "LOGOUT";
            _logged = true;
        }
        else
        {
            Display = "Arrivederci";
            Name = "";
            ButtonText = "LOGIN";
            _logged = false;
        }


    }


}