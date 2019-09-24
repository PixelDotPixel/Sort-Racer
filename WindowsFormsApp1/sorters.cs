using System;
using System.Net;
using System.Diagnostics;

namespace Sorts
{
    class Bubble{
        public static int[] BubbleSort(int[] toSort){
            int tempSpace, arraySize, index;
            arraySize = toSort.Length;
            for(int i = 0; i < arraySize; i++){
                tempSpace = toSort[i];
                index = i;
                for(int j = i + 1; j < arraySize; j++){
                    if(tempSpace > toSort[j]){
                        index = j;
                        tempSpace = toSort[j];
                    }
                }
                toSort[index] = toSort[i];
                toSort[i] = tempSpace; 
            }
            return toSort;
        }

    }

    class Insertion{
        public static int[] InsertionSort(int[] toSort){
            int tempSpace, arraySize, index;
            arraySize = toSort.Length;
            for(int i = 0; i < arraySize; i++){
                index = i;
                while(index > 0 && toSort[index -1] > toSort[index]){
                    tempSpace = toSort[index];
                    toSort[index] = toSort[index - 1];
                    toSort[index - 1] = tempSpace;
                    index = index - 1;
                }
            }
            return toSort;
        }
        
    }
    
    class Quick{
        public static int[] QuickSort(int[] toSort){
            int lowIndex = 0; int highIndex = toSort.Length;
            PartitionGate(ref toSort, lowIndex, highIndex);
            return toSort;
        }
        
        private static void PartitionGate(ref int[] toSort, int lowIndex, int highIndex){
            if(lowIndex < highIndex){
                int pivot = Partition(ref toSort, lowIndex, highIndex);
                PartitionGate(ref toSort, lowIndex, pivot);
                PartitionGate(ref toSort, pivot + 1, highIndex);
            }
        }

        private static int Partition(ref int[] toSort, int lowIndex, int highIndex){
            int pivot = toSort[lowIndex];
            int leftGuard = lowIndex;
            for(int i = lowIndex + 1; i < highIndex; i++){
                if(toSort[i] < pivot){
                    Common.Tools.Swap(i, leftGuard, ref toSort);
                    leftGuard = leftGuard + 1;
                }
            }
            toSort[leftGuard] = pivot;
            return leftGuard;
        }
    }

    class Merge{
        // public static int[] mergeSort(int[] toSort){

        // }
    }

    class Heap{
        // public static int[] heapSort(int[] toSort){

        // }
    }
}

namespace Common
{
    class Tools{
        public static void Swap(int indexA, int indexB, ref int[] toSwap){
            int temp = toSwap[indexA];
            toSwap[indexA] = toSwap[indexB];
            toSwap[indexB] = temp;
        }

        public static int[] CreateData(int modifier){
            Random r = new Random(Guid.NewGuid().GetHashCode());
            int size = // r.Next() % modifier + 50000;
            modifier;
            int[] toReturn = new int[size];
            for(int i = 0; i < size; i++){
                toReturn[i] = r.Next() % 100;
            }
            return toReturn;
        }
    }

    class Timers{
        public static double Timer_Bubble(int modifier){
            int[] toSort = Tools.CreateData(modifier);
            TimeSpan time_Elapsed;
            Double dblTime;
            Stopwatch timer = new Stopwatch();
            timer.Start();
            Sorts.Bubble.BubbleSort(toSort);
            timer.Stop();
            time_Elapsed = timer.Elapsed;
            dblTime = time_Elapsed.TotalMilliseconds;
            //Console.WriteLine("Time to complete: {0}", dblTime/1000);
            return dblTime/1000;                                     //Returns by factor of 1000 for seconds
        }
//Timer for insertion sort, returns dblTIme
        public static double Timer_Insertion(int modifier){
            int[] toSort = Tools.CreateData(modifier);
            TimeSpan time_Elapsed;
            Double dblTime;
            Stopwatch timer = new Stopwatch();
            timer.Start();
            Sorts.Insertion.InsertionSort(toSort);
            timer.Stop();
            time_Elapsed = timer.Elapsed;
            dblTime = time_Elapsed.TotalMilliseconds;
            //Console.WriteLine("Time to complete: {0}", dblTime/1000);            
            return dblTime/1000;
        }

        public static double Timer_Quick(int modifier){
            int[] toSort = Tools.CreateData(modifier);
            TimeSpan time_Elapsed;
            Double dblTime;
            Stopwatch timer = new Stopwatch();
            timer.Start();
            Sorts.Quick.QuickSort(toSort);
            timer.Stop();
            time_Elapsed = timer.Elapsed;
            dblTime = time_Elapsed.TotalMilliseconds;
            //Console.WriteLine("Time to complete: {0}", dblTime/1000);            
            return dblTime/1000;
            
        }

        // public static double Timer_Merge(int modifier){
        //     // int[] toSort = Tools.createData(modifier);
        //     // TimeSpan time_Elapsed;
        //     // Double dblTime;
        //     // Stopwatch timer = new Stopwatch();
        //     // timer.Start();
        //     // Sorts.Merge.mergeSort(toSort);
        //     // timer.Stop();
        //     // time_Elapsed = stopWatch.Elapsed;
        //     // dblTime = time_Elapsed.TotalSeconds;
        //     // return dblTime;
        // }

        // public static double Timer_Heap(int modifier){
        //     // int[] toSort = Tools.createData(modifier);          
        //     // TimeSpan time_Elapsed;
        //     // Double dblTime;            
        //     // Stopwatch timer = new Stopwatch();
        //     // timer.Start();
        //     // Sorts.Heap.heapSort(toSort);
        //     // timer.Stop();
        //     // time_Elapsed = stopWatch.Elapsed;
        //     // dblTime = time_Elapsed.TotalSeconds;
        //     // return dblTime;
        // }
    }
}

namespace Program
{
    class Controller{
        private static void printer(int[] toPrint){
            int size = toPrint.Length;
            for(int i = 0; i < size; i++){
                Console.WriteLine("Index {0}: {1}", i, toPrint[i]);
            }
        }

        private static void tester(int[] toTest){
            int size = toTest.Length;
            for(int i = 1; i < size; i++){
                if(toTest[i] < toTest[i - 1]){
                    Console.WriteLine("Not Properly Sorted");
                    System.Windows.Forms.Application.Exit();
                }
            }
            Console.WriteLine("Properly Sorted");
        }

//Used for testing individual timers
        //static void Main(){
        //     int[] test = createData();
        //     double time;
        //     Console.WriteLine("---Unsorted---");
        //     time = Common.timers.timer_Bubble(test);
        //     Console.WriteLine("---Sorted---");
        //     Console.WriteLine("Time to complete: {0}", time/1000);
        //     tester(test);
        //}
    }

}
