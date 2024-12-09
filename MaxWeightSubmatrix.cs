namespace RGR
{
    public static class MaxWeightSubmatrix
    {
        // O(rows^2 * cols^2)
        public static int FindMaxWeigthBruteForce(int[][] array,
                                                  out int maxRecLeft,
                                                  out int maxRecRight,
                                                  out int maxRecTop,
                                                  out int maxRecBottom)
        {
            int[][] _array = (int[][])array.Clone();

            maxRecLeft = 0; maxRecRight = 0; maxRecTop = 0; maxRecBottom = 0;

            int rows = _array.Length;
            int columns = _array[0].Length;

            int maxSum = int.MinValue;

            for (int topRow = 0; topRow < rows; topRow++)
            {
                for (int leftColumn = 0; leftColumn < columns; leftColumn++)
                {
                    for (int bottomRow = topRow; bottomRow < rows; bottomRow++)
                    {
                        for (int rightColumn = leftColumn; rightColumn < columns; rightColumn++)
                        {
                            // найти сумму чисел подмассива
                            int sum = FindArraySum(
                                GetSubArray(_array, topRow, bottomRow, leftColumn, rightColumn)
                                );

                            if (sum > maxSum)
                            {
                                maxSum = sum;

                                maxRecLeft = leftColumn;
                                maxRecRight = rightColumn;
                                maxRecTop = topRow;
                                maxRecBottom = bottomRow;
                            }
                        }
                    }
                }
            }

            return maxSum;
        }

        // O(rows * cols^2)
        public static int FindMaxWeigthKadane(int[][] array,
                                              out int maxRecLeft,
                                              out int maxRecRight,
                                              out int maxRecTop,
                                              out int maxRecBottom)
        {
            int[][] _array = (int[][])array.Clone();

            maxRecLeft = 0; maxRecRight = 0; maxRecTop = 0; maxRecBottom = 0;

            int rows = _array.Length;
            int columns = _array[0].Length;

            int maxSum = int.MinValue;

            // сумма строк у рассматриваемых столбцов
            int[] rowSums = new int[rows];

            // левая и правая рассматриваемая граница
            for (int left = 0; left < columns; left++)
            {
                for (int right = left; right < columns; right++)
                {
                    // получаем массив, отделенный левой и правой границей
                    int[][] currentArray = GetSubArray(_array, 0, rows - 1, left, right);

                    // вычисляем rowSums
                    for (int i = 0; i < rows; i++)
                    {
                        rowSums[i] = currentArray[i].Sum();
                    }

                    // передаем rowSums в алгоритм Kadane, находим макс. сумму в массиве и индексы
                    int maxCurrentSum = FindMaxWeigthKadane(rowSums, out int topRow, out int bottomRow);

                    if (maxCurrentSum > maxSum)
                    {
                        maxSum = maxCurrentSum;

                        maxRecLeft = left;
                        maxRecRight = right; 
                        maxRecTop = topRow;
                        maxRecBottom = bottomRow;
                    }
                }
            }

            return maxSum;
        }

        private static int FindMaxWeigthKadane(int[] array, out int start, out int end)
        {
            int maxCurrent = array[0], maxGlobal = array[0];
            int tempStart = 0;
            start = 0;
            end = 0;

            for (int i = 1; i < array.Length; i++)
            {
                // значение массива больше, чем предыдущие, начинаем новый подмассив
                if (array[i] > maxCurrent + array[i])
                {
                    maxCurrent = array[i];
                    tempStart = i;
                }
                else
                {
                    maxCurrent += array[i];
                }

                // обновляем максимальную сумму и индексы
                if (maxCurrent > maxGlobal)
                {
                    maxGlobal = maxCurrent;
                    start = tempStart;
                    end = i;
                }
            }

            return maxGlobal;
        }

        private static int FindArraySum(int[][] array)
        {
            int sum = 0;

            foreach (var row in array)
                sum += row.Sum();

            return sum;
        }

        private static int[][] GetSubArray(int[][] array, int topRow, int bottomRow, int leftColumn, int rightColumn)
        {
            int[][] subArray = new int[bottomRow - topRow + 1][];

            for (int i = topRow; i < bottomRow + 1; i++)
            {
                subArray[i - topRow] = array[i].Skip(leftColumn).Take(rightColumn - leftColumn + 1).ToArray();
            }

            return subArray;
        }
    }
}
