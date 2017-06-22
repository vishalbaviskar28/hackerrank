using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static string super_reduced_string(string s){
        // Complete this function
        var stack = new Stack<char>();
        //Look through and see if any pair of adjacent letters with same value
        for(int i = 0; i < s.Length; i++){
            if(stack.Count > 0 && stack.Peek() == s[i]){
                stack.Pop();
            }else{
                stack.Push(s[i]);
            }
        }
        //Print result
        if(stack.Count == 0){
            return "Empty String";
        }else{
            char[] result = stack.ToArray();
            Array.Reverse(result);
            return new string(result);           
        }
    }

    static void Main(String[] args) {
        string s = Console.ReadLine();
        string result = super_reduced_string(s);
        Console.WriteLine(result);
    }
}
