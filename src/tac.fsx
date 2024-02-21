open readNWrite

[<EntryPoint>]
let main (args:string array) : int = 
    match (tac (Array.toList args)) with 
    | None -> 
        printfn "File(s) doesn't exist" 
        1
    | Some string ->
    printf "%A" string
    0