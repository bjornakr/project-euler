namespace EulerProject.Core

module Problem31 =
    let solve goal (coins:list<int>) =
        let sortedCoins = List.rev <| List.sort coins
        let lastCoinPos = (List.length coins)-1

        let rec calculate currentSum coinPos =
            let newSum = currentSum + sortedCoins.[coinPos]
            match newSum with
            | x when x = goal -> 1
            | x when x > goal -> 0
            | _ ->
                [coinPos..lastCoinPos]
                |> List.map (fun x -> calculate newSum x)
                |> List.sum
         
        {0..lastCoinPos}
        |> Seq.map (fun x -> calculate 0 x)
        |> Seq.sum

