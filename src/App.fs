//Declaring class customer name in F#
type CustomerName(firstName, middleInitial, lastName)
    member this.FirstName = firstName
    member this.MiddleInitial = middleInitial
    member this.LastName = lastName

//Declaring class customer name in C#
public class CustomerName {
    public CustomerName(string firstName, string middleInitial, string lastName){
        this.FirstName = firstName;
        this.MiddleInitial = middleInitial;
        this.LastName = lastName;

        public string FirstName {get; private set;}
        public string MiddleInitial {get; private set;}
        public string LastName {get; private set;}
    }
}

//Declaring class customer name in F# with explicit types
type CustomerName2(firstName: string, middleInitial: string, lastName: string) =
    member this.FirstName = firstName
    member this.MiddleInitial = middleInitial
    member this.LastName = lastName

