using System;
using System.Collections.Generic;
using System.Text;

namespace AIMaze.MazeTool
{
    public class Maze
    {
        public enum ChunkType
        {
            Road,
            Wall,
            Start,
            End
        }

        public delegate void ChunkUpdatedHandler(int x, int y);
        public event ChunkUpdatedHandler ChunkUpdated;

        private ChunkType[,] _map;
        private int _width;
        private int _height;

        public Maze()
            : this(0, 0) { }

        public Maze(int width, int height)
        {
            Resize(width, height);
        }

        public void Update(int x,int y)
        {
            if (ChunkUpdated != null)
                ChunkUpdated(x, y);
        }

        public void Resize(int width, int height)
        {
            _width = width;
            _height = height;
            _map = new ChunkType[width, height];

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    SetRoad(x, y);
                }
            }
        }

        private void SetChunkType(int x, int y, ChunkType type)
        {
            _map[x, y] = type;
            Update(x, y);
        }

        public void SetRoad(int x, int y)
        {
            SetChunkType(x, y, ChunkType.Road);
        }

        public void SetWall(int x, int y)
        {
            SetChunkType(x, y, ChunkType.Wall);
        }

        public void SetStart(int x, int y)
        {
            for (int chunkY = 0; chunkY < _height; chunkY++)
            {
                for (int chunkX = 0; chunkX < _width; chunkX++)
                {
                    if (_map[chunkX, chunkY] == ChunkType.Start)
                        SetRoad(chunkX, chunkY);
                }
            }

            SetChunkType(x, y, ChunkType.Start);
        }

        public void SetEnd(int x, int y)
        {
            for (int chunkY = 0; chunkY < _height; chunkY++)
            {
                for (int chunkX = 0; chunkX < _width; chunkX++)
                {
                    if (_map[chunkX, chunkY] == ChunkType.End)
                        SetRoad(chunkX, chunkY);
                }
            }

            SetChunkType(x, y, ChunkType.End);
        }

        public ChunkType GetChunkType(int x,int y)
        {
            return _map[x, y];
        }

        public void DrawChunk(int x, int y, IGraphis graphis)
        {
            graphis.DrawChunk(x, y, _map[x, y]);
        }
    }
}
