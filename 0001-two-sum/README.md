# 1. Two Sum

**Difficulty:** Easy · **Language:** C# · [View on LeetCode](https://leetcode.com/problems/two-sum/)

## Problem

Given an array of integers `nums` and an integer `target`, return the indices of the two numbers that add up to `target`. There is always exactly one solution, and the same element cannot be used twice.

## Approach

Brute force: check every pair `(i, j)` with `j > i` and return the first one whose sum equals `target`. Since `j` always starts at `i + 1`, an element is never compared with itself, so no `i != j` check is needed.

## Complexity

- **Time:** O(n²)
- **Space:** O(1)
