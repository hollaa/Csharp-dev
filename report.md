# Assignment 1 in C# Development
## _Implementation of Bubble Sort and Merge Sort in C# using Generics_

This document is created for the purposes of explanation of my second implementation of Bubble sort of Merge sort using the programming language C#.

The following changes were made to the initial version of this code:
- The two sorting functions were organized to two classes
- The classes inherit from one interface
- Generics were introduced so the program supports now also sorting of the data type double and string

### Bubble sort

Bubble sort as an intuitive simple algorithm that works by swapping the adjacent numbers in the list if they are in the wrong order. The algorithm passes through the whole list multiple times to compare and swap the elements until all the numbers are in the right order.

The algorithm follows these steps:
1. Compare the first element with the next one (elements on indexed 0 and 1), if the first one is greater than the second one, swap them
2. Move to the next pair of elements, review them and swap if necessary. This continues until the end of the list
3. Repeat steps 1. and 2. until all the elements are in the right order, so no other elements need to be swapper (the smallest number is in the beginning and the biggest one is in the end of the list)

#### My Implementation

The list to be sorted is given by the user by the command
```
dotnet run sort -Bubble -double "2.1, 0.3, 44.5, 55, 10.8, 40"
```

1. The class "BubbleSort" implements the "ISortAlgorithm" interface and provides an implementation for the "Sort" method for bubble sort
2. The type parameter "T" is used to specify that the type T must implement the "IComparable<T>" interface, which allows comparison of objects of type T.
3. The "Sort" method takes an array of type T as input and returns an array of type T as output.
4. A boolean variable "swapped" is initialized to true, which will be used to check if an element has been swapped or not during the sorting process.
5. The first loop iterates from the beginning of the array to the second-to-last element.
6. The second loop iterates from the beginning of the array to the element that is "array.Length - i - 2" positions from the end of the array.
7. Inside the second loop, the program checks if the current element is greater than the next element using the "CompareTo" method of the "IComparable<T>" interface.
8. If the current element is greater than the next element, the two elements are swapped using a temporary variable "temp".
9. The "swapped" variable is set to true to indicate that at least one element was swapped during this iteration.
10. If no elements were swapped during this iteration, the "swapped" variable will still be false, and the program breaks out of the first loop.
11. The sorted array is returned by the "Sort" method.

The output is a sorted list of elements in this format:
```
This is your sorted array: 
0.3 2.1 10.8 40 44.5 55 
```

### Merge sort
Merge sort is a sorting algorithm that uses a divide-and-conquer approach to sort an array of elements. It works by splitting the input array into two halves, sorting each half recursively, and then merging the two sorted halves back together to create a fully sorted array. Merge Sort has a time complexity of O(n*log(n)), which makes it efficient for sorting large arrays.

1. Divide the unsorted array into two halves, by finding the middle index of the array.
2. Recursively sort the left half of the array by applying the merge sort algorithm to it.
3. Recursively sort the right half of the array pplying the merge sort algorithm to it.
4. Merge the sorted halves back together to obtain the final sorted array.

#### My Implementation

The list to be sorted is given by the user by the command
```
dotnet run sort -Merge -string " cat, ananas, leg, chair, laptop, dog" 
```

1. The class MergeSort which implements the ISortAlgorithm interface 
2. The type parameter "T" is used to specify that the type T must implement the "IComparable<T>" interface, which allows comparison of objects of type T.
3. The "Sort" method takes an array of type T as input and returns an array of type T as output.
4. Check if the length of the array is less than or equal to 1. If so, return the array as it is already sorted.
5. Calculate the middle index of the array.
6. Create two new arrays called leftArray and rightArray with lengths of mid and array.Length - mid respectively.
7. Copy the first half of the original array into the left array and the second half into the right array.
8. Recursively call the Sort method on the left and right arrays.
9. Create a new array called mergedArray with a length equal to the length of the original array.
10. Compare the elements in the left and right arrays, and place them in the merged array in sorted order.
11. If there are remaining elements in the left array, copy them into the merged array.
12. If there are remaining elements in the right array, copy them into the merged array.
13. Return the mergedArray as the sorted array.

The output is a sorted list of numbers in this format:
```
This is your sorted array: 
This is your sorted array: 
 ananas  cat  chair  dog  laptop  leg 
```