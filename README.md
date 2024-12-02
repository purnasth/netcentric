# Assignment 1

<details>
<summary>Write a C# program to print "Hello, World!"</summary>

### Write a C# program to print "Hello, World!".

```csharp
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
```

---
</details>

<details>
<summary>Write a C# program to implement a jagged array and create a calender</summary>

### Write a C# program to implement a jagged array and create a calender.

```csharp
using System;

namespace CalenderJaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] calendar = new int[5][];

            calendar[0] = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
            calendar[1] = new int[7] { 8, 9, 10, 11, 12, 13, 14 };
            calendar[2] = new int[7] { 15, 16, 17, 18, 19, 20, 21 };
            calendar[3] = new int[7] { 22, 23, 24, 25, 26, 27, 28 };
            calendar[4] = new int[3] { 29, 30, 31 };

            Console.WriteLine("Simple Calendar using a Jagged Array:");
            Console.WriteLine("---------------------------------------");

            for (int week = 0; week < calendar.Length; week++)
            {
                Console.Write("Week " + (week + 1) + ": ");

                for (int day = 0; day < calendar[week].Length; day++)
                {
                    Console.Write(calendar[week][day] + "\t");
                }

                Console.WriteLine();
            }
        }
    }
}
```
</details>


<details>
<summary>Create a simple Windows Form Application using C#</summary>

### Create a simple Windows Form Application using C#.
- The form should have a label and textbox for username and password.
- The form should have a button to submit the username and password.
- The form should have a label to display the message "Login Successful" or "Login Failed".
- The form should test the username and password and display the message accordingly.
- The form should be closed after the success message is displayed.

```csharp

namespace PurnaForm
{
    public partial class Form1 : Form
    {
        private object labelMessage;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            //string text = textBox1.Text;
            //MessageBox.Show("Welcome" + text);

            if (username == "Purna" && password == "123")
            {
                this.Hide();
                MessageBox.Show($"Welcome, {username}!");
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }
        }
    }
}
```

---
</details>