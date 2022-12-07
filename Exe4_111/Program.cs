using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe4_111
{
    
    class Stack
    {
        private string[] dim;
        private int top;
        private int max;
        
        public Stack(int size)
        {
            dim = new string[size];
            top = -1;
            max = size;
        }
       
        public void pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack Underflow");
                return ;
            }
            else
            {
                Console.WriteLine("Poped element is: " + dim[top]);
                top--;
                return;
            }
        }
        public void push()
        {
            if (top == max - 1)
            {
                Console.WriteLine("Stack Overflow");
                return;
            }
            else
            {
                Console.WriteLine("Push element is: ");
                dim[++top] = Console.ReadLine();
            }
        }
        public void display()
        {
           if(top == -1)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
           else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine(dim[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            Stack s = new Stack(29);
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("\n***Stack Menu***\n");
                Console.WriteLine("1. Push ");
                Console.WriteLine("2. Pop ");
                Console.WriteLine("3. Display ");
                Console.WriteLine("4. Exit ");
                Console.WriteLine("\nEnter Your Choice: ");
                string sInput = Console.ReadLine();
                char ch = Convert.ToChar(sInput == "" ? "0" : sInput);
                switch(ch)
                {
                    case '1':
                        s.push();
                        break;
                    case '2':
                        s.pop();
                        break;
                    case '3':
                        s.display();
                        break;
                    case '4':
                        return;
                    default:
                        Console.WriteLine("\nInvalid Choice");
                        break;
                }
            }
        }
    }
}
