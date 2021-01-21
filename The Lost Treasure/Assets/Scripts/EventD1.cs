using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class EventD1  {
    static itemInterac invorker;
    static UnityAction<int> listener;
    public static void AddInvorker(itemInterac script)
    {
        invorker = script;
        if (listener != null)
        {
            invorker.Trunonoeb(listener);
        }
    }
    public static void AddListener(UnityAction<int> handler)
    {
        listener = handler;
        if (invorker != null)
        {
            invorker.Trunonoeb(listener);
        }
    }
}
