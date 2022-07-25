using System;
using System.Collections.Generic;
using System.Text;

namespace AIMaze.MazeTool
{
    public interface IGraphis
    {
        void DrawChunk(int x, int y, Maze.ChunkType type);
    }
}
