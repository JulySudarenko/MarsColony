using UnityEngine;

public class ResourcesCalculation : MonoBehaviour
{
    #region Field

    private GlobalDB _GlobalDB;

    #endregion


    #region UnityMethods

    private void Start()
    {
        _GlobalDB = gameObject.GetComponentInParent<GlobalDB>();

    }
    #endregion

    #region Methods

    public void Calculate()
    {
        _GlobalDB.Time++;
    }


    #endregion
}
