// See https://leetcode.com/problems/rotate-image/
public class RotateMatrix
{

    public void Rotate(int[][] matrix)
    {
        int size = matrix.GetLength(0);
        int yAux = 0;
        int xAux;

        int[,] tempMatrix = new int[size, size];

        for (int i = 0; i <= size - 1; i++)
        {
            xAux = size - 1;
            for (int j = 0; j <= size - 1; j++)
            {
                tempMatrix[i,j] = matrix[xAux][yAux];
                xAux--;
            }
            yAux++;
        }
        PrintMatrix(tempMatrix, size);
    }


    public void PrintMatrix(int[,] matrix, int size) {
        for (int i = 0; i <= size - 1; i++)
        {
            for (int j = 0; j <= size - 1; j++)
            {
                Console.Write($" {matrix[i,j]} ");
            }
            Console.WriteLine("");
        }
    }
}