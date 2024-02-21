open readNWrite

[<EntryPoint>]
let main (args:string array) : int = 
    match (cat (Array.toList args)) with 
    | None -> 
        printfn "File(s) not found" 
        1
    | Some string ->
        printf "%A" string
        0



 
    

