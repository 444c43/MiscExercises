#Codility results

**overall score:** 100

**analysis**

*example:* 0.060s, OK

*simple:* 0.070s, OK

*extreme_large_numbers:* 0.080s, OK

*extreme_negative_numbers:* 0.080s, OK

*overflow_tests1:* 0.080s, OK

*overflow_tests2:* 0.080s, OK

*one_large:* 0.080s, OK

*sum_0:* 0.080s, OK

*single:* 0.080s, OK

*empty:* 0.080s, OK

*combinations_of_two:* 0.080s, OK

*combinations_of_three:* 0.080s, OK

*small_pyramid:* 0.060s, OK

*large_long_sequence_of_ones:* 0.090s, OK

*large_long_sequence_of_minus_ones:* 0.100s, OK

*medium_pyramid:* 0.090s, OK

*large_pyramid:* 0.130s, OK

##Changes made

    long RightSide = A.Sum();

changed to,

    long RightSide = 0;
    foreach (int element in A)
    {
    	RightSide += element;
    }

according to MSDN, .Sum() carries overhead NULL check for each element. 
Cursory tests suggests .Sum() method calculates individual elements, but 
throws an exception if sum total exceeds element datatype.

if A == {2147483647, 2147483647} then 
> A.Sum()
throws an exception

foreach adds each element to a declared variable, .Sum() calculates prior 
to assignement.

###Final Notes

Though Codility gives the new code:

    using System;
    using System.Linq;
    	class Solution {
    		public int equi(int[] A)
    		{
    			long RightSide = 0;
    			foreach (int element in A)
    			{
    				RightSide += element;
    			}
    			
    			long LeftSide = 0;
    			
    			for (int x = 0; x <= A.Length - 1; x++)
    			{
    				RightSide -= A[x];
    				if (RightSide == LeftSide)
    				{
    					return x;
    				}
    				LeftSide += A[x];
    			}
    			return -1;
    		}
    	}

a 100/100, there are several potential problems:

* too many lines of code in the equi method
* separation of concerns (array sum, LeftSide/RightSide updates, comparison)
* solution works only for passed int arrays, long arrays will not work