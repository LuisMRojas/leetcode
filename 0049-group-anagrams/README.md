# 49. Group Anagrams

**Difficulty:** Medium · **Language:** C# · [View on LeetCode](https://leetcode.com/problems/group-anagrams/)

## Problem

Given an array of strings `strs`, group the anagrams together. The answer can be returned in any order.

## Approach

Sorted word as key: two words are anagrams exactly when their letters, once sorted, are the same (`"eat"`, `"tea"` and `"ate"` all become `"aet"`).

### Solution 1 — [`Solution.cs`](Solution.cs) (single pass)

1. For each word, compute its key with `SortWord` (sort its characters).
2. Use a `Dictionary<string, List<string>>` to collect every word under its key, creating the list the first time a key appears (`TryGetValue`).
3. Return all the lists in the dictionary.

### Solution 2 — [`Solution2.cs`](Solution2.cs) (original, two passes)

1. First pass: collect every distinct sorted key in a `HashSet<string>`.
2. Build a dictionary with an empty list for each key (`ToDictionary`).
3. Second pass: sort each word again and add it to the list for its key.
4. Copy every list into the result.

Same result and complexity, but it sorts each word twice and needs the extra set, so Solution 1 is shorter and does less work.

## Complexity

With `n` words of maximum length `k`:

- **Time:** O(n · k log k) — sorting each word
- **Space:** O(n · k) — the dictionary stores every word
