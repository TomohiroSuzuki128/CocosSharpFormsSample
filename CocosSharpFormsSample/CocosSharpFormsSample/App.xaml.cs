using Prism.Unity;
using CocosSharpFormsSample.Views;

namespace CocosSharpFormsSample
{
	public partial class App : PrismApplication
	{
		public App(IPlatformInitializer initializer = null) : base(initializer) { }

		protected override void OnInitialized()
		{
			InitializeComponent();
			NavigationService.NavigateAsync("NavigationPage/MainPage");
		}

		protected override void RegisterTypes()
		{
			Container.RegisterTypeForNavigation<Xamarin.Forms.NavigationPage>();
			Container.RegisterTypeForNavigation<MainPage>();
		}
	}
}
