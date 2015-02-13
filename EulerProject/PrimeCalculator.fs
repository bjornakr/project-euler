namespace EulerProject.Core

module PrimeCalculator =
    open System.Collections;

    let isEven x =
        (x % 2) = 0

    let isOdd x =
        not <| isEven x

    let internal primeMap n =        
        let bitArray = new BitArray(n, true)

        let calculate x =
            let mapPos x = (x-3) / 2
            seq { for i in 2..(int (sqrt <| float n)) do yield x * i }
            |> Seq.map (fun i -> bitArray.[mapPos i] <- false)

        let a = [3..n]
        let b = Seq.filter isOdd a
        let c = Seq.map (fun x -> calculate x) b
        bitArray
    
    let isPrime x =
        match x with
        | x when x < 2 -> false
        | 2 -> true
        | x when isEven x -> false
        | _ -> (primeMap 1000).[(x-3) / 2]
