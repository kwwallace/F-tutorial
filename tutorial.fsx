
let prefix prefixStr baseStr = prefixStr + ", " + baseStr

let names = ["John"; "Paul"; "George"; "Ringo"] 

let prefixWithHello = prefix "Hello"

let exclaim s = s + "!"

let bigHello = prefixWithHello >> exclaim

let hellos = 
    names 
    |> Seq.map (fun x -> printfn "Mapped over %s" x; bigHello x)
    |> Seq.sort
    |> Seq.iter (printfn "%s")

hellos