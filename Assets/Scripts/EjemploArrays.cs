using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploArrays : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] nums1 = { 1, 2, 3, 4, 5 };
        int[,] nums2 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        int[][] matrizEscalonada = {
            new int[] {1,2,3},
            new int[] {4,5},
            new int[] {6,7,8,9}
        };

        // Debug.Log("FOR");
        // for (int i = 0; i < nums1.Length; i++)
        // {
        //     Debug.Log($"nums1[{i}] = {nums1[i]}");
        // }

        Debug.Log("FOR - FOR:");
        for (int i = 0; i < nums2.GetLength(0); i++)
        {
            for (int j = 0; j < nums2.GetLength(1); j++)
            {
                Debug.Log($"nums2[{i}, {j}] ={nums2[i, j]}");
            }
        }
        // Debug.Log("FOREACH:");
        // foreach (int num in nums2)
        // {
        //     Debug.Log($"{num}");
        // }

        Debug.Log("MATRIZ ESCALONADA:");
        int fila = 0;
        foreach (int[] filaActual in matrizEscalonada)
        {
            string s = "";
            foreach (int elemento in filaActual)
            {
                s += elemento + " ";
            }
            Debug.Log($"Fila{fila++}: {s}");
        }

        Debug.Log("MATRIZ ESCALONADA CON FORS ANIDADOS:");
        for (int i = 0; i < matrizEscalonada.Length; i++)
        {
            for (int j = 0; j < matrizEscalonada[i].Length; j++)
            {
                Debug.Log($"matrizEscalonada[{i}][{j}] ={matrizEscalonada[i][j]}");
            }
        }



    }

    private void MostrarArray(int[] nums)
    {

    }
}
