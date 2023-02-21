using ProsperDaily.MVVM.Views;

namespace ProsperDaily;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new StatisticsPage();
	}
}
