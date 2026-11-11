# 217. Contains Duplicate

**Difficulty:** Easy · **Language:** C# · [View on LeetCode](https://leetcode.com/problems/contains-duplicate/)

## Problem

Given an integer array `nums`, return `true` if any value appears at least twice, and `false` if every element is distinct.

## Approach

Brute force: compare every pair `(i, j)` with `j > i` and return `true` as soon as two equal values are found. If no pair matches, return `false`.

## Complexity

- **Time:** O(n²)
- **Space:** O(1)
