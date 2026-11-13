# 268. Missing Number

**Difficulty:** Easy · **Language:** C# · [View on LeetCode](https://leetcode.com/problems/missing-number/)

## Problem

Given an array `nums` containing `n` distinct numbers in the range `[0, n]`, return the only number in that range that is missing from the array.

## Approach

Math (Gauss sum): the sum of every number from `0` to `n` is `n * (n + 1) / 2`. Subtracting the actual sum of `nums` from that expected sum leaves exactly the missing number.

Example: `nums = [3, 0, 1]` → expected `0+1+2+3 = 6`, actual `4`, missing `6 - 4 = 2`.

## Complexity

- **Time:** O(n) — one pass to sum the array
- **Space:** O(1)
