using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour {

    private float fall_speed = 6f;
    private float control_speed = 6f;
    private CharacterController cc;

    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //fall
        cc.Move(Vector3.down * fall_speed * Time.deltaTime);

        //control
        if (Input.GetAxisRaw("Horizontal") < 0)
            cc.Move(Vector3.left * control_speed * Time.deltaTime);
        if (Input.GetAxisRaw("Horizontal") > 0)
            cc.Move(Vector3.right * control_speed * Time.deltaTime);
        if (Input.GetAxisRaw("Vertical") < 0)
            cc.Move(Vector3.back * control_speed * Time.deltaTime);
        if (Input.GetAxisRaw("Vertical") > 0)
            cc.Move(Vector3.forward * control_speed * Time.deltaTime);
    }
}