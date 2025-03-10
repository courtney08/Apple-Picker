using UnityEngine;

public class Apple : MonoBehaviour
{
    public static float bottomY = -20f;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < bottomY){
            Destroy(this.gameObject);

            //Get a reference to the ApplePicker component of MainCamera
            ApplePicker apScript = Camera.main.GetComponent<ApplePicker>();
            //Call the public AppleMissed() method of apScript
            apScript.AppleMissed();
        }
    }
}
