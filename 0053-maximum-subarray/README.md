# 53. Maximum Subarray

**Difficulty:** Medium · **Language:** C# · [View on LeetCode](https://leetcode.com/problems/maximum-subarray/)

## Problem

Given an integer array `nums`, find the contiguous subarray with the largest sum and return that sum.

## Approach

Kadane's algorithm, tracking two values in one pass:

- `current`: the best sum of a subarray that **ends at** index `i`.
- `best`: the best sum seen anywhere so far.

At each index there are only two options: extend the previous subarray (`current + nums[i]`) or start a new one at `nums[i]`. If the running sum has become a drag (negative), starting fresh is better, which is exactly what `Math.Max(nums[i], current + nums[i])` decides. Both values start at `nums[0]` so all-negative arrays are handled correctly.

Example: `[-2,1,-3,4,-1,2,1,-5,4]` → the subarray `[4,-1,2,1]` gives `6`.

## Complexity

- **Time:** O(n)
- **Space:** O(1)
