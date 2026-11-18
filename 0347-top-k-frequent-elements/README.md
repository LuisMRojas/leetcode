# 347. Top K Frequent Elements

**Difficulty:** Medium · **Language:** C# · [View on LeetCode](https://leetcode.com/problems/top-k-frequent-elements/)

## Problem

Given an integer array `nums` and an integer `k`, return the `k` most frequent elements, in any order. The answer is guaranteed to be unique.

**Follow-up:** the algorithm's time complexity must be better than O(n log n).

## Approach

### Solution 1 — [`Solution.cs`](Solution.cs) (first version: count + repeated max)

1. Count how many times each number appears with a `Dictionary<int, int>`.
2. Repeat `k` times: find the entry with the highest count (`MaxBy`), add its key to the result, and remove it from the dictionary so the next search finds the next most frequent.

## Complexity

With `n` elements and `u` distinct values:

- **Time:** O(n + k · u) — counting is O(n); each `MaxBy` scans the remaining `u` entries. In the worst case (`k` close to `u`, `u` close to `n`) this is O(n²), so it doesn't meet the follow-up.
- **Space:** O(u) — the dictionary
