using System;

public class Solution
{
    public static int[] cellCompete(int[] states, int days)
    {
        int[] cell = new int[states.Length];
        for (int i = 0; i < states.Length; i++)
        {
            cell[i] = states[i];
        }
        for (int j = 0; j < days; j++)
        {
            for (int k = 1; k < cell.Length - 1; k++)
            {
                if ((cell[k - 1] == 1 && cell[k + 1] == 1) || (cell[k - 1] == 0 && cell[k + 1] == 0))
                {
                    states[k] = 0;
                }
                else
                {
                   states[k] = 1;
                }
            }
            if (cell[1] == 0)
            {
                states[0] = 0;
            }
            else
            {
                states[0] = 1;
            }
            if (cell[6] == 0)
            {
                states[7] = 0;
            }
            else
            {
                states[7] = 1;
            }
            for (int l = 0; l < states.Length; l++)
            {
                cell[l] = states[l];
            }
        }
        return states;
    }
}
