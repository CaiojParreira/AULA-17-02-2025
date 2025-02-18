double resultado, x, y, cal_x, cal_y, elevado_x, elevado_y;

x=int.Parse(Console.ReadLine());
y=int.Parse(Console.ReadLine());

cal_x = (x * 2) - (x * 1);
cal_y = (y * 2) + (y * 1);

elevado_x = Math.Pow(cal_x, 2);
elevado_y = Math.Pow(cal_y, 2);

resultado = elevado_x + elevado_y;

Console.WriteLine(Math.Sqrt(resultado));