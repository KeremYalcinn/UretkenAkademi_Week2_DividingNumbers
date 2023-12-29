using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolunenler : MonoBehaviour
{
    void Start()
    {
        int baslangic = 10; // Baþlangýç sayýsý
        int bitis = 43; // Bitiþ sayýsý

        BolunenleriBul(baslangic, bitis);
    }

    void BolunenleriBul(int baslangic, int bitis)
    {
        ArrayList bolunen2 = new ArrayList();

        for (int i = baslangic; i <= bitis; i++)
        {
            if (i % 2 == 0)
            {
                bolunen2.Add(i);
            }
        }

        ArrayList bolunen3 = new ArrayList();

        for (int i = baslangic; i <= bitis; i++)
        {
            if (i % 3 == 0)
            {
                bolunen3.Add(i);
            }
        }

        ArrayList bolunen4 = new ArrayList();

        for (int i = baslangic; i <= bitis; i++)
        {
            if (i % 4 == 0)
            {
                bolunen4.Add(i);
            }
        }
        ArrayList bolunen5 = new ArrayList();

        for (int i = baslangic; i <= bitis; i++)
        {
            if (i % 5 == 0)
            {
                bolunen5.Add(i);
            }
        }

        Debug.Log("2'ye tam bölünenler: " + string.Join(", ", bolunen2.ToArray()));
        Debug.Log("3'e tam bölünenler: " + string.Join(", ", bolunen3.ToArray()));
        Debug.Log("4'e tam bölünenler: " + string.Join(", ", bolunen4.ToArray()));
        Debug.Log("5'e tam bölünenler: " + string.Join(", ", bolunen5.ToArray()));
        
    }
}


