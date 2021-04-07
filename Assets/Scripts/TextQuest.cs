using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextQuest : MonoBehaviour
{
    public Text contentLablel;
    public Text titleText;
    public Step startStep;
    
    private Step currentStep;
    
    // Start is called before the first frame update
    private void Start()
    {
        currentStep = startStep;

        UpdateContentLable();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            MoveToNextStep(0);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            MoveToNextStep(1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            MoveToNextStep(2);
        }
    }
    private void UpdateContentLable()
    {
        titleText.text = currentStep.titleText;
        contentLablel.text = currentStep.contentText;
    }
    private void MoveToNextStep(int stepIndex)
    {
        if (currentStep.nextSteps.Length > stepIndex)
        {
            currentStep = currentStep.nextSteps[stepIndex];
            UpdateContentLable();
        }
    }
}
