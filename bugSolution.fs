let x = 10
let y = 20

let add x y = 
    let mutable x1 = x
    let mutable y1 = y
    x1 <- x1 + y1
    y1 <- y1 + x1
    x1 + y1

let result = add x y
printf "%d" result

// Alternative solution using immutable variables
let add2 x y = 
    let sum = x + y
    (sum, x + sum)

let (sum, finalResult) = add2 x y
printfn "%d %d" sum finalResult