using UnityEngine;
using System;


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
        //_GlobalDB.Time++;
        _GlobalDB.MasRes[_GlobalDB.Time] += 1;
        _GlobalDB.Calculate();
    }


    #endregion
}
