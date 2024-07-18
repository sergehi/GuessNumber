### Применение принципов SOLID  на примере реализации игры "Угадай число"

- [x] 1. **Принцип единственной ответстенности (Single Responsibility Principle - SRP)**:

    Каждый класс отвечает за конкретную функциональность:
    - класс GuessNumberGame для управления игровым процессом (начало игры, угадывание числа, завершение игры).
    - класс SimpleNumberGenerator для генерации случайного числа.
    - класс UserInput для обработки ввода пользователя.

- [x] 2. **Принцип открытости/закрытости (Open/Closed Principle - OCP)**:

    Интерфейс `IGame`, реализовван в классе `GuessNumberGame`, чтобы можно было легко расширять функциональность игры без изменения существующего кода.
    То же касается интерфейсов INumberGenerator и  IUserInteraction.

- [x] 3. **Принцип подстановки Барбары Лисков (Liskov Substitution Principle - LSP)**:

    Классы SimpleNumberGenerator и UserInput, могут быть использованы вместо интерфейсов INumberGenerator и  IUserInteraction без изменения желаемого поведения.

- [x] 4. **Принцип разделения интерфейса (Interface Segregation Principle - ISP)**:

    Логика игры разделена на отдельные небольшие интерфейсы: IGame, INumberGenerator, IUserInteraction.

- [x] 5. **Принцип инверсии зависимостей (Dependency Inversion Principle - DIP)**:

     Класс GuessNumberGame зависит от интерфейсов INumberGenerator и IUserInteraction, а не от конкретных реализаций
