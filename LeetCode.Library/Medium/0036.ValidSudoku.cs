using System.Collections.Generic;

namespace LeetCode.Library.Medium
{
    public class ValidSudoku
    {
        public bool IsValidSudoku(char[][] board)
        {
            var map = new HashSet<string>();
            for (int row = 0; row < board.Length; row++)
            {
                for (int column = 0; column < board[row].Length; column++)
                {
                    var number = board[row][column];
                    if (number == '.')
                    {
                        continue;
                    }
                    if (!map.Add($"Number {number} in row {row}")
                        || !map.Add($"Number {number} in column {column}")
                        || !map.Add($"Number {number} in block ({row / 3}, {column / 3})"))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}