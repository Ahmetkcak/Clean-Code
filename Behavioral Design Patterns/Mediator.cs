
using System;
using System.Collections.Generic;
using System.Data.Common;

// Mediator interface
public interface IChatRoom // CQRS - Command Query Responsibility Segregation (Komut Sorgu Sorumluluk Ayrımı) Mediatr
{
    void SendMessage(string message, IUser user);
    void AddUser(IUser user);
}

// Concrete Mediator
public class ChatRoom : IChatRoom
{
    private List<IUser> users = new List<IUser>();

    public void AddUser(IUser user)
    {
        users.Add(user);
    }

    public void SendMessage(string message, IUser sender)
    {
        foreach (var user in users)
        {
            if (user != sender)
            {
                user.ReceiveMessage(message);
            }
        }
    }
}

// Colleague interface
public interface IUser
{
    void SendMessage(string message);
    void ReceiveMessage(string message);
}

// Concrete Colleague
public class User : IUser
{
    private readonly string name;
    private readonly IChatRoom chatRoom;

    public User(string name, IChatRoom chatRoom)
    {
        this.name = name;
        this.chatRoom = chatRoom;
        chatRoom.AddUser(this);
    }

    public void SendMessage(string message)
    {
        chatRoom.SendMessage(message, this);
    }

    public void ReceiveMessage(string message)
    {
        Console.WriteLine($"{name} received message: {message}");
    }
}

// Usage
// public class Program
// {
//     public static void Main()
//     {
//         IChatRoom chatRoom = new ChatRoom();

//         IUser user1 = new User("Alice", chatRoom);
//         IUser user2 = new User("Bob", chatRoom);
//         IUser user3 = new User("Charlie", chatRoom);

//         user1.SendMessage("Hi, everyone!");
//         user2.SendMessage("Hello, Alice!");
//         user3.SendMessage("What's up, guys?");
//     }
// }
