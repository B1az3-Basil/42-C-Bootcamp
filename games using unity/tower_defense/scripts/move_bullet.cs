using System.Xml.Serialization;
using UnityEngine;

public class move_bullet : MonoBehaviour
{
    public int damege = 20;
    private Transform target;
    public float radius = 0f;
    public float speed = 70f;
    public GameObject part_;

  
    public void seek(Transform _target)
    {
        target = _target;
    }
   

    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 dir = target.position - transform.position;
        float distance_ = speed * Time.deltaTime;

        if (dir.magnitude <= distance_)
        {
            Hit_target();
            return;
        }

        transform.Translate(dir.normalized * distance_, Space.World);
       // transform.LookAt(target);
    }        
    void Hit_target()
    {
        GameObject imapact_ = (GameObject)Instantiate(part_, transform.position, transform.rotation);
        Destroy(imapact_, 5f);

        if (radius > 0f)
            explode();
        else
            damage(target);
       Destroy(gameObject);
    }
    void damage(Transform enemy)
    {
        more_players e = enemy.GetComponent<more_players>();
        if (e != null)
            e.take_damege(damege);
    }

    void explode()
    {
        Collider[] col = Physics.OverlapSphere(target.position, radius);
        foreach (Collider collider in col)
        {
            if (collider.tag == "target")
                damage(collider.transform);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, radius);
    }
}
