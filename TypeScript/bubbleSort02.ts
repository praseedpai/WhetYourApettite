// To get command line arguments install @types/node command: npm install -g --save-dev @types/node
// Create tsconfig.json in project's root folder command: tsc --init 
// add "typeRoots": ["./node_modules/@types"]

let arguments = process.argv;
if (arguments.length < 3) {
    throw new Error("No Arguments");
}
let array = new Array<Number>();
for (let i = 2; i < arguments.length; i++) {
    array.push(Number(arguments[i]));
}
bubbleSort(array);

function bubbleSort(arr: Array<Number>) {
    let arrLen = arr.length;
    for(let i = 0; i < arrLen; ++i) {
        for (let j = 0; j < arrLen-i-1; j++) {
            if (arr[j] > arr[j + 1]) {
                let temp = arr[j]; 
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
}

array.forEach(element => {
    console.log(element);
});