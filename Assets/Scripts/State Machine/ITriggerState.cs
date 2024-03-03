using UnityEngine;

public interface ITriggerState
{
    public void OnTriggerEnter(Collider other);
    public void OnTriggerStay(Collider other);
    public void OnTriggerExist(Collider other);
}