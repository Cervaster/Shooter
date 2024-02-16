using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    public bool canBePickedUp = true;
    public bool isWeapon = false;
    public Transform weaponParent;
    public Vector3 weaponPositionOffset;
    public Vector3 weaponRotationOffset;

    private bool isEquipped = false;

    void Update()
    {
        if (canBePickedUp && Input.GetKeyDown(KeyCode.E))
        {
            if (!isEquipped)
            {
                EquipWeapon();
            }
            else
            {
                UnequipWeapon();
            }
        }

        if (isWeapon && isEquipped && Input.GetMouseButtonDown(0))
        {
            Debug.Log("Daño");
        }
    }

    void EquipWeapon()
    {
        Debug.Log("Arma equipada: " + gameObject.name);
        transform.SetParent(weaponParent);
        transform.localPosition = weaponPositionOffset;
        transform.localRotation = Quaternion.Euler(weaponRotationOffset);
        gameObject.SetActive(true);
        isEquipped = true;
    }

    void UnequipWeapon()
    {
        Debug.Log("Arma quitada: " + gameObject.name);
        transform.SetParent(null);
        transform.localPosition = Vector3.zero; // Resetear la posición
        transform.localRotation = Quaternion.identity; // Resetear la rotación
        gameObject.SetActive(false);
        isEquipped = false;
    }
}
