// using System;
// using System.Linq;

// namespace mtech
 
// {
//     class Arrays {
 
//        static void Main(string[] args)  {
            
//             // In C#, all arrays are dynamically allocated.
//             // Array is reference data type...
//             // So new keyword is used to allocate space


//             // Array Declaration methods................

//             // int[] arr;  

//             // arr = new int[5];
//             // arr = new int[Convert.ToInt32(Console.ReadLine())];  // It can use to assign size during runtime

//             // for(int i=1; i<=arr.Length; i++) {
//             //     arr[i-1] = i;
//             // }

//             // arr.Length   <-------- Length is a property of array object..So No curly braces


//             // Array Initialization Methods..............
            
//             // int[] arr = new int[5]; 
//             // int[] arr = new int[5] {1, 2, 3, 4, 5};
//             // int[] arr = {1, 2, 3, 4, 5};

//             // foreach(int items in arr) {
//             //     Console.Write(items + ", ");
//             // }





//             // System.Linq
//             // provide varioud methods to perform on array
            
//             // int[] arr = {4,5,3,9,1};

//             // Min, Max, Avg, Sum, Count

//             // Console.Write("Minimum element: " + arr.Min() + "\n" + "maximum element: " + arr.Max() + "\n" + "Average: " + arr.Average() + "\n" + "Sum of all elements: " + arr.Sum() + "\n" + "Count total elements: " + arr.Count() + "\n");




//             // 2D Array     -- All things same as 1D array

//             // Array Declaration
//             // int[, ] arr;
//             // arr = new int[3,3];


//             // Array Initialization
//             // int[, ] arr = {{1,2,3}, {4,5,6}, {7,8,9}};
//             // int[, ] arr = new int[3,3] {{1,2,3}, {4,5,6}, {7,8,9}};


//             // Traversal

//             // arr.GetLength(0)  <-- 0 is dimension

//             // for(int i=0; i<arr.GetLength(0); i++) {
//             //     for(int j=0; j<arr.GetLength(1); j++) {
//             //         Console.Write(arr[i, j] + " ");
//             //     }
//             //     Console.Write("\n");
//             // }



//             // Jagged Array = C++ style 2D Array

//             // int[][] arr;
//             // arr = new int[3][];

//             // or

//             // int[][] arr = new int[3][];

//             // arr[0] = new int[] {1,2,3,4};
//             // arr[1] = new int[] {5,6};
//             // arr[2] = new int[] {7,8,9};

//             // or

//             // int[ ][ ] arr = {
//             //     new int[ ] {10, 20, 30},
//             //     new int[ ] {11, 22},
//             //     new int[ ] {88, 99}
//             // };

//             // for(int i=0; i<arr.Length; i++) {
//             //     for(int j=0; j<arr[i].Length; j++) {
//             //         Console.Write(arr[i][j] + " ");
//             //     }
//             //     Console.Write("\n");
//             // }

//         }
 
//     }
// }