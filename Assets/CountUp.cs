using UnityEngine;
using TMPro;
public class CountUp : MonoBehaviour
{
    [SerializeField] //Provides the ability to private variables be modified in the Inspector
    //private TextMeshProUGUI Text;
    private TextMeshProUGUI[] Atext; //Initializing an array
    [SerializeField]
    private float Speed = 1; //float-primitive type 
    //Access Modifiers- private,public,etc

    private float TimeDisplay = 0;

    private float[] FloatArray;

    private void Start()
    {
        FloatArray = new float[Atext.Length]; //Defining an array
        FloatArray[0] = 19.56f; //Assigning the index of the array a value
    }
    // Update is called once per frame
    void Update()
    {
        if (Speed > 0)
        {
            /*
            TimeDisplay = TimeDisplay + Time.deltaTime*Speed; //30fps-0.03333333333 60fps-0.01666666666666667
            Text.SetText(TimeDisplay.ToString("N2"));

            //N2 (Numeric Format Specifier) Eg:  12.34

            */

            /*
            //For generating a random number between 0 and 1

            TimeDisplay = Random.Range(0.0f, 1.0f);
            Text.SetText(TimeDisplay.ToString("N3"));
            */

            /*
             // Multiple counter using for loop
            TimeDisplay = TimeDisplay + Time.deltaTime * Speed;
            for (int i = 0; i < Atext.Length; i++)
            {
                Atext[i].SetText($"{TimeDisplay.ToString("N2")}");
            }

            //Multiple counter using while loop
            int i=0;
            while(i<Atext.Length)
            {
            Atext[i].SetText($"{TimeDisplay.ToString("N2")}");
            i++;
            }

            //Multiple counter using do-while loop
            int i=0;
            do
            {
             Atext[i].SetText($"{TimeDisplay.ToString("N2")}");
            i++;
            }while(i<Atexts.Length);
            */

            /*
            //Multiple counter usin for-each loop
            
            foreach(TextMeshProUGUI atext in Atext)
            {
                atext[i].SetText($"{TimeDisplay.ToString("N2")}");
            }
             
             */

            //MonoBehaviour Lifecycle basics- Awake, OnEnable, Start, Update, FixedUpdate(Physics operations related)

        }
    }
}
