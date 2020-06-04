// To get command line arguments install @types/node command: npm install -g --save-dev @types/node
// Create tsconfig.json in project's root folder command: tsc --init 
// add "typeRoots": ["./node_modules/@types"]


function bubbleSort<T>(arr: T [], test: any){
		
    let n = arr.length;
    for(let i = 0; i < n; ++i)
        for (let j = 0; j < n-i-1; j++)
            if (test(arr[j], arr[j + 1]) > 0 )
            {
                let temp: T = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
    
    
}
let fn = ( a: any, b: any ) => {
    return (a > b) ? 1 : -1;
};

let fn2 = ( a: any, b: any ) => {
    return (a < b) ? 1 : -1;
};

let arguments = process.argv;
if (arguments.length < 3) {
    throw new Error("No Arguments");
}
let array = new Array<Number>();
for (let i = 2; i < arguments.length; i++) {
    array.push(Number(arguments[i]));
}
bubbleSort(array, fn2);

array.forEach(element => {
    console.log(element);
});

