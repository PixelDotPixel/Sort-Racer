using System;
using System.Net;

namespace sorts
{
    class bubble{
        public static int[] bubbleSort(int[] toSort){
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

    class insertion{
        public static int[] insertionSort(int[] toSort){
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
        public static int[] quickSort(int[] toSort){
            int lowIndex = 0; int highIndex = toSort.Length;
            partitionGate(ref toSort, lowIndex, highIndex);
            return toSort;
        }
        
        private static void partitionGate(ref int[] toSort, int lowIndex, int highIndex){
            if(lowIndex < highIndex){
                int pivot = partition(ref toSort, lowIndex, highIndex);
                partitionGate(ref toSort, lowIndex, pivot);
                partitionGate(ref toSort, pivot + 1, highIndex);
            }
        }

        private static int partition(ref int[] toSort, int lowIndex, int highIndex){
            int pivot = toSort[lowIndex];
            int leftGuard = lowIndex;
            for(int i = lowIndex + 1; i < highIndex; i++){
                if(toSort[i] < pivot){
                    Common.tools.swap(i, leftGuard, ref toSort);
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
    class tools{
        public static void swap(int indexA, int indexB, ref int[] toSwap){
            int temp = toSwap[indexA];
            toSwap[indexA] = toSwap[indexB];
            toSwap[indexB] = temp;
        }
    }
}

namespace Program
{
    class Controller{
        public static void printer(int[] toPrint){
            int size = toPrint.Length;
            for(int i = 0; i < size; i++){
                Console.WriteLine("Index {0}: {1}", i, toPrint[i]);
            }
        }

        public static void tester(int[] toTest){
            int size = toTest.Length;
            for(int i = 1; i < size; i++){
                if(toTest[i] < toTest[i - 1]){
                    Console.WriteLine("Not Properly Sorted");
                    System.Windows.Forms.Application.Exit();
                }
            }
            Console.WriteLine("Properly Sorted");
        }

        public static int[] createData(){
            Random r = new Random(Guid.NewGuid().GetHashCode());
            int size = r.Next() % 49 + 1;
            int[] toReturn = new int[size];
            for(int i = 0; i < size; i++){
                toReturn[i] = r.Next() % 100;
            }
            return toReturn;
        }

        static void Main(){
            int[] test = createData();
            Console.WriteLine("---Unsorted---");
            printer(test);
            test = sorts.Quick.quickSort(test);
            Console.WriteLine("---Sorted---");
            printer(test);
            tester(test);
        }
    }

}
