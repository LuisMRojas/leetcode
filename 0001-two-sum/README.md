# 1. Two Sum

**Dificultad:** Easy · **Lenguaje:** C# · [Ver en LeetCode](https://leetcode.com/problems/two-sum/)

## Problema

Dado un arreglo de enteros `nums` y un entero `target`, devolver los índices de los dos números que suman `target`. Siempre existe exactamente una solución y no se puede usar el mismo elemento dos veces.

## Enfoque

Fuerza bruta: se recorren todos los pares `(i, j)` con `j > i` y se devuelve el primero cuya suma es igual a `target`.

## Complejidad

- **Tiempo:** O(n²)
- **Espacio:** O(1)
