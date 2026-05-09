public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Creating an array that will store the multiples of the number.  The size of the array is determined by the length parameter.
        double[] multiples = new double[length];

         // Loop through each position in the array
        for (int i = 0; i < length; i++)
        {
            // Multiply the number by (i + 1)
            // i starts at 0, so adding 1 gives us:
            // 1, 2, 3, 4, ...
            multiples[i] = number * (i + 1);
        }

        // Return the completed array
        return multiples; 
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
         // Find the position where the list should be split
        int splitIndex = data.Count - amount;

        // Get the last portion of the list that will move to the front
        List<int> endPart = data.GetRange(splitIndex, amount);

        // Get the beginning portion of the list
        List<int> frontPart = data.GetRange(0, splitIndex);

        // Clear the original list
        data.Clear();

        // Add the rotated sections back into the list
        data.AddRange(endPart);
        data.AddRange(frontPart);
    }
}
