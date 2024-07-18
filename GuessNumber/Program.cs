/*
Для демонстрации практического применения принципов SOLID (пять основных принципов объектно-ориентированного программирования) на примере реализации игры "Угадай число", можно разбить функциональность игры на отдельные классы, следуя принципам SOLID:

1. * *Принцип единственной ответстенности (Single Responsibility Principle - SRP)**:
    Каждый класс отвечает за конкретную функциональность:
    - класс GuessNumberGame для управления игровым процессом (начало игры, угадывание числа, завершение игры).
    - класс SimpleNumberGenerator для генерации случайного числа.
    - класс UserInput для обработки ввода пользователя.

2. **Принцип открытости/закрытости (Open/Closed Principle - OCP)**:
    Интерфейс `IGame`, который реализовыван классом `GuessNumberGame`, чтобы можно было легко расширять функциональность игры без изменения существующего кода.
    То же касается интерфейсов INumberGenerator и  IUserInteraction.

3. **Принцип подстановки Барбары Лисков (Liskov Substitution Principle - LSP)**:
    Классы SimpleNumberGenerator и UserInput, могут быть использованы вместо интерфейсов INumberGenerator и  IUserInteraction без изменения желаемого поведения.

4. **Принцип разделения интерфейса (Interface Segregation Principle - ISP)**:
    Логика игры разделена на отдельные небольшие интерфейсы: IGame, INumberGenerator, IUserInteraction.

5. **Принцип инверсии зависимостей (Dependency Inversion Principle - DIP)**:
     Класс GuessNumberGame зависит от интерфейсов INumberGenerator и IUserInteraction, а не от конкретных реализаций


*/

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace GuessNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min = 0;
            int max = 10;
            INumberGenerator iNumberGenerator = new SimpleNumberGenerator(min, max);
            IUserInteraction iInputAction = new UserInput(min, max);
            IGame game = new GuessNumberGame(iNumberGenerator, iInputAction);
            game.Run();
        }
    }

}