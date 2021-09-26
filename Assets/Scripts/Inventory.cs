using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    #region Singleton
    public static Inventory instance;
    GameObject checkMark;
    

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one instance of inventory found!");
            return;
        }
        instance = this;
    }
    #endregion
    
    public delegate void OnItemChanged();
	public OnItemChanged onItemChangedCallback;
    public List<Item> items = new List<Item>();

    public void Add (Item item)
    {
        if (!item.isDefault)
        {
            items.Add(item);

            if (onItemChangedCallback != null)
            {
                onItemChangedCallback.Invoke();
            }
			
        }
        
    }

    public void Remove (Item item)
    {
        items.Remove(item);
    }
}
