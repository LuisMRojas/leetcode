# 217. Contains Duplicate

**Difficulty:** Easy · **Language:** C# · [View on LeetCode](https://leetcode.com/problems/contains-duplicate/)

## Problem

Given an integer array `nums`, return `true` if any value appears at least twice, and `false` if every element is distinct.

## Approach

Hash set: walk through the array once, adding each number to a `HashSet<int>`. `HashSet.Add` returns `false` when the value is already in the set, which means it's a duplicate, so return `true` right away. If the loop finishes, every element was distinct.

## Complexity

- **Time:** O(n) — each `Add` is O(1) on average
- **Space:** O(n) — the set can hold up to `n` values
