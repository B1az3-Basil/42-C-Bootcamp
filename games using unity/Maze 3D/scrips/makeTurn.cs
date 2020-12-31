using UnityEngine;

public class makeTurn : MonoBehaviour
{
    public static Transform[] points;
    int index = 0;
    // Start is called before the first frame update
    void Awake()
    {
        points = new Transform[transform.childCount];
        while (index < points.Length)
        {
            points[index] = transform.GetChild(index);
            index++;
        }
    }
}
