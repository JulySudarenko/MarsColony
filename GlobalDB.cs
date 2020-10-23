using UnityEngine;


public class GlobalDB : MonoBehaviour
{
    #region Field

    [HideInInspector] public int Time;
    [HideInInspector] public int Rover;
    [HideInInspector] public int Alloy;
    [HideInInspector] public int Polymers;
    [HideInInspector] public int Electronics;
    [HideInInspector] public int Water;
    [HideInInspector] public int Re;
    [HideInInspector] public int Energy;
    [HideInInspector] public int Chemicals;
    [HideInInspector] public int Ore;
    [HideInInspector] public int Food;
    [HideInInspector] public int Raw;
    [HideInInspector] public int Colonists;

    //[HideInInspector] public int[] Resources = new int[12];
    //[HideInInspector] public List<BuildingsDB>;

    #endregion


    #region UnityMethods

    private void Start()
    {
        LoadDB();
    }

    #endregion


    #region Methods
    private void LoadDB()
    {
        Time = 1;
        Rover = 4;
        Alloy = 222;
        Polymers = 333;
        Electronics = 44;
        Water = 55;
        Re = 66;
        Energy = 77;
        Chemicals = 88;
        Ore = 99;
        Food = 110;
        Raw = 111;
        Colonists = 4;
    }

    public void SaveDB()
    {

    }

    #endregion
}
