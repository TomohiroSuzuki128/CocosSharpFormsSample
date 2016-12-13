using System;
using System.Collections.Generic;

using Xamarin.Forms;
using CocosSharp;
using CocosSharpFormsSample.ViewModels;

namespace CocosSharpFormsSample.Views
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

			var grid = this.FindByName<Grid>("MainGrid");

			var gameView = new CocosSharpView()
			{
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand,
				ViewCreated = CocosSharpView_ViewCreated
			};
			grid.Children.Add(gameView, 0, 0);
		}

		private void CocosSharpView_ViewCreated(object sender, EventArgs e)
		{
			var gameView = sender as CCGameView;

			if (gameView != null)
			{
				gameView.DesignResolution = new CCSizeI(350, 300);
				gameView.ResolutionPolicy = CCViewResolutionPolicy.ExactFit;
				gameView.ContentManager.SearchPaths = new List<string> { "Images" };
				var gameScene = new GameScene(gameView);
				gameView.RunWithScene(gameScene);
				var viewModel = BindingContext as MainPageViewModel;
				viewModel.GameScene = gameScene;
			}
		}

	}
}
