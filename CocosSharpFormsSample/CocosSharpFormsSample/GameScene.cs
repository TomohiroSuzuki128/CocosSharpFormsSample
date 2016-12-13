using System;

using CocosSharp;

namespace CocosSharpFormsSample
{
	public class GameScene : CCScene
	{
		GameLayer layer;

		public GameScene(CCGameView gameView) : base(gameView)
		{
			layer = new GameLayer(CCColor4B.White);
			AddLayer(layer);
		}

		public void RightToLeft()
		{
			layer.ConveyorShushiRightToLeft();
		}

		public void LeftToRight()
		{
			layer.ConveyorShushiLeftToRight();
		}

	}
}