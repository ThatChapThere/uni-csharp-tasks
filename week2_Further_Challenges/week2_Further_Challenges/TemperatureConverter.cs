namespace week2_Further_Challenges;

class TemperatureConverter{
    double _C = 0;
    double _F = 0;

    public double C{
        get{ return _C; }
        set{_C = value; }
    }

    public double F{
        get{ return _F; }
        set{ _F = value; }
    }
    
    public double CtoF => C * 9f / 5 + 32;
}