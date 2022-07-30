#  FileSortingConsole

## Оглавление 
1. [Цель проекта](#ProjectGoals)
2. [Элементы библиотеки](#LibraryElements)
    + [Класс `ConsoleLogger`](#ConsoleLogger)
    + [Класс `ConfigParser<T>`](#ConfigParser)
    + [Класс `NullConfigException`](#NullConfigException)
3. [Примеры реалезации библиотеки](#LibraryExamples)
4. [Свойства проекта](#ProjectProperties)

## Цели проекта <a name="ProjectGoals"></a>
Предоставить пользователю простое приложения для сортировки файлов с настройкой через json файл

## Элементы библиотеки <a name="LibraryElements"></a>

### Класс `ConsoleLogger` <a name="ConsoleLogger"></a>
Явяется классом реалезующий интерфейс `ILogger` из библиотеки, нужен для предаставления вывода информации хода приложения в консоль. Находтися в пространсве именн имен `FileSortingConsole`

### Класс `ConfigParser<T>` <a name="ConfigParser"></a>
Класс позволяющий распарсить json по указанному пути. `T` обощение ограниченое по интерфейсу `ISortingConfig`

#### Конструктор  
* `ConfigParser(string configPath)`  
**configPath** - строка к пути нахождения json файла
* `ConfigParser()`  
Пустой конструктор задающий строку как "config.json"

#### Методы 
* `ISortingConfig Parse()`  
Метод читающий файл по заданому пути и переводит его в обьект `T` реалезующий интерфейс `ISortingConfig`
* `static ISortingConfig Parse<TConfig>(string configPath)`  
Метод читающий файл по заданому пути и переводит его в обьект `TConfig` реалезующий интерфейс `ISortingConfig`  
**configPath** - путь к json файлу  

### Класс `NullConfigException` <a name="NullConfigException"></a>
Класс вызываемый если при парсенге конфигурации вернулся null

## Библиотеки <a name="LibraryExamples"></a>
* [Библиотека](https://github.com/Ang2Tea/FileSortingCore)

## Свойства проекта <a name="ProjectProperties"></a>
 Проетк реалезован на C# 10, платформа .NET 6