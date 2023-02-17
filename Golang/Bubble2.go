// go run .\Bubble2.go 1 2 10 8 9 6 7 3 4 5

package main
import (
    "fmt"
    "os"
	"strconv"
)

type comparitorStrategy[t int | float64] interface {
	Execute(a, b t) int
}
  
type intValue struct {
	val int
}

func (val intValue) Execute(a, b int) int {
	if a > b {
		return 1;
	} else if (b > a) {
		return -1
	} else {
    	return 0
	}
}

func bSort[t int | float64](sortedArr []t, strategy comparitorStrategy[t]) []t {
	fmt.Println("Bubble 2")
	for i := 0; i < len(sortedArr) - 1; i++ {
		for j := 0; j < len(sortedArr) - i - 1; j++ {
			if strategy.Execute(sortedArr[j], sortedArr[j + 1]) > 0 {
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
	var strategy comparitorStrategy[int]
	strategy = intValue{0}
	sortedArr = bSort(sortedArr, strategy)

	// Print
	fmt.Println(sortedArr)
}
