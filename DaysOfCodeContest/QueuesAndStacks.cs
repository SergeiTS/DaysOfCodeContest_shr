using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCodeContest
{
    class QueuesAndStacks
    {
        Queue<char> queue = new Queue<char>();
        Stack<char> stack = new Stack<char>();
        public void pushCharacter(char ch) => stack.Push(ch);
        
        public void enqueueCharacter(char ch) => queue.Enqueue(ch);
        
        public char popCharacter() => stack.Pop();
        
        public char dequeueCharacter() => queue.Dequeue();
    }
}
