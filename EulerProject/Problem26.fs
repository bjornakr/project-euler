namespace EulerProject.Core

module Problem26 =
    let recurringDecimalPatternLength divisor =
        let rec calculate dividend divisor remainders =
            match dividend % divisor with
            | 0 -> 0
            | remainder ->
                match List.tryFindIndex ((=) remainder) remainders with
                | Some index -> index + 1
                | None -> calculate (remainder * 10) divisor (remainder :: remainders)

        calculate 10 divisor []

    let solve n =
        {1..n-1}
        |> Seq.map (fun n -> (n, recurringDecimalPatternLength n))
        |> Seq.maxBy snd



module Problem26Old =
    open System.Numerics

//    let decimalString f =
//        string f
//        |> fun s -> s.Split [|'.'|]
//        |> fun sa ->
//            if Array.length sa = 1 then ""
//            else sa.[1]

    let decimalString f =
        let rec takeUntilZero s pos =
            if pos = String.length s then s
            else
                if s.[pos] = '0' then s.[0..pos-1]
                else takeUntilZero s (pos+1)
        string f
        |> fun s -> takeUntilZero s 0



    let rec recurringPattern (s:string) =
        let rec recurringPatternInternal (pat:char[]) (s:char[]) =
            let addNextChar () =
                recurringPatternInternal (Array.append pat [| s.[0] |]) s.[1..(Array.length s - 1)]

            if pat = s then pat
            elif Array.length pat >= Array.length s then [||] // No match
            elif (not <| Array.isEmpty pat) && pat = Seq.toArray (Seq.take (Array.length pat) s) //  s.[0..(Array.length pat - 1)]
                then 
                    let recPat = recurringPatternInternal pat s.[(Array.length pat)..(Array.length s - 1)]
                    match recPat with
                    | [||] -> addNextChar ()
                    | _ -> recPat
            else
                match Array.length s with
                | 1 -> [||]
                | _ -> addNextChar ()
            
        let pattern = recurringPatternInternal Array.empty (s.ToCharArray())
        match pattern with
        | [||] -> 
            if s = "" then ""
            else recurringPattern (s.Substring(1))
        | _ -> 
            System.String.Concat(pattern)


    let reccuringDecimalPattern (divisor:int) =
        let a = BigInteger.Pow(new BigInteger(10), 100000)
        a / (new BigInteger(divisor))
        |> decimalString
        |> recurringPattern


    let longest () =
        {1..999}
        |> Seq.map (fun div -> (div, String.length <| reccuringDecimalPattern div))
        |> Seq.maxBy snd
