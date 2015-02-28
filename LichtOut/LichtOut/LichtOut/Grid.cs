using System;
using System.Collections.Generic;
using System.Drawing;

namespace LichtOut
{
    public class Grid
    {
        private GameMode gameMode;
        private int gridSize;
        private int buttonSize;
        private const int EASY_GRID_SIZE = 3;
        private const int CLASSIC_GRID_SIZE = 5;
        private const int EASY_BTN_SIZE = 170;
        private const int CLASSIC_BTN_SIZE = 100;
        private readonly Color onTileColor;
        private readonly Color offTileColor;
        private LightTile[,] grid;

        public Grid(GameMode gameMode, Color onLightColor, Color offLightColor)
        {
            this.gameMode = gameMode;
            this.onTileColor = onLightColor;
            this.offTileColor = offLightColor;
            gridSize = (this.gameMode == GameMode.EASY) ? EASY_GRID_SIZE : CLASSIC_GRID_SIZE;
            buttonSize = (this.gameMode == GameMode.EASY) ? EASY_BTN_SIZE : CLASSIC_BTN_SIZE;
            this.grid = new LightTile[gridSize, gridSize];
        }

        public LightTile[,] CreateGrid()
        {
            int distance = 10;
            int startXY = 5;

            for (int row = 0; row < this.grid.GetLength(0); row++)
            {
                for (int col = 0; col < this.grid.GetLength(1); col++)
                {
                    LightTile tempTile = new LightTile(this.onTileColor, this.offTileColor);
                    tempTile.Top = startXY + (row * this.buttonSize + distance);
                    tempTile.Left = startXY + (col * this.buttonSize + distance);
                    tempTile.Height = this.buttonSize;
                    tempTile.Width = this.buttonSize;

                    this.grid[row, col] = tempTile;
                }
            }

            return this.grid;
        }
    }
}
