using ProsperDaily.MVVM.Models;
using ProsperDaily.MVVM.Views;
using ProsperDaily.Repositories;

namespace ProsperDaily;

public partial class App : Application
{
	public static BaseRepository<Transaction> TransactionsRepo { get; private set; }
	public App(BaseRepository<Transaction> _transactionsRepo)
	{
		InitializeComponent();
        TransactionsRepo = _transactionsRepo;
        MainPage = new AppContainer();
    }
}