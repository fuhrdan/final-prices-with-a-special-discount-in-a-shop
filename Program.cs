//*****************************************************************************
//** 1475. Final Prices With a Special Discount in a Shop           leetcode **
//*****************************************************************************

/**
 * Note: The returned array must be malloced, assume caller calls free().
 */
int* finalPrices(int* prices, int pricesSize, int* returnSize) {
    int* stack = (int*)malloc(pricesSize * sizeof(int));
    int top = -1; // Top of the stack
    
    for (int i = 0; i < pricesSize; i++) 
    {
        while (top >= 0 && prices[stack[top]] >= prices[i]) 
        {
            prices[stack[top]] -= prices[i];
            top--;
        }
        stack[++top] = i;
    }
    
    free(stack); 
    *returnSize = pricesSize;
    return prices;
}
