Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");

int xa = 40, ya = 1;
int xb = 1, yb = 30;
int xc = 80, yc = 30;

Console.SetCursorPosition(xa,ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb,yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc,yc);
Console.WriteLine("+");                                // в первом блоке мы создали равнобедренный треугольник при запуске dotnet run он вырисовывается в терминале;//

int x = xa, y = ya;                                    // во втором блоке реализуем цикл построения новых точек;
int count = 0;                                        // задали  итерации для построения точек и соединения их отрезками;

while (count < 10000)
{
    int what = new Random().Next(0,3);                // генерируем случайное число "what" - при помощи генератора случайных чисел, диапозон которого от 0 до 2;
{
    if (what == 0){
        x = (x + xa)/2;
        y = (y + ya)/2;
    }

if (what == 1){
        x = (x + xb)/2;
        y = (y + yb)/2;
    }
if (what == 2){
        x = (x + xc)/2;
        y = (y + yc)/2;
    }

}
Console.SetCursorPosition( x,y);
Console.WriteLine("+");
count++;
}
