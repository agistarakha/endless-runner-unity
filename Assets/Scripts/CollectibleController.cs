using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleController : MonoBehaviour
{
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (player.position.x - transform.position.x > 15)
        {
            gameObject.SetActive(false);
        }
    }
    void OnEnable()
    {
        float newPosX = player.position.x;
        transform.position = new Vector3(newPosX + 20, transform.position.y, transform.position.z);
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        SkillController.Instance.ActivateSkill();
        gameObject.SetActive(false);
    }
}
