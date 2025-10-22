using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    private Transform target;

    [SerializeField] private float speed;
    private Rigidbody2D rb2d;

    [SerializeField] private float distance;
    [SerializeField] private LayerMask layerMask;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        target=GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        if (Vector2.Distance(transform.position, target.position) <= distance)
        {
            Vector2 direction = target.position - transform.position;
            RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, distance, layerMask);
            if (hit)
            {
                if (hit.collider.gameObject.CompareTag("Player"))
                {
                    rb2d.linearVelocity = direction.normalized * speed;
                }
                else
                {

                    rb2d.linearVelocity = Vector2.zero;
                }
            }
            else
            {

                rb2d.linearVelocity = Vector2.zero;
            }
        }
        else
        {
            rb2d.linearVelocity = Vector2.zero;
        }
    }



    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, distance);
        if (target != null)
        {
            Gizmos.color = Color.yellow;
            Vector2 direction = target.position - transform.position;

            Gizmos.DrawRay(transform.position, direction.normalized * distance);
        }
    }
}
