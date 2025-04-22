using System;

namespace DelegateEventDemo
{
    // Step 1: Define a delegate
    public delegate void NotifyEventHandler(string message);

    class Publisher
    {
        // Step 2: Define an event based on the delegate
        public event NotifyEventHandler OnNotify;

        public void TriggerEvent(string message)
        {
            // Step 3: Raise the event (notify subscribers)
            if (OnNotify != null)
                OnNotify(message);
        }
    }

    class Subscriber
    {
        public void OnEventTriggered(string message)
        {
            Console.WriteLine("Event received: " + message);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Purna Shrestha (28683/078)\n");

            Publisher publisher = new Publisher();
            Subscriber subscriber = new Subscriber();

            // Step 4: Subscribe to the event
            publisher.OnNotify += subscriber.OnEventTriggered;

            // Step 5: Trigger the event
            publisher.TriggerEvent("This is a test message from the Publisher!");
        }
    }
}

// Output:
// Purna Shrestha (28683/078)
// Event received: This is a test message from the Publisher!

