// See https://leetcode.com/problems/rotate-image/

Solution sol = new Solution();
int[,] matrix = new int [,] {
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};
sol.Rotate(matrix);
public class Solution
{
    public void Rotate(int[,] matrix)
    {
        
        int x = matrix.GetLength(0);
        int y = matrix.GetLength(1);
        int[,] matrix2 = new int[x,y];
        for (int i = 0; i <= x - 1; i++) {
            for (int j = 0; j <= y - 1 ; j++)
            {
                // TODO
                Console.Write($"{matrix[i, j]}");
            }
            Console.WriteLine("");
        }
    }
}