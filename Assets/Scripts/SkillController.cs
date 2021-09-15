using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillController : MonoBehaviour
{
    public static SkillController _instance = null;
    public static SkillController Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<SkillController>();
            }
            return _instance;
        }
    }
    public GameObject freezeArea;
    public GameObject skillInfoUI;
    public SpriteRenderer playerColor;
    private float duration = 5.0f;
    private Color playerOriginColor;
    public float timer;
    // Start is called before the first frame update


    void Start()
    {
        playerOriginColor = playerColor.color;
    }
    // Update is called once per frame
    void Update()
    {

        if (timer <= 0)
        {
            playerColor.color = playerOriginColor;
            freezeArea.SetActive(false);
            skillInfoUI.SetActive(false);
        }
        else
        {
            timer -= Time.unscaledDeltaTime;
        }
    }

    public void ActivateSkill()
    {
        playerColor.color = Color.blue;
        freezeArea.SetActive(true);
        skillInfoUI.SetActive(true);
        SkillController.Instance.timer = duration;
    }
}
