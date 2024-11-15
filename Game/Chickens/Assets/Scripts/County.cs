using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class County : Subject
{
    public Display _Win;

    private void OnEnable()
    {
        if (_Win)
            Attach(_Win);
    }

    private void OnDisable()
    {
        if (_Win)
            Detach(_Win);
    }

    private void OnCollisionEnter(Collision collision)
    {
        NotifyObservers();
    }
}
