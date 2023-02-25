using System;

Console.WriteLine("Введите размер матрицы");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
Real_Matrix matrix = new Real_Matrix(n,m);
double[,] a = new double[n, m];
matrix._m = m;
matrix._n = n;
int i = 0;
int j = 0;
matrix.Write();
Console.WriteLine("Введите строку");
int b = Convert.ToInt32(Console.ReadLine());
int bs = b - 1;
matrix.F(bs);
matrix.Write();
Console.ReadLine();

class Real_Matrix
{
    public int _n;
    public int _m;
    private double[,] _matrix;

    public Real_Matrix(int n, int m)
    {
        _n = n;
        _m = m;
        _matrix = GetRandomMatrix(_n, _m);
    }

    private double[,] GetRandomMatrix(int n, int m)
    {
        double[,] matrix = new double[n, m];
        Random random = new Random();
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < m; j++)
            {
                matrix[i, j] = random.Next(10);
            }
        }
        return matrix;
    }

    public void Write()
    {
        for (int i = 0; i < _n; i++)
        {
            for (int j = 0; j < _m; j++)
            {
                Console.Write($"{_matrix[i,j]}\t");
            }
            Console.WriteLine("");
        }

    }

    public void F(int numS)
    {
        for (int i = 0; i < _n; i++)
        {
            if (i != numS)
            {
                for(int j = 0; j < _m; j++)
                {
                    _matrix[i, j] -= _matrix[numS, j];
                }
            }
        }   
    }
}