using Iterator;

Library library = new Library();
Book book1 = new Book("Преступление и наказание", "Ф.М.Достоевский", 1866);
Book book2 = new Book("Вий", "Н.В.Гоголь", 1835);
Book book3 = new Book("Капитанская Дочка", "А.С.Пушкин", 1836);
Book book4 = new Book("Обломов", "И.А.Обломов", 1859);

library[0] = book1;
library[1] = book2;
library[2] = book3;
library[3] = book4;

foreach (Book book in library)
{
    Console.WriteLine($"Автор: {book.Author}\nПроизведение: {book.Title}\nДата написания: {book.Year}\n");
}