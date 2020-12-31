using UnityEngine;

public class turn : MonoBehaviour
{
    public static Transform[] points;
    int i;

    void Awake()
    {
        
        points = new Transform[transform.childCount];
        for (i = 0; i < points.Length; i++)
            points[i] = transform.GetChild(i);
    }
}
