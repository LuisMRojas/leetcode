# 49. Group Anagrams

**Difficulty:** Medium · **Language:** C# · [View on LeetCode](https://leetcode.com/problems/group-anagrams/)

## Problem

Given an array of strings `strs`, group the anagrams together. The answer can be returned in any order.

## Approach

Sorted word as key: two words are anagrams exactly when their letters, once sorted, are the same (`"eat"`, `"tea"` and `"ate"` all become `"aet"`).

1. For each word, compute its key with `SortWord` (sort its characters).
2. Use a `Dictionary<string, List<string>>` to collect every word under its key, creating the list the first time a key appears (`TryGetValue`).
3. Return all the lists in the dictionary.

The commented-out code in `Solution.cs` is an earlier draft, kept for reference.

## Complexity

With `n` words of maximum length `k`:

- **Time:** O(n · k log k) — sorting each word
- **Space:** O(n · k) — the dictionary stores every word
