module readNWrite
open System 
open System.IO 

/// Opgave 9g0

///<summary> The function readFile takes a string and returns a string option, representing the content of the file. 
/// An exception is handled, if the file given is not a valid file. The<\summary>
///<param name>"filename" - accepts a string. <\param name>
///<returns> Returns a string option. </returns>
let readFile (filename:string) : string option = 
    try 
        let read = System.IO.File.OpenText filename 
        let text = read.ReadToEnd ()  
        Some text
    with 
    | :? System.IO.FileNotFoundException -> None

/// Opgave 9g1

///<summary> The function catHelper takes a string option and returns a string.  <\summary>
///<param name>"s" - accepts a string option. <\param name>
///<returns> Returns a string. </returns>
let catHelper (s:string option) : string = 
    match s with 
    |Some c -> c
    |None -> "Error"
    
///<summary> The function cat takes a string list and returns a string option. It concatinates the content of the two strings.  <\summary>
///<param name>"Filenames" - accepts a string list <\param name>
///<returns> Returns a string option, being the result of contatenating the files in the list. </returns>    
let cat (filenames:string list) : string option =
   let helper = List.map (fun x -> readFile x) filenames
   let rmv = List.contains None helper
   if rmv then None else List.map (fun x -> catHelper x) helper |> String.concat "" |> Some

/// Opgave 9g2

///<summary> The function tac takes a string list and returns a string option. It reverse concatinates the content of the two strings. <\summary>
///<param name>"Filenames" - accepts a string list <\param name>
///<returns> Returns a string option, being the result of contatenating the files in the list and reversing it. </returns>    
let tac (filenames: string list) : string option =
    match cat filenames with
    |None -> None
    |Some c -> c |> Array.ofSeq |> Array.rev |> System.String |> Some
    


    
    
    
    
    
    



