using System;
using System.Collections.Generic;

namespace LamdaDemo
{ 
public class ListLambda
{
	public static void Main()
	{
		//lambda with return
		Func<int, int> foo = number => number * number;
		Console.WriteLine(foo(5));
		//lambda without return
		Action<string> foobar = name => Console.WriteLine("hello " + name);
		foobar("kristoffer");
		//lambda inside another method
		var books = new Books().GetBooks();

		var expensiveBooks = books.FindAll(book => book.price > 30);

		foreach (var book in books)
			Console.WriteLine("expensive book: " + book.title);
	}
}

class Books
{
	public List<Book> GetBooks()
	{
		return new List<Book>{new Book()
		{title = "book1", price = 50}, new Book()
		{title = "book2", price = 40}, new Book()
		{title = "book3", price = 30}, new Book()
		{title = "book4", price = 20}};
	}
}

class Book
{
	public string title
	{
		get;
		set;
	}

	public int price
	{
		get;
		set;
	}
}
}