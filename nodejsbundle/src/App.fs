module App

//open Fable.SimpleHttp
open Fable.Core.Extensions
open Fable.Import
open Fable.Core.JsInterop
open Fetch
//open Fable.Core.JS.Constructors

importSideEffects "isomorphic-fetch"
printfn "%A" (Fetch.fetch "https://random.dog/woof.json" [])

// we get a json from our fetch request with a url field
// so we create this type to map the json object
//type PictureInfo = { Url : string }

// This function will fetch a random dog url every reload of the page
//let getRandomDogImage url =
//    let res = fetch url [] // use the fetch api to load our resource
//    printfn "%A" res
//    |> Promise.bind (fun res -> res.text()) // get the resul
//    |> Promise.map (fun txt -> // bind the result to make further operation
//      printfn "Result: %s" txt
//      )
//Http.get "https://random.dog/woof.json"
//|> Async.StartAsPromise
////|> Promise.bind (fun (statusCode, responseText)-> res.text()) // get the resul
//|> Promise.map (fun (statusCode, responseText) -> // bind the result to make further operation
//  match statusCode with
//    | 200 -> printfn "Result %s" responseText
//    | _ -> printfn "Status %d => %s" statusCode responseText
// )
//async {
//    let! (statusCode, responseText) = Http.get "https://random.dog/woof.json"
//    match statusCode with
//    | 200 -> printfn "Everything is fine => %s" responseText
//    | _ -> printfn "Status %d => %s" statusCode responseText
//} |> Async.StartAsPromise 

//printfn "Hello, World!"
// start our app!
//let res = Node.Https.
//printfn "%A" (Fetch.fetch "https://random.dog/woof.json" [])
//getRandomDogImage "https://random.dog/woof.json" |> ignore

