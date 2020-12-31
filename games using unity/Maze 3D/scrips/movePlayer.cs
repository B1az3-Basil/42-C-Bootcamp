using UnityEngine;

public class movePlayer : MonoBehaviour
{
    private Transform target;
    private int index = 0;
    public float speed = 10f;
    private int count = 0;
    private bool turnArounds = false;
    private bool done = false;
    private bool repeat = false;
    private int lastValueIndex;
    public Transform cam;
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        target = makeTurn.points[0];
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
        cam.position = new Vector3(transform.position.x, transform.position.y + offset.y, transform.position.z);
        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            if (index >= makeTurn.points.Length - 1 || turnArounds == true && done == false)
            {
                turnAround();
                turnArounds = true;
                return;
            }
            else if (done == true)
                wayToGO();

            else
                otherWays();
            
        }
           
    }

    private void otherWays()
    {
        if (repeat == true)
        {
            index--;
            target = makeTurn.points[index];
            if (index == 0)
            {
                repeat = false;
                count = 0;
            }
               
            return;
        }
        index++;
        target = makeTurn.points[index];
    }

    private void turnAround()
    {
       if  (count < 6)
        {
            index--;
            target = makeTurn.points[index];
            count++;
            return;
        }
        lastValueIndex = index + 1;
        target = otherway.otherPoints[0];
        index = 0;
        done = true;
    }

    void wayToGO()
    {
        if (index >= otherway.otherPoints.Length - 1 || repeat == true)
        {
            repeat = true;
            index--;
            target = otherway.otherPoints[index];
            if (index == 0)
            {
                index = lastValueIndex;
                done = false;
                turnArounds = false;
            }
            return;
        }
        index++;
        target = otherway.otherPoints[index];
    }
}
