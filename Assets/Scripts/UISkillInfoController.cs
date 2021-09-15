using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISkillInfoController : MonoBehaviour
{

    public Text durationTextValue;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        durationTextValue.text = Mathf.CeilToInt(SkillController.Instance.timer).ToString();
    }
}
