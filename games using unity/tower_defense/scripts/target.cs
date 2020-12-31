using UnityEngine;

public class target : MonoBehaviour
{

    public float slow_per = .5f;
    private Transform target_;
    public float range = 15f;
    public Transform rotate_;
    public float speed_turn = 10f;
    public string tags = "target";
    public float bullet_number = 1f;
    private float fire_count = 0f;
    public Transform fire_point;
    public GameObject bullet;
    [Header("use laser")]
    public bool use_laser = false;
    public LineRenderer line_rend;
    public int damege_laser = 100;
    public ParticleSystem impect_effect;
    public Light effect_light;
    private more_players enermy_;
         
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Update_target", 0f, 0.5f);
    }

    void Update_target()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(tags);
        float short_dis  = Mathf.Infinity;
        GameObject near_ = null;

        foreach (GameObject enemy in enemies)
        {
            float distanceToEnemy;
            distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if (distanceToEnemy < short_dis)
            {
                short_dis = distanceToEnemy;
                near_ = enemy;
            }
        }
        if (near_ != null && short_dis <= range)
        {
            target_ = near_.transform;
            enermy_ = near_.GetComponent<more_players>();
        }
           
        else
            target_ = null;

    }

    // Update is called once per frame
    void Update()
    {
        if (target_ == null)
        {
            if (use_laser)
                if (line_rend.enabled)
                {
                    line_rend.enabled = false;
                    impect_effect.Stop();
                    effect_light.enabled = false;
                }
                    
            return;
        }
        lock_on_target();

        if (use_laser)
            laser();
        else
        {
            if (fire_count <= 0f)
            {
                shoot();
                fire_count = 1f / bullet_number;
            }
            fire_count -= Time.deltaTime;
        }

        
    }

    void laser()
    {
        enermy_.take_damege(damege_laser * Time.deltaTime);
        enermy_.slow(slow_per);

        if (!line_rend.enabled)
        {
            line_rend.enabled = true;
            
            impect_effect.Play();
            effect_light.enabled = true;
        }
           
        line_rend.SetPosition(0, fire_point.position);
        line_rend.SetPosition(1, target_.position);

        Vector3 dir = fire_point.position - target_.position; 
        impect_effect.transform.rotation = Quaternion.LookRotation(dir); 
        impect_effect.transform.position = target_.position + dir.normalized;
    }

    void lock_on_target()
    {
        Vector3 dir = target_.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(dir);
        Vector3 rotation = Quaternion.Lerp(rotate_.rotation, lookRotation, Time.deltaTime * speed_turn).eulerAngles;
        rotate_.rotation = Quaternion.Euler(0f, rotation.y, 0f);
    }

    void shoot()
    {
        GameObject bullet_ = (GameObject)Instantiate(bullet, fire_point.position, fire_point.rotation);
        move_bullet bullet__ = bullet_.GetComponent<move_bullet>();
        if (bullet__ != null)
            bullet__.seek(target_);

    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position,range);
    }
}
