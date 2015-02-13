namespace EulerProject.Core

module PrimeCalculator =
    open System.Collections;

    let isEven x =
        (x % 2) = 0

    let isOdd x =
        not <| isEven x

    let internal primeMap n =        

        let calculate x =
            let bitArray = new BitArray(n, true)
            let mapPos x = (x-3) / 2
            let limit = int (sqrt <| float n)
            for i in 1..limit do
                bitArray.Set(mapPos (i*x), false)
//            ignore(seq { for i in 1..limit do yield x * i }
//            |> Seq.map (fun j -> bitArray.Set(mapPos j, false)))
            bitArray

        let rec crunch (primeMaps:list<BitArray>) =
            match primeMaps with
            | h::t -> h.And(crunch t)
            | _ -> new BitArray(n, true)


        let a = [3..(int (sqrt <| float n))]
        let b = Seq.filter isOdd a
        let c = Seq.map (fun x -> calculate x) a
        crunch (Seq.toList c)
    


    let isPrime x =
        match x with
        | x when x < 2 -> false
        | 2 -> true
        | x when isEven x -> false
        | _ -> (primeMap 1000).[(x-3) / 2]
