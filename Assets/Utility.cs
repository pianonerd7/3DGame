using UnityEngine;
using System.Collections;

public static class Utility {

    private static int _targetEnemy = 1;
    private static int _numEnemy = 0;
    private static string _healthString = "Healthbar \n 5:*****";
    private static bool _isDead = false;
    private static bool _xDown = true;
    private static bool _yDown = true;

    public static int TargetEnemy
    {
        get
        {
            return _targetEnemy;
        }
    }

    public static int NumEnemy
    {
        get
        {
            return _numEnemy;
        }
    }

    public static string HealthString
    {
        get
        {
            return _healthString;
        }
        set
        {
            _healthString = value;
        }
    }
    public static bool IsDead
    {
        get
        {
            return _isDead;
        }
        set
        {
            _isDead = value;
        }
    }

    public static bool XDown
    {
        get
        {
            return _xDown;
        }
        set
        {
            _xDown = value;
        }
    }

    public static bool YDown
    {
        get
        {
            return _yDown;
        }
        set
        {
            _yDown = value;
        }
    }

    public static void AddTargetEnemy()
    {
        _targetEnemy = _targetEnemy + 2;
    }

    public static void AddNumEnemy()
    {
        _numEnemy++;
    }
}
