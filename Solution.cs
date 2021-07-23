public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
       int n = nums1.Length + nums2.Length;
       int media = (n + 1) / 2; 
       int i = 0, j = 0, ultimoVal = 0;
        
        /*-------------- Concatenado de las matrices------------*/
        for (int k = 0; k < n; ++k ){
            int val = 0; 
            if (i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] < nums2[j]){
                    val = nums1[i++];
                }
                else{
                    val = nums2[j++];
                }
            }
            else if (i == nums1.Length && j < nums2.Length)
            {
                val = nums2[j++];
            }
            else if(i < nums1.Length && j == nums2.Length)
            {
                val = nums1[i++];
            }
        /*-------------------------------------------------- */ 
            
        /*--------------Determinar paridad------------------*/    
            
            if (n % 2 != 0)
            {
                if (k == media - 1)
                {
                    return val;
                }
            }
            else
            {
                if (k == media)
                {
                    return ((double)ultimoVal+val)/2;
                }
            }
         /*------------------------------------------------*/   
            ultimoVal = val;  
        }
        return 0;
    }
