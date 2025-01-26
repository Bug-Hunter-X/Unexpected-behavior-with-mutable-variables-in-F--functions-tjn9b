let mutable xRef = ref 10
let mutable yRef = ref 20

let add xRef yRef = !xRef + !yRef

let z = add xRef yRef

printfn "%d" z

xRef := 100
yRef := 200

printfn "%d" (add xRef yRef)