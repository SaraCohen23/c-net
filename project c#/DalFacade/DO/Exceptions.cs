

namespace DO;

public class DalDoesNotExistException : Exception
{
    public DalDoesNotExistException(string message) : base(message)
    {

    }
}
public class DalExistsAlreadyException : Exception
{
    public DalExistsAlreadyException(string message) : base(message) { }


}
public class DalFuncIsNullException : Exception
{
    public DalFuncIsNullException(string message) : base(message) { }


}