using UnityEngine;

public class otherway : MonoBehaviour
{
    public static Transform[] otherPoints;
    int index = 0;
    // Start is called before the first frame update
    void Awake()
    {
        otherPoints = new Transform[transform.childCount];
        while (index < otherPoints.Length)
        {
            otherPoints[index] = transform.GetChild(index);
            index++;
        }
    }

    
}
