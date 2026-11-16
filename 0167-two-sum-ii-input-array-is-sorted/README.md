# 167. Two Sum II - Input Array Is Sorted

**Difficulty:** Medium · **Language:** C# · [View on LeetCode](https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/)

## Problem

Given a **1-indexed** array `numbers` sorted in non-decreasing order, find two numbers that add up to `target` and return their indices `[index1, index2]` (1-based, `index1 < index2`). There is exactly one solution, the same element can't be used twice, and the solution must use only constant extra space.

## Approach

Two pointers: start `left` at the beginning and `right` at the end.

- If `numbers[left] + numbers[right] == target`, return `[left + 1, right + 1]` (converted to 1-based).
- If the sum is too small, move `left` right to get a bigger number.
- If the sum is too big, move `right` left to get a smaller number.

Because the array is sorted, each move safely discards a value that can't be part of the answer.

The commented-out code in `Solution.cs` is the earlier brute-force attempt (O(n²)), kept for comparison.

## Complexity

- **Time:** O(n)
- **Space:** O(1)
