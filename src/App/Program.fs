open System
open Library

[<EntryPoint>]
let main args =
    let value, json = getJson {| args= args; year=System.DateTime.Now.Year |}
    printfn $"Input: %0A{value}"
    printfn $"Output: %s{json}"
    0 // return an integer exit code