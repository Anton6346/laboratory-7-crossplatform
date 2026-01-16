using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LoginViewModel : BaseViewModel
{
    private bool _isBusy;

    public bool IsBusy
    {
        get => _isBusy;
        set { _isBusy = value; OnPropertyChanged(nameof(IsBusy)); }
    }

    public Command LoginCommand { get; }

    public LoginViewModel()
    {
        LoginCommand = new Command(async () => await Login());
    }

    private async Task Login()
    {
        IsBusy = true;
        await Task.Delay(2000);
        IsBusy = false;
        await Shell.Current.GoToAsync("//CoursesPage");
    }
}
