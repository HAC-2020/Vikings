using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhysicsSceneManager : MonoBehaviour
{
    //STATES
    // 1=put power
    // 2=put rheostat
    // 3 =put ammeter
    public int state;
    public GameObject rheostat, ammeter, power;
    // Start is called before the first frame update
    void Start()
    {
        state = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void instantiateObjects(Button button)
    {
        switch(button.name)
        {
            case "Power":
                if(state==1){
                    power.SetActive(true);
                    GoToNextState();
                }
                else
                {
                    WrongStep();
                }
                break;
            case "Ammeter":
                if (state == 3)
                {
                    ammeter.SetActive(true);
                    GoToNextState();
                }
                else
                {
                    WrongStep();
                }
                break;
            case "Rheostat":
                if (state == 2)
                {
                    rheostat.SetActive(true);
                    GoToNextState();
                }
                else
                {
                    WrongStep();
                }
                break;
            default:
                Debug.Log("NOBUTTON");
                break;
        }
    }
    public void GoToNextState()
    {
        state++;
    }
    public void WrongStep()
    {
        Debug.Log("WRONGGGGGG");
    }
}
