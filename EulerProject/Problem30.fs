namespace EulerProject.Core

module Problem30 =

    let cutUp x =
        x.ToString().ToCharArray()
        |> Array.map (fun c -> int (c.ToString()))
        |> Seq.ofArray

    let sumOfPoweredDigits x n =
        cutUp x
        |> Seq.map (fun x -> pown x n)
        |> Seq.sum

    let sumsOfPowersOfEachDigit n =
        {1..10000000}
        |> Seq.map (fun x -> (x, sumOfPoweredDigits x n))
//        |> Seq.toList
        
    let equalSumAndDigits n = 
        sumsOfPowersOfEachDigit n
        |> Seq.filter (fun (a, b) -> a <> 1 && a = b)        
        |> Seq.map (fun (a, b) -> a)