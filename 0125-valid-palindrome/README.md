# 125. Valid Palindrome

**Difficulty:** Easy · **Language:** C# · [View on LeetCode](https://leetcode.com/problems/valid-palindrome/)

## Problem

A phrase is a palindrome if, after lowercasing all letters and removing every non-alphanumeric character, it reads the same forward and backward. Given a string `s`, return `true` if it is a palindrome, or `false` otherwise.

## Approach

Clean and reverse:

1. Keep only letters and digits (`char.IsLetterOrDigit`) and convert to lowercase.
2. Build a reversed copy of the cleaned string with `Array.Reverse`.
3. The string is a palindrome if it equals its reversed copy. An empty string (nothing left after cleaning) counts as a palindrome.

## Complexity

- **Time:** O(n)
- **Space:** O(n) — for the cleaned string and its reversed copy
