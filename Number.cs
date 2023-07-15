using System;
namespace Pertemuan_5
{
	public class Number
	{
        float min;
        int min2;

        float max;
        int max2;

        public int findMinimum(int number1, int number2)
        {
            int[] values = { number1, number2 };
            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    min2 = values[i];

                }
                else if (values[i] < min2)
                {
                    min2 = values[i];

                }

            }
            return min2;

        }

        public int findMinimum(int number1, int number2, float number3)
        { 
            float[] values = {number1, number2, number3};
            for(int i = 0; i < 3; i++)
            {


                if (i == 0)
                {
                    min = values[i];

                }
                else if (values[i] < min)
                {
                    min = values[i];
                }
            }
            return (int)min;
        }



        public int findMaximum(int number1, int number2)
        {
            int[] values = { number1, number2 };
            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    max2 = values[i];

                }
                else if (values[i] > min2)
                {
                    max2 = values[i];

                }

            }
            return max2;

        }


        public int findMaximum(int number1, int number2, float number3)
        {
            float[] values = { number1, number2, number3 };
            for (int i = 0; i < 3; i++)
            {


                if (i == 0)
                {
                    max = values[i];

                }
                else if (values[i] > min)
                {
                    max = values[i];
                }
            }
            return (int)max;
        }

    }
}


