using UnityEngine;
using UnityEngine.UI;

public class HPbarEnemy : MonoBehaviour
{
    public int HP;
    private Slider hpstat;
    private TargetEnemy hpvalue;

    private void Update()
    {
        hpstat = transform.Find("Canvas/Panel/Slider").gameObject.GetComponent<Slider>();
        hpvalue = GameObject.Find("Enemy").GetComponent<TargetEnemy>();
        hpstat.value = hpvalue.health;
    }
}
