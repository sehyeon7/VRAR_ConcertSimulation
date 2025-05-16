using UnityEngine;

public class shrinktoplayer : MonoBehaviour
{
    public bool pressed = false;
    public GameObject player, rig;
    public GameObject moveObject;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            if (!pressed)
            {
                pressed = true;
                //gameObject.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
                moveObject.transform.position = player.transform.position;
                
            }
        }

        if (Input.GetKeyDown(KeyCode.L)) {
            if (pressed)
            {
                pressed = false;
                gameObject.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                gameObject.transform.position = rig.transform.position;
            }
        }

        if (Input.GetKeyDown(KeyCode.T)) {
            gameObject.transform.position += new Vector3(0.0f, 0.0f, 1.0f);
         }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            gameObject.transform.position += new Vector3(0.0f, 0.0f, -1.0f);
        }

        if (Input.GetKeyDown(KeyCode.U)) {
            gameObject.transform.position += new Vector3(0.0f, 1.0f, 0.0f);
         }
        if (Input.GetKeyDown(KeyCode.I)) {
            gameObject.transform.position += new Vector3(0.0f, -1.0f, 0.0f);
         }
    }
}
