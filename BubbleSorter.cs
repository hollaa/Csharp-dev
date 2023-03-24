// Bubblesort class implements the ISortAlgorithm interface and provides the implementation of the Sort method for bubble sort.
// T : IComparable<T> specifies that the type T must implement the IComparable<T> interface, which allows comparison of objects of type T.
public class BubbleSort<T> : ISortAlgorithm<T> where T : IComparable<T>
{
    //sorts an array of type T
    public T[] Sort(T[] array)
    {
        bool swapped = true; //need to check if the element has been swapped
        //the loop goes to the length of the array - 1 because we are comparing to the number after the current number -> no need to go to the last position as there is no number after it
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j].CompareTo(array[j + 1]) > 0)
                {
                    //if current element is greater than the next one, swap it forward
                    T temp = array[j + 1];
                    array[j + 1] = array[j];
                    array[j] = temp;
                    swapped = true;
                }
            }
            //if no swap was made during the iteration, the array is already sorted
            if (swapped == false)
                break;
        }
        return array;
    }
}