namespace EulerProject.Core

module Problem32 =
    open EulerProject.Core.NumberUtilities

//    let pandigitalArray length =
//        match length with 
//        | length when length >= 10 -> [|'1'..'9'|]
//        | _ -> Array.sub [|'1'..'9'|] 0 length
//
//    let isPandigital (xs:int[]) =
//        match xs with
//        | [||] -> false
//        | _ ->
//            Array.collect (fun x -> x.ToString().ToCharArray()) xs
//            |> Array.sort
//            |> fun x -> x = pandigitalArray (Seq.length x)


    let isPandigital x =
        let rec calculate x bits count =
            match x with
            | 0 -> bits <> 0 && bits = (1 <<< count) - 1 // Filling all bits up to length of number
            | _ -> 
                let lastNumber = x % 10 // = The last digit, e.g. 1234 -> 4
                let bitPos = lastNumber - 1
                let newBits = bits ||| (1 <<< bitPos) // Setting the bit for this digit
                match newBits with
                | b when b = bits -> false // No change means the bit was alreay set => we already registered this digit
                | _ ->
                    calculate (x / 10) newBits (count+1)
        calculate x 0 0

    let isPandigitalA (xs:list<int>) =
        isPandigital <| concatenateA xs

    let findPandigitalProducts () =
        let xs = {1..200}
        xs |> Seq.collect (fun x -> xs |> Seq.map (fun y -> (x, y, x*y)))
//        |> Seq.map (fun (x, y, product) -> if isPandigitalA [x; y; product] then Some product else None)
        |> Seq.map (fun (x, y, product) -> if isPandigitalA [x; y; product] then Some (x, y, product) else None)
        |> Seq.choose id
        |> Seq.distinctBy (fun (_, _, product) -> product)
//        |> Seq.sumBy (fun (_, _, product) -> (int64)product)
//        |> Seq.sum
