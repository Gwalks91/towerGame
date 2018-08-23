

namespace TowerGame.States.GameState
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;
    using Microsoft.Xna.Framework.Content;

    using TowerGame.Enums;
    using System;

    class GameGrid
    {
        byte[,] tiles;

        Texture2D tileSprites;

        int gameTileWidth, gameTileHeight, spriteTileWidth, spriteTileHeight;

        /*
         * Function used to load the grid info from a file.
         */
        public void LoadGrid(ContentManager content, string fileName)
        {
            tileSprites = content.Load<Texture2D>("TestTiles");

            tiles = new byte[5, 5] { { 0x00, 0x01, 0x00, 0x01, 0x00 },
                { 0x01, 0x00, 0x01, 0x00, 0x01 },
                { 0x00, 0x01, 0x00, 0x01, 0x00 },
                { 0x01, 0x01, 0x01, 0x01, 0x01 },
                { 0x01, 0x01, 0x01, 0x01, 0x01 } };

            gameTileWidth = 50;
            gameTileHeight = 50;

            spriteTileWidth = 100;
            spriteTileHeight = 100;
        }

        public void UpdateTile(int tileNumber, byte update)
        {

        }

        public void DrawGrid(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            for (int row = 0; row < tiles.GetLength(0); row++)
            {
                for (int column = 0; column < tiles.GetLength(1); column++)
                {
                    spriteBatch.Draw(tileSprites, 
                        new Vector2((gameTileWidth * column), (gameTileHeight * row)), 
                        new Rectangle((tiles[row, column] & (byte)(TileMasks.TextureMask)) * spriteTileWidth, 0, spriteTileWidth, spriteTileHeight), 
                        Color.White, 
                        0.0f, 
                        new Vector2((gameTileWidth / 2), (gameTileHeight / 2)), 
                        ((float)gameTileWidth / spriteTileWidth), 
                        SpriteEffects.None, 
                        0.0f);
                }
                
            }
            spriteBatch.End();
        }
    }
}
