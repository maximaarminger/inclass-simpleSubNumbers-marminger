using UnityEngine;
using UnityEngine.UI;

public class ComputeNumbers : MonoBehaviour
{
    public Text result;
    public InputField ipfVarA;
    public InputField ipfVarB;
    public Button btnSubNumber;
    public Button btnReset;


    void Start()
    {
        btnReset.interactable = false;
    }

      public void SubNumbersOnClick()
    {

        int variableA = int.Parse(ipfVarA.text);
        int variableB = int.Parse(ipfVarB.text);
        int SubResult = variableA - variableB;
        result.text = SubResult.ToString();

        ipfVarA.interactable = false;
        ipfVarB.interactable = false;
        btnSubNumber.interactable = false;
        btnReset.interactable = true;


    }

    public void ResetOnClick()
    {
        ipfVarA.interactable = true;
        ipfVarB.interactable = true;
        btnSubNumber.interactable = true;
        btnReset.interactable = false;

        result.text = "result";
        ipfVarA.text = "0";
        ipfVarB.text = "0";

    }


}
