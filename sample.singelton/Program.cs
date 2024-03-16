// See https://aka.ms/new-console-template for more information
using sample.singelton;

Console.WriteLine("Hello, World!");

Thread threadOne = new Thread(() =>
{
    var instance = DatabaseService.Instance();
});


Thread threadTwo = new Thread(() =>
{
    var instance = DatabaseService.Instance();
});

// Start the threads
threadOne.Start();
threadTwo.Start();

// Starting both of the threads toghter
threadOne.Join();
threadTwo.Join();