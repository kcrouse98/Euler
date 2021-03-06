// ConsoleApplication1.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"

bool IsPalindrone(long lNumber)
{
	bool bResult = false;
	long lReverse = 0;
	long lDigit = 0;
	long lRemainder = 0;

	// Start out with the full number;  We are going to build a mirror of it.
	lRemainder = lNumber;

	do
	{
		// Peel off the last number
		lDigit = lRemainder % 10;
		// Build up a new number which is the reverse of the original
		lReverse = (lReverse * 10) + lDigit;
		// Remove the last digit and do it all again.
		lRemainder = lRemainder / 10;
	} while (lRemainder != 0);



	if (lNumber == lReverse)
	{
		//printf("Number: %d ", lNumber);
		//printf("Reverse: %d\n", lReverse);

		// We've got one!
		bResult = true;
	}
	printf(bResult ? "true\n" : "false\n");

	//printf("Number: %d ", lNumber);
	//printf("Reverse: %d\n", lReverse);

	return bResult;
}

int main()
{
	bool bbResult = true;


	bbResult = IsPalindrone(912219);

	if (bbResult == true)
	{
		printf("Palindrone");
	}
	else
	{
		printf("Nope");
	}

    return 0;
}

