using MonkeyFinder.Services;

namespace MonkeyFinder.ViewModel;

public partial class MonkeysViewModel : BaseViewModel
{
  public MonkeysViewModel()
  {
  }

  [RelayCommand]
  async Task GoToDetails(Monkey monkey)
  {
    if (monkey == null)
      return;

    await Shell.Current.GoToAsync(nameof(DetailsPage), true, new Dictionary<string, object>
    {
        {"Monkey", monkey }
    });
  }
}
