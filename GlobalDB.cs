using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;



public class GlobalDB : MonoBehaviour
{
    #region Field

    const int NumberRes = 13;
    const int NumberBuild = 19;
    const int SizeX = 20;
    const int SizeY = 10;

    public int[,] MasPrice;//    = new int[NumberRes,NumberBuild];
    public int[,] MasIncome;//   = new int[NumberRes,NumberBuild];
    public int[] MasRes;//      = new int[NumberRes];

    public Building[,] _grid;
    public Vector2Int GridSize = new Vector2Int(SizeX, SizeY);

    [HideInInspector] public int Time = 0;
    [HideInInspector] public int Rover = 1;
    [HideInInspector] public int Alloy = 2;
    [HideInInspector] public int Polymers  = 3;
    [HideInInspector] public int Electronics = 4; 
    [HideInInspector] public int Water = 5;
    [HideInInspector] public int Re = 6;
    [HideInInspector] public int Energy = 7;
    [HideInInspector] public int Chemicals = 8;
    [HideInInspector] public int Ore = 9;
    [HideInInspector] public int Food = 10;
    [HideInInspector] public int Raw = 11;
    [HideInInspector] public int Colonists = 12;

    [HideInInspector] public int Open_Storage = 0;
    [HideInInspector] public int Water_extractor = 1;
    [HideInInspector] public int Rovers_on_metall = 2;
    [HideInInspector] public int Rovers_on_re = 3;
    [HideInInspector] public int Tank = 4;
    [HideInInspector] public int Solar_panel = 5;
    [HideInInspector] public int Small_Battery = 6;


    public List<int> BuildList = new List<int>();

    #endregion


    #region UnityMethods

    private void Start()
    {
        //Debug.Log(MasRes.Length.ToString());
        //Debug.Log(MasRes.Length.ToString());
        //Debug.Log(NumberRes.ToString());

        _grid       = new Building[GridSize.x, GridSize.y];
        MasPrice    = new int[NumberRes, NumberBuild];
        MasIncome   = new int[NumberRes, NumberBuild];
        MasRes      = new int[NumberRes];
        LoadDB();
    }

    #endregion


    #region Methods
    private void LoadDB()
    {

        Time = 0;
        Rover = 1;
        Alloy = 2;
        Polymers = 3;
        Electronics = 4;
        Water = 5;
        Re = 6;
        Energy = 7;
        Chemicals = 8;
        Ore = 9;
        Food = 10;
        Raw = 11;
        Colonists = 12;

        MasRes[Time]    = 1;
        MasRes[Rover]   = 4;
        MasRes[Alloy] = 112;
        MasRes[Polymers] = 113;
        MasRes[Electronics] = 114;
        MasRes[Water] = 115;
        MasRes[Re] = 116;
        MasRes[Energy] = 117;
        MasRes[Chemicals] = 118;
        MasRes[Ore] = 119;
        MasRes[Food] = 110;
        MasRes[Raw] = 111;
        MasRes[Colonists] = 121;

        //for (int i = 0; i < NumberRes; i++)
        //{
        //    for (int j = 0; j < NumberBuild; j++)
        //    {
        //        MasIncome[i, j] = 0;
        //        MasPrice[i, j] = 0;
        //    }
        //}

        MasPrice[Rover, Open_Storage] = 1;
        MasIncome[Alloy, Open_Storage] = 2;

    }

    public void SaveDB()
    {

    }

    public void Calculate()
    {
        //Debug.Log("BuildList.Count=" + BuildList.Count.ToString());
        Debug.Log("NumberRes=" + NumberRes.ToString());
        
        for (int i = 0; i < BuildList.Count; i++)
        {
            Debug.Log("BuildList[i]=" + BuildList[i].ToString());
            for (int j=0;j< NumberRes; j++)
            {
                MasRes[j] += MasIncome[j,BuildList[i]];
                Debug.Log("MasRes[j]=" + MasRes[j].ToString()+ "MasIncome[j,BuildList[i]]="+ MasIncome[j, BuildList[i]]+"i="+i.ToString()+"j="+j.ToString());

            }
        }
    }

    public bool isEnothRes(int BuildID)
    {
        for (int i = 0; i < NumberRes; i++)
        {
            if (MasRes[i] < MasPrice[i,BuildID])
                return false;
        }
        return true;
    }

    public void BuildingCost(int BuildID)
    {
        //Debug.Log(BuildID.ToString());
        for (int i = 0; i < NumberRes; i++)
        {
            MasRes[i] -= MasPrice[i,BuildID];
            //Debug.Log(MasRes[i].ToString());
            //Debug.Log(MasPrice[i, BuildID].ToString());

        }
    }

    #endregion
}
