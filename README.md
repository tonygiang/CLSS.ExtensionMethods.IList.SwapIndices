# CLSS.ExtensionMethods.IList.SwapIndices

### Problem

Swapping indices in a list is a common use case that usually requires 3 lines of code:

```
var tempVal = collection[1];
collection[1] = collection[4];
collection[4] = tempVal;
```

### Solution

`SwapIndices` is an extension method that reduces this common operation to 1 line of code:

```
using CLSS;

collection.SwapIndices(1, 4);
```

`SwapIndices` returns the source `Ilist<T>` to be friendly to a functional-style call chain. The return type will be determined by the invocation syntax of `SwapIndices`. With an implicit type invocation, it returns an `IList<T>`. With an explicit type invocation, it returns the original collection type.

```
using CLSS;

var numbers = new int[] { 0, 1, 2, 3, 4 };
numbers.SwapIndices(1, 4); // returns IList<int>
numbers.SwapIndices<int[], int>(1, 4); // returns int[];
```

**Note**: `SwapIndices` works on all types implementing the [`IList<T>`](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1) interface, *including raw C# array*.

##### This package is a part of the [C# Language Syntactic Sugar suite](https://github.com/tonygiang/CLSS).