using System;
namespace Proxy
{
    public interface IMath
    {

        //интерфейс для прокси и реальногно обьекта 
        double Add(double x, double y);
        double Sub(double x, double y);
        double Mul(double x, double y);
        double Div(double x, double y);
    }
}
