using UnityEngine;

public class ani : MonoBehaviour
{
    private Animator A;
    // Start is called before the first frame update
    void Start()
    {
        A = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            A.SetTrigger("受傷觸發");
            A.SetBool("跑步開關", Input.GetKey(KeyCode.R));
        }
    }
}
