# Sorts
This repo like list of sorts which created on c#. \
I collect here all sorts which I know. Here only code and you need to re-write some of them by yourself. If you want to know something about sort - use Google ^_^ \
Sorts:
- BubbleSort 
- BucketSort
- CocktailSort
- CombSort
- GnomeSort
- HeapSort
- InserationSort
- MergeSort
- SelectionSort
- ShellSort
- TimSort

I need your help in:
- find more and add it
- improve existing 
- find mistakes 

sorry for my bad english🇷🇺
# Tests
> int array length = 100000 random elements \
> Medium run job \
> Intel Core i5-1038NG7 CPU 2.00GHz, 1 CPU, 8 logical and 4 physical cores \

The fattest - Bucket sort \
The longest - Gnome sort \
The slowest - Selection sort \
The best - Merge sort !

|         Method |            Mean |         Error |        StdDev |       StdErr |             Min |              Q1 |          Median |              Q3 |             Max |       Op/s |     Gen 0 |    Gen 1 |    Gen 2 |   Allocated |
|--------------- |----------------:|--------------:|--------------:|-------------:|----------------:|----------------:|----------------:|----------------:|----------------:|-----------:|----------:|---------:|---------:|------------:|
|     BubbleSort | 11,345,815.5 μs | 101,349.97 μs | 145,353.09 μs | 27,469.15 μs | 11,201,479.5 μs | 11,218,249.9 μs | 11,283,170.6 μs | 11,483,296.8 μs | 11,665,291.5 μs |     0.0881 |         - |        - |        - |     9,016 B |
|     BucketSort |     13,719.5 μs |     768.24 μs |   1,149.87 μs |    209.94 μs |     12,007.8 μs |     12,286.3 μs |     14,238.2 μs |     14,537.9 μs |     15,527.8 μs |    72.8891 | 1109.3750 | 515.6250 | 242.1875 | 6,308,751 B |
|   CocktailSort |     39,997.6 μs |     233.61 μs |     349.66 μs |     63.84 μs |     39,369.1 μs |     39,745.5 μs |     39,964.8 μs |     40,285.7 μs |     40,703.6 μs |    25.0015 |         - |        - |        - |     9,898 B |
|       CombSort |      7,060.6 μs |      20.81 μs |      30.51 μs |      5.67 μs |      7,015.6 μs |      7,036.1 μs |      7,062.0 μs |      7,083.7 μs |      7,125.5 μs |   141.6308 |         - |        - |        - |       283 B |
|      GnomeSort | 28,715,740.8 μs | 290,689.30 μs | 426,088.60 μs | 79,122.67 μs | 28,085,831.8 μs | 28,481,190.0 μs | 28,666,243.4 μs | 28,913,378.7 μs | 29,989,764.2 μs |     0.0348 |         - |        - |        - |     9,008 B |
|       HeapSort |     10,647.3 μs |       5.24 μs |       7.35 μs |      1.41 μs |     10,634.2 μs |     10,642.4 μs |     10,646.5 μs |     10,653.1 μs |     10,665.6 μs |    93.9202 |         - |        - |        - |       281 B |
| InserationSort |      8,066.7 μs |     469.27 μs |     702.38 μs |    128.24 μs |      6,812.4 μs |      7,580.6 μs |      8,075.3 μs |      8,713.5 μs |      9,021.3 μs |   123.9666 |         - |        - |        - |       284 B |
|      MergeSort |        420.1 μs |       2.19 μs |       3.27 μs |      0.60 μs |        414.8 μs |        417.4 μs |        420.4 μs |        422.6 μs |        426.6 μs | 2,380.5153 |  124.5117 | 124.5117 | 124.5117 |   400,372 B |
|  SelectionSort |  4,204,748.8 μs |   2,093.27 μs |   3,068.29 μs |    569.77 μs |  4,200,585.4 μs |  4,202,533.9 μs |  4,204,612.0 μs |  4,206,507.4 μs |  4,211,991.3 μs |     0.2378 |         - |        - |        - |     8,800 B |
|      ShellSort |      5,038.9 μs |      83.81 μs |     125.45 μs |     22.90 μs |      4,836.8 μs |      4,952.1 μs |      5,007.6 μs |      5,153.0 μs |      5,251.9 μs |   198.4545 |         - |        - |        - |       282 B |

