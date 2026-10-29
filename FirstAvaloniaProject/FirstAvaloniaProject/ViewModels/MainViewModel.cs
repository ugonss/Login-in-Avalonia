using CommunityToolkit.Mvvm.ComponentModel;

using CommunityToolkit.Mvvm.Input;

namespace FirstAvaloniaProject.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty] private string _name = "";

    [ObservableProperty] private string _display = "Benvenuto argazzo";

    [ObservableProperty] private string _buttonText = "LOGIN";

    private bool _logged = false;

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