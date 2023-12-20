// генерация случайного дробого числа

Random rand = new Random();
double number = Math.Round(rand.Next(0,10) + rand.NextDouble(),3);  
System.Console.WriteLine(number);

//Math.Round(условие,3) - сколько оставить знаков после запятой
//rand.Next(0,10)  - целая часть до запятой
//rand.NextDouble() - дробная часть после запятой, она длинная и всегда между 0 и 1
// поэтому мы ее ограничиваем и прибавляем к целому числу 


//______________________________________________________________________________
// генерация 2 рандомных числа в интервале new Random ().Next (1,10)

int a = new Random().Next (1,10);
System.Console.WriteLine(a);