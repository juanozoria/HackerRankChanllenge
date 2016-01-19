using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class Palindrome {
  //Write your code here
    Stack<char> staky; //creates the stack
    Queue quey; // creates the queue

    //constructor and initializes the queue and the stack
    public Palindrome()
        {
        staky = new Stack<char>();
        quey = new Queue();
    }
    //push or insert a char into the stack, FIFO
    public void pushCharacter(char ch){
        staky.Push(ch);
    }
    
    //enqueue or insert a char into the queue
    public void enqueueCharacter(char ch){
        quey.Enqueue(ch);
    }
    //Pop or remove a char from the stack First in, first out.
    public char popCharacter(){
        return staky.Pop();
    }
    //dequeue or remove a char from the queue
    public char dequeueCharacter(){
        return (char)quey.Dequeue();
    }
}
