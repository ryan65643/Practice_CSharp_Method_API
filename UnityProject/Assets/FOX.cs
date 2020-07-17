using UnityEngine;

public class FOX : MonoBehaviour
{
    [Header("速度")]
    [Range(1, 100)]
    [Tooltip("移動速度")]
    public float speed = 1;
     [Header("剛體")]
	  public Rigidbody2D Rig;
	  private float thrust = 10.0f;
	  [Header("圖片渲染器")]
	  public SpriteRenderer Sr;
   


    private void Start()
    {
        bool key = Input.GetKey(KeyCode.LeftAlt);
        if (key)
        {
        Rig = gameObject.AddComponent<Rigidbody2D>();
        transform.position = new Vector3(0.0f, -2.0f, 0.0f);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rig.AddForce(transform.up * thrust, ForceMode2D.Impulse);
        }
    }
     private void Update()
    {
         float speed = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
        transform.Rotate(0, speed, 0);
    }
}
