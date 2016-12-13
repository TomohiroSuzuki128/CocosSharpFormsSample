using System;

using CocosSharp;

namespace CocosSharpFormsSample
{
	public class GameLayer : CCLayerColor
	{
		private CCTexture2D sushiTexture;

		public GameLayer(CCColor4B? color = default(CCColor4B?)) : base(color)
		{
			sushiTexture = new CCSprite("Sushi.png", null).Texture;
		}

		public void ConveyorShushiRightToLeft()
		{
			var sushi = new CCSprite(sushiTexture);
			sushi.PositionX = 401f;
			sushi.PositionY = 80f;
			var moveBy = new CCMoveBy(4f, new CCPoint(-500f, 0));
			var remove = new CCRemoveSelf();
			var sequence = new CCSequence(moveBy, remove);
			sushi.RunAction(sequence);
			AddChild(sushi);
		}

		public void ConveyorShushiLeftToRight()
		{
			var sushi = new CCSprite(sushiTexture);
			sushi.PositionX = -50f;
			sushi.PositionY = 210f;
			var moveBy = new CCMoveBy(4f, new CCPoint(500f, 0));
			var remove = new CCRemoveSelf();
			var sequence = new CCSequence(moveBy, remove);
			sushi.RunAction(sequence);
			AddChild(sushi);
		}

	}
}