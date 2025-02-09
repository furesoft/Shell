using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ShellExample.Views;

public partial class HomePage : UserControl
{
	public HomePage()
	{
		InitializeComponent();
		DataContext = new ViewModels.HomePageViewModel(MainView.Current.ShellViewMain.Navigator);
	}

	private void InitializeComponent()
	{
		AvaloniaXamlLoader.Load(this);
	}

	public string Icon => "/Assets/Icons/house-solid.png";
}
