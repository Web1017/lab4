﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Javid_Niftaliyev_Lab4_Ex01
{
   public class Stack
    {
        private int top; // location of the top element
   private int[] elements; // array that stores stack elements

   // parameterless constructor creates a stack of the default size
   public Stack(): this(10) // default stack size
   {
      // empty constructor; calls constructor at line 18 to perform init
   }

   // constructor creates a stack of the specified number of elements
   public Stack(int stackSize)
   {
      if (stackSize <= 0) // validate stackSize
      {
         throw new ArgumentException("Stack size must be positive.");
      }

      elements = new int[stackSize]; // create stackSize elements
      top = -1; // stack initially empty
   }

   // push element onto the stack; if unsuccessful,
   // throw FullStackException
   public void Push(int pushValue)
   {
      if (top == elements.Length - 1) // stack is full
      {
            // throw new FullStackException($"Stack is full, cannot push {pushValue}");
            throw new StackOverflowException("Stack is full, cannot push {pushValue}");
        }

      ++top; // increment top
      elements[top] = pushValue; // place pushValue on stack
   }

        // return the top element if not empty,
        // else throw EmptyStackException
        public int Pop()
        {
            if (top == -1) // stack is empty
            {
                //throw new EmptyStackException("Stack is empty, cannot pop");
                throw new Exception("Stack is empty, cannot pop");
            }

            --top; // decrement top
            return elements[top + 1]; // return top value
        }

        public int myPeek()
        {

            return top; // location of the top element
        }
    }
}
