class MergeSorter
{
    public void Sort(int[] arr, int left, int right)
    {
        //when the function is called for the first time, left = 0 and right = the length of the array - 1, so in the beginning, the array is always divided into two parts
        if (left < right)
        {
            int mid = (left + right) / 2; //calculating the middle index of the array

            Sort(arr, left, mid); //recursively sort the left half of the array
            Sort(arr, mid + 1, right); //recursively sort the right half of the array

            Merge(arr, left, mid, right);
        }

    }

    public void Merge(int[] arr, int left, int mid, int right){
         int i, j, k;
        int sizeLeft = mid - left + 1; //the size of the left subarray
        int sizeRight = right - mid; // the size of the right subarray

        int[] tempLeft = new int[sizeLeft]; //temporary array for the left subarray
        int[] temptRight = new int[sizeRight]; //temporary array for the right subarray

        Array.Copy(arr, left, tempLeft, 0, sizeLeft);
        Array.Copy(arr, mid + 1, temptRight, 0, sizeRight);

        i = 0; // index for calculating for left array
        j = 0; //index for calculating the right array
        k = left; //the index of the initial array


        while (i < sizeLeft && j < sizeRight)
        {
            if (tempLeft[i] <= temptRight[j])
            { //comparing each element on each index, 
                arr[k] = tempLeft[i]; //if element from left array is smaller, write it to the initial array
                i++;
            }
            else
            {
                arr[k] = temptRight[j];
                j++;
            }

            k++;
        }

        while (i < sizeLeft)
        { //if there are any elements remaining in the left subarray, copy them to the initial array
            arr[k] = tempLeft[i];
            i++;
            k++;
        }

        while (j < sizeRight)
        { //if there are any elements remaining in the right subarray, copy them to the initial array
            arr[k] = temptRight[j];
            j++;
            k++;
        }
    }
}