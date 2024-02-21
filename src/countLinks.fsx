/// Opgave 9g3

///<summary> The function countLinks takes a string and returns an integer. The function uses two helping functions "url2Stream" and "readUrl", which 
/// transtorms the url to stream and reads the content of the Url's, respectively, such that the number of links can be counted.  <\summary>
///<param name>"url" - accepts a string. <\param name>
///<returns> Returns an int, representing the number of links counted.</returns>    

//Transforms the url to a stream such that it can be read.
let url2Stream url = 
    let uri = System.Uri url
    let request = System.Net.WebRequest.Create uri
    let response = request.GetResponse ()
    response.GetResponseStream ()

//Reads the url such that the number of links can be counted with countLinks. 
let readUrl url = 
    let stream = url2Stream url
    let reader = new System.IO.StreamReader(stream)
    reader.ReadToEnd ()
    
let countLinks (url:string) : int =
    try
    let html = readUrl url |> Seq.toList
    let rec helperCL (u:char list) : int =
        match u with
        |'<'::'a'::xs -> 1 + helperCL xs
        |x::xs -> 0 + helperCL xs
        |[] -> 0
    helperCL html
    with
    | ex -> 
        printfn "Error: Invalid input %A" ex.Message
        -1

[<EntryPoint>]
let main (args:string array) : int =
    printfn "%A" <| countLinks (String.concat "" args)
    0
