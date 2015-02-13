namespace EulerProject.Core

module PrimeCalculator =
    open System.Collections;

    let internal mapPos x = (x-3) / 2

    let internal primeMap n =        
        let bitArray = new BitArray(n, true)

        let calculate x =
            // Start: (x*3) because 'x' itself must not be marked false, as it may be prime. (x*2) is prime by default.
            // Step:  (x*2) to get the next odd number
            for i in x*3..x*2..n do
                printfn "%d" i
                bitArray.[mapPos i] <- false

        let limit = (int (sqrt <| float n))
        for i in 3..2..limit do
            calculate i
        bitArray


    let isPrime x =
        match x with
        | x when x < 2 -> false
        | 2 -> true
        | x when x % 2 = 0 -> false
        | _ -> (primeMap x).[mapPos x]
