// go run .\Bubble3.go 1 2 10 8 9 6 7 3 4 5

package main
import (
    "fmt"
    "os"
	"strconv"
)

func intComparitor(a, b int) int {
	if a > b {
		return 1;
	} else if (b > a) {
		return -1
	} else {
    	return 0
	}
}

type comparitorStrategy[t int | float64] func(t, t) int

func bSort[t int | float64](sortedArr []t, strategy comparitorStrategy[t]) []t {
	for i := 0; i < len(sortedArr) - 1; i++ {
		for j := 0; j < len(sortedArr) - i - 1; j++ {
			if strategy(sortedArr[j], sortedArr[j + 1]) > 0 {
				tmpVal := sortedArr[j]
				sortedArr[j] = sortedArr[j + 1]
				sortedArr[j + 1] = tmpVal
			}
		}
	}
	return sortedArr
}

func main() {
	args := os.Args[1:]
	if len(args) < 1 {
		panic("Error: No arguments")
	}

	// Copy string args to int array
	var sortedArr []int
	for i := 0; i < len(args); i++ {
		intVal, err := strconv.Atoi(args[i])
		if err != nil {
			panic(err)
		} else {
			sortedArr = append(sortedArr, intVal)
		}
	}

	// Sort
	sortedArr = bSort(sortedArr, intComparitor)

	// Print
	fmt.Println(sortedArr)
}
