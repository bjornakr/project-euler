namespace EulerProject.Core

module Problem29 =
    let distinctTerms n =
        let powerUp (a:int) =
            List.map (fun b -> (pown (bigint a) b)) [2..n]
        List.collect powerUp [2..n]
        |> Seq.sort
        |> Seq.distinct
