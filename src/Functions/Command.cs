


public class Command : IBaseCommand
{
    Base IBase.GetBaseStruct() => baseStruct;



Base IBase.baseStruct => baseStruct;

    // Variables
    public Base baseStruct { get; private set; }

// Constructor
 public Command(uint _classid, string _classname)
    {
        baseStruct = new Base
        {
            classId = _classid,
            classname = _classname
        };
    }
}