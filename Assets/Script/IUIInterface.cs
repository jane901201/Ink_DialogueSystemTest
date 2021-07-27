using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IUIInterface : MonoBehaviour
{
    public virtual void UIUpdate()
    {

    }

	public void RemoveChildren(Canvas canvas)
	{
		int childCount = canvas.transform.childCount;
		for (int i = childCount - 1; i >= 0; --i)
		{
			GameObject.Destroy(canvas.transform.GetChild(i).gameObject);
		}
	}


}
