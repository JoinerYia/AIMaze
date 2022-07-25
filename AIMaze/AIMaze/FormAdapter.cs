using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using AIMaze.MazeTool;

namespace AIMaze
{
    public class FormAdapter : IGraphis
    {
        public delegate void UpdatedHandler();
        public event UpdatedHandler GraphisUpdated;

        public Color[] _colorSet = { Color.Wheat, Color.DarkGray, Color.PeachPuff, Color.SpringGreen };
        Graphics _graphics;
        const int CHUNK_SIDE = 90;
        const int GAP = 10;
        
        private void Update()
        {
            if (GraphisUpdated != null)
                GraphisUpdated();
        }

        public FormAdapter(Image image)
        {
            _graphics = Graphics.FromImage(image);
            _graphics.Clear(Color.Black);
            Update();
        }

        public void DrawChunk(int x, int y, Maze.ChunkType type)
        {
            Brush brush = new SolidBrush(_colorSet[(int)type]);
            _graphics.FillRectangle(brush, 10 + (CHUNK_SIDE + GAP) * x, 10 + (CHUNK_SIDE + GAP) * y, CHUNK_SIDE, CHUNK_SIDE);
            Update();
        }

        public void DrawString(int x, int y, string text)
        {
            _graphics.DrawString(text, SystemFonts.DefaultFont, Brushes.Black, x, y);
        }
    }
}
