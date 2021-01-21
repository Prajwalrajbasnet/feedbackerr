using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback_System
{
    class QuickSort
    {
        /**
         * Generic implementation of Quicksort to sort objects of Feedback class for provided index of criteria.
         */
        private int partition(List<Feedback> list, int low, int high, int criteriaIndex)
        {
            // Set last element of array as pivot initially
            Feedback pivot = list[high];
            int pointer = low;

            for (var i = low; i < high; i++)
            {
                if (list[i].Ratings[criteriaIndex] <= pivot.Ratings[criteriaIndex])
                {
                    // Swap the pointer and the item smaller or equal to pivot 
                    Feedback temp = list[pointer];
                    list[pointer] = list[i];
                    list[i] = temp;

                    pointer++;
                }
            }

            // At last put pivot at a position with smaller items at left and bigger on right i.e index currently represented by pointer
            Feedback tempVal = list[pointer];
            list[pointer] = list[high];
            list[high] = tempVal;
            return pointer;
        }

        public List<Feedback> Sort(List<Feedback> list, int low, int high, int criteriaIndex)
        {
            if (high > low)
            {
                // Find pivot with smaller items at left and bigger at right
                int pivotIndex = partition(list, low, high, criteriaIndex);

                // Sort items at left of pivot
                Sort(list, low, pivotIndex - 1, criteriaIndex);

                // Sort items at right of pivot
                Sort(list, pivotIndex + 1, high, criteriaIndex);
            }
            return list;
        }
    }
}
