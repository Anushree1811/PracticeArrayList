using System;
using System.Collections;



public class Programs {

    public static void Main(string[] args) {

        var arrlist1 = new ArrayList();

        var arrlist2 = new ArrayList()
        { 1,"steve", " ", true, 4.5,null };

        int[] arr = { 100, 200, 300, 400, 500 };


        arrlist1.AddRange(arrlist2);
        arrlist1.AddRange(arr);

        for (int i = 0; i < arrlist1.Count; i++) { 
        
            Console.WriteLine(arrlist1[i]);
        }
  
    
    }

}