using UnityEngine;

public class PropellerSpinX : MonoBehaviour
{
    private Vector3 propSpin;
    // Start is called before the first frame update
    void Start()
    {
        propSpin = new Vector3(0, 0, 10);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(propSpin);
    }
}
