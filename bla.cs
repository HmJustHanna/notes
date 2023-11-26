using System;
namespace lab3task1 {
	class Program {
		static void Main(string[] args) {

			/*
			*  код ниже я решила применить для того,
			*  чтобы  программа смогла считать введенную
			*  строку чисел разделенных пробелом (а не tab)
			*  
			*  1) считываем строку и разбиваем ее на несколько строк
			*  (разделитель по умолчанию пробел)
			*  
			*  2) применяем метод ConvertAll класса Array,
			*  который применяет второй переданный параметр (в нашем случае int.Parse) для всех строк
			*  
			*  В итоге получаем числа, которые помещаем в массив numbers
			*
			*/
		
			Console.WriteLine($"Enter elements of array (using spaces) :");
			int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			Console.WriteLine($"Choose a sort :\n1 - Shell sort\n2 - Quick sort");
			switch(Convert.ToInt32(Console.ReadLine())) {
				case 1:
					shellSort(numbers, numbers.Length);
					break;
				case 2:
					Console.WriteLine("quick sort here...");
					break;
				default:
					Console.WriteLine("Input error!");
					break;
			}
			
			Console.WriteLine("\nSorted array:");
			for (int i = 0; i < numbers.Length; i++) {
				Console.Write(numbers[i] + " ");
							
			}		
			Console.WriteLine("\n");
		}

		/* для простоты я использую формулу для выбора интервала по Шеллу,
		*  так как формулу предложенную Седжвиком реализовать сложно :(
		*  здесь d - это дистанция от текущего элемента до следующего
		*/		
		public static void shellSort (int[] array, int size) {
			for (int d = size / 2; d > 0; d /= 2) {
				for (int i = d; i < size; i++) {
					for (int j = i - d; j >= 0 && array[j] > array[j + d]; j -= d) {
						int temp = array[j + d];
						array[j + d] = array[j];
						array[j] = temp;
					}
				}
			}
		}

		
/*		public static void quickSort (int[] array) {
			for (int i = 1; i < array.Length; i++) {
				for (int j = i; j > 0 && array[j] < array[j - 1]; j--) {
					int temp = array[j];
					array[j] = array[j - 1];
					array[j - 1] = temp;			
				}
			}
		}
*/
/*
		public static void insertSort (int[] array) {
			for (int i = 1; i < array.Length; i++) {
				for (int j = i; j > 0 && array[j] < array[j - 1]; j--) {
					int temp = array[j];
					array[j] = array[j - 1];
					array[j - 1] = temp;			
				}
			}
		}
*/
		
	}
}











