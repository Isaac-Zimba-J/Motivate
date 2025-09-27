using Motivate.ViewModels;

namespace Motivate;

public partial class MainPage : ContentPage
{


	public MainPage(MainPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}


}

