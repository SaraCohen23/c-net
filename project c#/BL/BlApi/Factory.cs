

namespace BlApi;

public static class Factory
{
    public static IBl Get()
    {
        //לבדוק האם זה הנדרש
        return (IBl)DalApi.Factory.Get;
     
    }

}
