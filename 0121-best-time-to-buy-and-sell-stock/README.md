# 121. Best Time to Buy and Sell Stock

**Difficulty:** Easy · **Language:** C# · [View on LeetCode](https://leetcode.com/problems/best-time-to-buy-and-sell-stock/)

## Problem

Given an array `prices` where `prices[i]` is the price of a stock on day `i`, choose one day to buy and a later day to sell to maximize profit. Return the maximum profit, or `0` if no profit is possible.

## Approach

One pass, tracking two values:

- `minPrice`: the cheapest price seen so far (the best day to buy up to now).
- `best`: the best profit found so far.

For each day, update `minPrice` if today's price is lower, then check whether selling today (`prices[i] - minPrice`) beats `best`. Because `minPrice` only includes earlier (or current) days, buying always happens before selling.

## Complexity

- **Time:** O(n)
- **Space:** O(1)
