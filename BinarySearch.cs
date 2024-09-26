using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithmNet
{
    internal class BinarySearch
    {
        public static int Perform(double searchValue, List<double> listToSearch)
        {
            int left = 0;
            int right = listToSearch.Count - 1;

            while(left <= right)
            {
                int mid = (left + right) / 2;

                if (listToSearch[mid] == searchValue)
                {
                    return mid; //Finds target index at mid
                }
                else if (listToSearch[mid] < searchValue)
                {
                    left = mid + 1; //Searches in the right half
                }    
                else
                {
                    right = mid - 1; //Search in the right half
                }
            }
            return -1; //Target not found
        }
    }
}
