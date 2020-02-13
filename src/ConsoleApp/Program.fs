// Learn more about F# at http://fsharp.org

open System
open Excel.FinancialFunctions;

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"

    let tahsilatlar = [| 0.; 850.; 821.;582.;408.;1226.;642.;611.;849.;850.;850.;850.;-8949.71829155 |] |> List.ofArray
    let tarihler = [| DateTime(2019,1,31); DateTime(2019,3,29); DateTime(2019,4,30); DateTime(2019,5,31); DateTime(2019,6,28); DateTime(2019,7,31);DateTime(2019,8,29);DateTime(2019,9,30);DateTime(2019,10,31);DateTime(2019,11,29);DateTime(2020,1,3);DateTime(2020,1,31);DateTime(2020,1,31)|] |> List.ofArray

    let xirr = Financial.XIrr(tahsilatlar,tarihler)
    let dirr = Financial.DIrr(tahsilatlar,tarihler,365.)

    0 // return an integer exit code

    
    
    
    
    
    
    

