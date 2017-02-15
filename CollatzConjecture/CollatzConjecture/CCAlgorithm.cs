using System;
namespace CollatzConjecture
{
	public class CCAlgorithm
	{
		public int Count = 0;
		public CCAlgorithm(int n)
		{
			while (n > 1) {
				if (n % 2 == 0) {
					n = n / 2;
					Count++;
				}
				if (n % 2 == 1) {
					n = (3 * n) + 1;
					Count++;
				}
			}
		}
	}
}

