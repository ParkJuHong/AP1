using UnityEngine;

//피격 처리를 담당하는 인터페이스.
//해당 인터페이스를 상속 받지 않는 경우 피격 처리가 되지 않는다.
public interface IDamageable
{
    void OnDamage(float damage, Vector3 hitPoint, Vector3 hitNormal);
}