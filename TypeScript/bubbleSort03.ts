// To get command line arguments install @types/node command: npm install -g --save-dev @types/node
// Create tsconfig.json in project's root folder command: tsc --init 
// add "typeRoots": ["./node_modules/@types"]

interface IComparatorStrategy<T> {  
    Execute(a: T, b: T) : number; 
}

class IntComparator implements IComparatorStrategy<Number> {
    public Execute(a: Number, b: Number): number 
    {
        return a > b ? 1 : (b > a ) ? -1 : 0;
    }
}

function bubbleSort<T>(arr: T [], cmp:  IComparatorStrategy<T> ){
		
    let n = arr.length;
    for(let i = 0; i < n; ++i)
        for (let j = 0; j < n-i-1; j++)
            if (cmp.Execute(arr[j], arr[j + 1]) > 0 )
            {
                let temp: T = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
    
    
}

let arguments = process.argv;
if (arguments.length < 3) {
    throw new Error("No Arguments");
}
let array = new Array<Number>();
for (let i = 2; i < arguments.length; i++) {
    array.push(Number(arguments[i]));
}
bubbleSort(array,new IntComparator());

array.forEach(element => {
    console.log(element);
});

