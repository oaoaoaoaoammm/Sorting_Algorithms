# Sorts
This repo like list of sorts which created on c#. \
I collect here all sorts which I know. Here only code and you need to re-write some of them by yourself. If you want to know something about sort - use Google ^_^ \
Sorts:
- BubbleSort 
- BucketSort
- CocktailSort
- CombSort
- CountingSort
- GnomeSort
- HeapSort
- InserationSort
- MergeSort
- SelectionSort
- ShellSort
- TimSort

# Tests
> int[100000] arr = 1000000 random elements \
> Medium run job \
> Intel Core i5-1038NG7 CPU 2.00GHz, 1 CPU, 8 logical and 4 physical cores \

The fattest - Tim sort 🗑 \
The slowest - Gnome sort ♾ \
The fastest  - Cocktail sort 🍸 \
The best - Merge sort ⚠️
```
|         Method |            Mean |         Error |        StdDev |        StdErr |             Min |              Q1 |          Median |              Q3 |             Max |       Op/s | LogicalGroup |     Gen 0 |    Gen 1 |    Gen 2 |   Allocated |
|--------------- |----------------:|--------------:|--------------:|--------------:|----------------:|----------------:|----------------:|----------------:|----------------:|-----------:|------------- |----------:|---------:|---------:|------------:|
|     BubbleSort | 14,971,822.8 μs | 360,844.26 μs | 517,512.05 μs |  97,800.58 μs | 14,100,830.6 μs | 14,543,081.6 μs | 14,910,650.6 μs | 15,421,575.8 μs | 15,942,717.0 μs |     0.0668 |            * |         - |        - |        - |     9,056 B |
|     BucketSort |      1,032.9 μs |      43.88 μs |      64.33 μs |      11.94 μs |        782.3 μs |      1,034.2 μs |      1,044.8 μs |      1,061.5 μs |      1,095.8 μs |   968.1041 |            * |  814.4531 | 778.3203 | 221.6797 | 1,049,080 B |
|   CocktailSort |        158.3 μs |       4.37 μs |       6.27 μs |       1.18 μs |        151.9 μs |        152.9 μs |        155.4 μs |        162.9 μs |        170.8 μs | 6,316.2368 |            * |         - |        - |        - |        96 B |
|       CombSort |      3,595.2 μs |      51.91 μs |      74.44 μs |      14.07 μs |      3,473.0 μs |      3,551.9 μs |      3,594.0 μs |      3,632.9 μs |      3,787.4 μs |   278.1452 |            * |         - |        - |        - |         1 B |
|   CountingSort |        672.1 μs |       5.75 μs |       8.43 μs |       1.57 μs |        658.8 μs |        664.8 μs |        670.9 μs |        676.1 μs |        691.7 μs | 1,487.9580 |            * |         - |        - |        - |        32 B |
|      GnomeSort | 30,009,358.8 μs | 653,736.05 μs | 978,481.34 μs | 178,645.43 μs | 28,870,611.2 μs | 29,073,429.6 μs | 29,954,913.0 μs | 30,605,222.8 μs | 32,351,330.8 μs |     0.0333 |            * |         - |        - |        - |     8,936 B |
|       HeapSort |        705.0 μs |      17.88 μs |      26.21 μs |       4.87 μs |        670.2 μs |        691.3 μs |        697.2 μs |        716.0 μs |        780.7 μs | 1,418.4834 |            * |         - |        - |        - |           - |
| InserationSort |        191.5 μs |       1.58 μs |       2.31 μs |       0.43 μs |        186.2 μs |        190.2 μs |        191.6 μs |        193.0 μs |        195.7 μs | 5,223.0100 |            * |         - |        - |        - |           - |
|      MergeSort |        445.7 μs |      11.76 μs |      17.24 μs |       3.20 μs |        414.9 μs |        432.5 μs |        446.3 μs |        452.3 μs |        491.4 μs | 2,243.5916 |            * |  395.9961 | 368.6523 | 104.9805 |   400,090 B |
|  SelectionSort |  4,475,447.8 μs |  73,970.44 μs | 110,715.47 μs |  20,213.79 μs |  4,263,458.8 μs |  4,402,513.5 μs |  4,455,755.8 μs |  4,534,904.0 μs |  4,743,141.9 μs |     0.2234 |            * |         - |        - |        - |     8,896 B |
|      ShellSort |        349.4 μs |       2.84 μs |       4.07 μs |       0.77 μs |        343.3 μs |        346.0 μs |        349.5 μs |        352.2 μs |        357.1 μs | 2,861.7946 |            * |         - |        - |        - |           - |
|        TimSort |      5,987.5 μs |      72.55 μs |     108.58 μs |      19.82 μs |      5,765.4 μs |      5,930.7 μs |      5,990.8 μs |      6,066.0 μs |      6,164.9 μs |   167.0149 |            * | 1312.5000 | 242.1875 | 242.1875 | 4,922,004 B |
```

# Wikipedia's table

[Here](https://en.wikipedia.org/wiki/Sorting_algorithm) you can find information and O(n) notations about sorts. I'm very lazy to search code and add them here, but you can help this project in 5 steps ^_^ 
1) write/copy code 
2) open Issue 
3) add sort name in title of issue 
4) submit new issue 
5) chill and wait when I'll check and add your code(if u want, I can mention you)
