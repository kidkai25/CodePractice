using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ChessBoardModel
{
    public class Board
    {
        //Size of the board usually 8x8
        public int Size { get; set; }

        //2d array of type Cell
        public Cell[,] TheGrid { get; set; }

        //constructor
        public Board(int size)
        {
            //Initial Board Size 
            Size = size;

            //Create a new 2D array of type Cell
            TheGrid = new Cell[Size, Size];

            //Fill the 2D with new Cells, each with unique x and y coordinates
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    TheGrid[i, j] = new Cell(i, j);
                }
            }            
        }

        public void MarkNextLegalMoves(Cell currentCell, string chessPiece)
        {
            //step 1- clear all the previous legal moves

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    TheGrid[i, j].LegalNextMove = false;
                    TheGrid[i, j].CurrentlyOccupied = false;
                }
            }

            //step 2 - find all legal moves and mark the cells as "legal"
            switch(chessPiece)
            {
                case "Knight":
                    TheGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    TheGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    TheGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    TheGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    TheGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 2].LegalNextMove = true;
                    TheGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 2].LegalNextMove = true;
                    TheGrid[currentCell.RowNumber - 1 ,currentCell.ColumnNumber + 2].LegalNextMove = true;
                    TheGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 2].LegalNextMove = true;

                    break;
                case "King":
                    break;
                case "Rook":
                    break;
                case "Bishop":
                    break;
                case "Queen":
                    break;
                default:
                    break;

            }
            TheGrid[currentCell.RowNumber, currentCell.ColumnNumber].CurrentlyOccupied = true;
        }

    }
}
