// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// k1*x+b1=k2*x+b2
// x(k1-k2)=b2-b1
// x=b2-b1/k1-k2

// int Promt(string message)
// {
//     Console.Write(message);
//     string readNumber = Console.ReadLine();
//     int value = Convert.ToInt32(readNumber);
//     return value;
// }
// void FindCrossPoint(int b1, int k1, int b2, int k2)
// {
//     double x = (double)(b2 - b1) / (k1 - k2);
//     double y = (double)k2 * x + b2;
//     Console.WriteLine($"({x}, {y})");
// }
// int b1 = Promt("Input number b1 - ");
// int k1 = Promt("Input number k1 - ");
// int b2 = Promt("Input number b2 - ");
// int k2 = Promt("Input number k2 - ");

// FindCrossPoint(b1, k1, b2, k2);

const int coefficient = 0;
const int constant = 1;
const int xCourd = 0;
const int yCourd = 1;
const int line1 = 1;
const int line2 = 2;

double[] lineData1 = InputParametrs(line1);
double[] lineData2 = InputParametrs(line2);

if (Exeptions(lineData1, lineData2))
{
    double[] coord = FindCoordinates(lineData1, lineData2);
    Console.WriteLine($"Point of cross equations y={lineData1[coefficient]}*x+{lineData1[constant]} and y={lineData1[coefficient]}*x+{lineData1[constant]}");
    Console.WriteLine($"Coordinates ({coord[xCourd]}, {coord[yCourd]})");
}

double Promt(string message)
{
    Console.Write(message);
    string readInput = Console.ReadLine();
    double value = Convert.ToInt32(readInput);
    return value;
}

double[] InputParametrs(int numbersOfline)
{
    double[] lineData = new double[2];
    lineData[coefficient] = Promt($"Input coefficient for {numbersOfline} line ");
    lineData[constant] = Promt($"Input constant for {numbersOfline} line ");
    return lineData;
}

double[] FindCoordinates(double[] lineData1, double[] lineData2)
{
    double[] coord = new double[2];
    coord[xCourd] = (lineData2[constant] - lineData1[constant]) / (lineData1[coefficient] - lineData2[coefficient]);
    coord[yCourd] = lineData2[coefficient] * coord[xCourd] + lineData2[constant];
    return coord;
}

bool Exeptions(double[] lineData1, double[] lineData2)
{
    if (lineData1[coefficient] == lineData2[coefficient])
    {
        if (lineData1[constant] == lineData2[constant])
        {
            Console.WriteLine("Lines lienege!");
            return false;
        }
        else
        {
            Console.WriteLine("Lines coincede!");
            return false;
        }
    }
    return true;
}





// k1*x+b1=k2*x+b2
// x(k1-k2)=b2-b1
// x=b2-b1/k1-k2
// y = k2 * x + b2