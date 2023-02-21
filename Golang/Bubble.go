// go run .\Bubble.go 1 2 10 8 9 6 7 3 4 5

package main
import (
    "fmt"
    "os"
	"strconv"
)

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
	for i := 0; i < len(sortedArr) - 1; i++ {
		for j := 0; j < len(sortedArr) - i - 1; j++ {
			if sortedArr[j] > sortedArr[j + 1] {
				tmpVal := sortedArr[j]
				sortedArr[j] = sortedArr[j + 1]
				sortedArr[j + 1] = tmpVal
			}
		}
	}

	// Print
	fmt.Println(sortedArr)
}
