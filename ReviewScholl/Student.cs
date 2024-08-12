namespace ReviewScholl;

public class Student
{
    public string Name;
    public double Na;
    public double Nb;
    public double Nc;

    public double Finish()
    {
        return Na + Nb + Nc;
    }
    public bool Result()
    {
        if (Finish() >= 60)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
