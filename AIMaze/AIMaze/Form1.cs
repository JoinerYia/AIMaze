using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AIMaze.MazeTool;

namespace AIMaze
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool _isRunning;
        private Bitmap _display;
        private Maze _maze;
        private FormAdapter _graphics;

        private void Form1_Load(object sender, EventArgs e)
        {
            _display = new Bitmap(1920, 1080);
            _graphics = new FormAdapter(_display);
            _graphics.GraphisUpdated += Show;
            _maze = new Maze(10, 10);
            _maze.ChunkUpdated += MazeUpdated;
            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    MazeUpdated(x, y);
                }
            }

            _isRunning = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _isRunning = false;
        }

        public void Show()
        {
            pictureBox1.Image = _display;
        }

        public void MazeUpdated(int x, int y)
        {
            _maze.DrawChunk(x, y, _graphics);
        }
    }
}
