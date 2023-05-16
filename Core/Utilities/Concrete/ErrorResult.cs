namespace Core.Utilities.Concrete;

public class ErrorResult :Result
{
    public ErrorResult(string messsage) : base(false, messsage)
    {
    }
    public ErrorResult() : base(false)
    {
    }
}