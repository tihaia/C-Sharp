// #nullable enable

// using System;
// var state = CreateLibraryState();

// while (true)
// {
//   Console.WriteLine("1 - Показать все книги");
//   Console.WriteLine("2 - Взять книгу");
//   Console.WriteLine("3 - Вернуть книгу");
//   Console.WriteLine("4 - Выход");
//   Console.Write("ВАШ ВЫБОР: ");

//   string? choice = Console.ReadLine();

//   if (choice is null)
//     {
//         Console.WriteLine("Пустой ввод!");
//         continue;
//     }
    
//   switch (choice)
//   {
//     case "1":
//       ShowAllBooks(state.Books);
//       break;

//     case "2":
//       BorrowBook(state.Books);
//       break;

//     case "3":
//       ReturnBook(state.Books);
//       break;

//     case "4":
//       return;

//     default:
//       Console.WriteLine("Неверный ввод, введите цифру из предложенных вариантов.");
//       break;
//   }
// }


// static LibraryState CreateLibraryState()
// {
//   return new LibraryState
//   {
//     Books = new Book[]
//     {
//       new Book { Title = "Война и мир", Year = 1869, IsTaken = false },
//       new Book { Title = "Преступление и наказание", Year = 1866, IsTaken = false },
//       new Book { Title = "Мастер и Маргарита", Year = 1967, IsTaken = false },
//       new Book { Title = "1984", Year = 1949, IsTaken = false },
//       new Book { Title = "Улисс", Year = 1922, IsTaken = false }
//     }
//   };
// }

// static void ShowAllBooks(Book[] books)
// {
//   Console.WriteLine("Список книг:");

//   foreach (var book in books)
//   {
//     string status = book.IsTaken ? "Недоступна" : "Доступна";
//     Console.WriteLine($"{book.Title} ({book.Year}) : {status}");
//   }
// }

// static void BorrowBook(Book[] books)
// {
//   Console.Write("Введите название книги: ");
//   string? title = Console.ReadLine();

//   if (title is null)
//     {
//         Console.WriteLine("Пустой ввод!");
//         return;
//     }

//   foreach (var book in books)
//   {
//     if (book.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
//     {
//       if (book.IsTaken)
//       {
//         Console.WriteLine("Эта книга недоступна.");
//         return;
//       }

//       book.IsTaken = true;
//       Console.WriteLine($"Вы взяли книгу: {book.Title}");
//       return;
//     }
//   }

//   Console.WriteLine("Такой книги нет в библиотеке.");
// }

// static void ReturnBook(Book[] books)
// {
//   Console.Write("Введите название книги: ");
//   string? title = Console.ReadLine();

//   if (title is null)
//     {
//         Console.WriteLine("Пустой ввод!");
//         return;
//     }

//   foreach (var book in books)
//   {
//     if (book.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
//     {
//       if (!book.IsTaken)
//       {
//         Console.WriteLine("Эта книга уже находится в библиотеке.");
//         return;
//       }

//       book.IsTaken = false;
//       Console.WriteLine($"Книга {book.Title} успешно возвращена.");
//       return;
//     }
//   }

//   Console.WriteLine("Невозможно вернуть - такой книги нет.");
// }
// class LibraryState
// {
//   public required Book[] Books;
// }

// class Book
// {
//   public required string Title;
//   public required int Year;
//   public bool IsTaken;
// }