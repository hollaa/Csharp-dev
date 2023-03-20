class BubbleSorter
{
    public void Sort(int[] unsortedArray)
    {
        int length = unsortedArray.Length;
        int position;
        bool swapped = true; //need to check if the number has been swapped

        //the loop goes to the length of the array - 1 because we are comparing to the number after the current number -> no need to go to the last position as there is no number after it
        for (int i = 0; i < length - 1; i++)
        {
            swapped = false;
            position = length - i - 1; //adding i to not go to the last element as that has already been moved to the right

            for (int j = 0; j < position; j++)
            {
                if (unsortedArray[j] > unsortedArray[j + 1])
                { //if current element is greater than the next one, swap it forward
                    int temp = unsortedArray[j];
                    unsortedArray[j] = unsortedArray[j + 1];
                    unsortedArray[j + 1] = temp;
                    swapped = true;
                }
            }

            //if no swap was made during the iteration, the array is already sorted
            if (swapped == false)
                break;
        }
    }
}