# Assignment 1 in C# Development
## _Implementation of Bubble Sort and Merge Sort in C#_

This document is created for the purposes of explanation of my first implementation of Bubble sort of Merge sort using the programming language C#.

### Bubble sort

Bubble sort as an intuitive simple algorithm that works by swapping the adjacent numbers in the list if they are in the wrong order. The algorithm passes through the whole list multiple times to compare and swap the elements until all the numbers are in the right order.

The algorithm follows these steps:
1. Compare the first element with the next one (elements on indexed 0 and 1), if the first one is greater than the second one, swap them
2. Move to the next pair of elements, review them and swap if necessary. This continues until the end of the list
3. Repeat steps 1. and 2. until all the elements are in the right order, so no other elements need to be swapper (the smallest number is in the beginning and the biggest one is in the end of the list)

#### My Implementation

The list to be sorted is given by the user by the command
```
sort -Bubble “1,4,2,3”
```

1. The program checks if the command from the input starts with -Bubble
2. Function ParseInput is called with passing the list of numbers from the input, here is the string divided into array of numbers
3. BubbleSort function is called, the array of numbers is passed
4. In the BubbleSort function, there are two for loops, the first one goes through all the numbers from array index 0 until the length of the array - 1. There is no need to go to the last element as there is no number next to it to compare it to.
5. There is a boolean variable _swapped_ that is letting us know whether the numbers are being swapped, this is set to false in the beginning to assume that the elements are already sorted.
5. For each pair of adjacent elements, if the first element is greater than the second element, the function swaps them and sets swapped to true.
6. After completing the inner loop, if statement checks if the _swapped_ variable is still false, if so, the list is sorted. Otherwise the function repeats the process
7. When the list is sorted, the function breaks and the sorted array is printed out

The output is a sorted list of numbers in this format:
```
This is your sorted array: 
1 2 3 4
```

### Merge sort
Merge sort is a sorting algorithm that uses a divide-and-conquer approach to sort an array of elements. It works by splitting the input array into two halves, sorting each half recursively, and then merging the two sorted halves back together to create a fully sorted array. Merge Sort has a time complexity of O(n*log(n)), which makes it efficient for sorting large arrays.

1. Divide the unsorted array into two halves, by finding the middle index of the array.
2. Recursively sort the left half of the array by applying the merge sort algorithm to it.
3. Recursively sort the right half of the array

#### My Implementation

The list to be sorted is given by the user by the command
```
sort -Merge “1,4,2,3”
```

1. The program checks if the command from the input starts with -Bubble
2. Function ParseInput is called with passing the list of numbers from the input, here is the string divided into array of numbers
3. MergeSort function is called, the parameters are the list of numbers to be sorted, 0 for the the begininning of the array and the length of the array -1 for the end of the array
4. MergeSort function is recurssively dividing the array into halves 
5. The first time the MergeSort function runs, in the if statement it checks if there is more than one element in the array and then calculates the middle index. The other times, it compares the 
6. After the left and right halves are sorted, the Merge function is called to merge the two sorted halves into a single sorted array
7. The Merge function creates two temporary arrays so the left and right array can be copied and held there
8. The first while loop is going through the temporary arrays and compares each element from the same index and writes the smaller one to the initial array. If they are equal, the element from the left array is written first.
9. This loop continues until all the elements in one of the temporary arrays have been copied into the original array
10. The function uses two more while loops to copy any remaining elements in the left or right sub-arrays into the original array
11. Now the sorted array is printed out

The output is a sorted list of numbers in this format:
```
This is your sorted array: 
“1 2 3 4”
```