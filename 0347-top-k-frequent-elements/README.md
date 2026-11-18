# 347. Top K Frequent Elements

**Difficulty:** Medium · **Language:** C# · [View on LeetCode](https://leetcode.com/problems/top-k-frequent-elements/)

## Problem

Given an integer array `nums` and an integer `k`, return the `k` most frequent elements, in any order. The answer is guaranteed to be unique.

**Follow-up:** the algorithm's time complexity must be better than O(n log n).

## Approach

### Solution 1 — [`Solution.cs`](Solution.cs) (first version: count + repeated max)

1. Count how many times each number appears with a `Dictionary<int, int>`.
2. Repeat `k` times: find the entry with the highest count (`MaxBy`), add its key to the result, and remove it from the dictionary so the next search finds the next most frequent.

### Solution 2 — [`Solution2.cs`](Solution2.cs) (count + LINQ sort)

1. Count occurrences with a `Dictionary<int, int>`. `TryGetValue` leaves `cant` at `0` when the number isn't there yet, so a single line `counts[num] = cant + 1` handles both cases.
2. Sort the entries by count, descending (`OrderByDescending`), take the first `k` (`Take`), and keep only the numbers (`Select(p => p.Key)`).

## Complexity

With `n` elements and `u` distinct values:

| | Time | Space |
|---|---|---|
| Solution 1 | O(n + k · u) — each `MaxBy` scans the remaining entries; O(n²) in the worst case | O(u) |
| Solution 2 | O(n + u log u) — counting plus sorting the distinct values; O(n log n) in the worst case | O(u) |

Solution 2 is shorter and much faster in the worst case, but sorting still makes it O(n log n) when most values are distinct, so the follow-up (better than O(n log n)) would need a bucket sort or a size-`k` heap.
