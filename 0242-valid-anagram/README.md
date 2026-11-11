# 242. Valid Anagram

**Difficulty:** Easy · **Language:** C# · [View on LeetCode](https://leetcode.com/problems/valid-anagram/)

## Problem

Given two strings `s` and `t` (lowercase English letters only), return `true` if `t` is an anagram of `s`, and `false` otherwise.

## Approach

Letter counting: if the lengths differ, they can't be anagrams. Otherwise, use an array of 26 counters (one per letter) and, in a single pass, increment the counter for each letter of `s` and decrement it for each letter of `t`. If every counter ends at zero, both strings contain exactly the same letters.

## Complexity

- **Time:** O(n)
- **Space:** O(1) — the counter array always has 26 slots
