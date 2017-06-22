using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string s = Console.ReadLine();
        int count = 0;
        
        //Loop through and see if any upper char and if exist increase count and +1 for first string
        foreach(char ch in s){
            if(Char.IsUpper(ch)){
                count++;
            }
        }
        if(s.Length>0){
            count++
        }
        Console.WriteLine(count);
    }
}
