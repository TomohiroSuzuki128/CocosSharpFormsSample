using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;

namespace CocosSharpFormsSample.ViewModels
{
	public class MainPageViewModel : BindableBase
	{

		public GameScene GameScene { get; set; }
		public DelegateCommand LeftCommand => new DelegateCommand(Left, CanLeft);
		public DelegateCommand RightCommand => new DelegateCommand(Right, CanRight);

		INavigationService _navigationService;

		public MainPageViewModel(INavigationService navigationService)
		{
			_navigationService = navigationService;
		}

		private bool CanLeft()
		{
			return true;
		}

		private void Left()
		{
			GameScene.RightToLeft();
		}

		private bool CanRight()
		{
			return true;
		}

		private void Right()
		{
			GameScene.LeftToRight();
		}

	}
}
