class Array
{
    public void Learn1DArray()
    {
        byte []  array1 = new byte[10];

        array1[0] = 23;
        array1[1] = 34;

        float[] array2 = new float[] {2.2f,3.3f,4.4f};
        var x = array2.Length;

        char[] array3 = {'A','B','C','D'};






    }

    public void LearnMulArray()
    {
        // 2D array
        int[,] numbers = new int [3,4];
        numbers[0,0] = 2;
        numbers[2,3] = 5;


        decimal[,] numbers2 =  { {2.3m,34.3m} , {23.3m,33.22m} };


    }

    public void LearnJaggedArray()
    {
        short[][]  numbers = new short[4][];
        // jagged array : different number of data in each row
        numbers[0] = new short[] {3,4,5};
        numbers[1] = new short[] {3,4};
        numbers[3] = new short[] {3,4,5,6};

        

    }

}