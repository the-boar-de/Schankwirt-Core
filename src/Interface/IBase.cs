// Base Struct
public struct Base
{
    // Define common properties or methods for all derived structs
    // Variables
    public uint classId { get; set;}

    public string classname { get; set;}


}



// Base interface
public interface IBase
{
    // Define common properties or methods for all derived interfaces
    // Variables
     Base baseStruct { get;}


    //Methods
    Base GetBaseStruct();




}