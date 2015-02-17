namespace EulerProject.Core

module NumberUtilities =
    let concatenate x y =
        let rec calculate a b =
            let m = a * 10
            let n = b / 10
            match n with
            | 0 -> m + y
            | _ -> calculate m n
        calculate x y

    let rec concatenateA (xs:list<int>) =
        match xs with
        | [] -> 0
        | [y] -> y
        | [y1; y2] -> concatenate y1 y2
        | y::ys -> concatenate y (concatenateA <| ys)

