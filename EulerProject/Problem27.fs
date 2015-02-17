namespace EulerProject.Core

module Problem27 =
    open EulerProject.Core.PrimeCalculator

    let internal primeMap = primeMap 100000

    let internal primeFormula n a b = (pown n 2) + (a * n) + b
    
    let rec primes n a b =
        match primeFormula n a b with
        | x when isPrimeM x primeMap -> x :: (primes (n+1) a b)
        | _ -> []

    let solve range =
        let rec calculate a b res =
            match a with 
            | x when x = range -> res
            | _ ->
                match b with
                | x when x = range -> calculate (a+1) 0 res
                | _ ->
                    let primes = primes 0 a b
                    calculate a (b+1) (((a, b), (List.length primes), a*b)::res)
                
        calculate -range -range []
        |> List.maxBy (fun (vals, length, product) -> length)
