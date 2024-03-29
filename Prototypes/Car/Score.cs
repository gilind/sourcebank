﻿namespace Breakout
{
	/// <summary>
	/// Each brick can either be dead or alive, has a color and the bounding
	/// rectangle for rendering and collision detection.
	/// </summary>
	public class Score
	{
		public Score()
		{
			Level = InitialLevel;
		}

		public int Level { get; private set; }
		private const int InitialLevel = 1;

		public void NextLevel()
		{
			Level++;
			lives++;
		}

		private int lives = InitialLives;
		private const int InitialLives = 3;

		public void IncreasePoints()
		{
			destroyedBlocksInARow++;
			points += destroyedBlocksInARow + Level;
		}

		private int destroyedBlocksInARow;
		private int points;

		public void LostLive()
		{
			lives--;
			destroyedBlocksInARow /= 2;
			if (lives == 0)
				IsGameOver = true;
		}

		public bool IsGameOver { get; private set; }

		public override string ToString()
		{
			return "Level: " + Level + ", Score: " + points +
				(IsGameOver ? " - GAME OVER" : ", Lives: " + lives);
		}
	}
}