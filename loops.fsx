
// for

let list = [0;1;2;3;4;5;6;7;8;9]

for i in list do
    printfn "%d" i

// tabuada do 97 numa variavel, por que nao?
let tabuada() =
    for i in 1 .. 10 do
        printfn $"97 x {i} = { 97 * i }"

tabuada()
