using System.Collections;
using UnityEngine;

public class BTNСooldown : MonoBehaviour
{
    public bool isClick = false;
    public virtual void BTN_Сooldown()
    {
        isClick = true;
        CheckBool();
    }

    protected void CheckBool()
    {
        if (isClick == true)
        {
            StartCoroutine(UpdateBool());
        }
    }

    protected IEnumerator UpdateBool()
    {
        yield return new WaitForSeconds(0.2f);
        isClick = false;
    }
}

