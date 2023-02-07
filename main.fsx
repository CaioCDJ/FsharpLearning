
// Ok funcoes em variaveis 
let sign num =
   if num > 0 then "positive"
   elif num < 0 then "negative"
   else "zero"

let main() =
   printfn $"sign 5: {sign 5}"

main()