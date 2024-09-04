function fizzBuzz(n) {
    // Loop from 1 to n (inclusive)
    for (let i = 1; i <= n; i++) {
        // Check if the number is divisible by both 3 and 5
        if (i % 3 === 0 && i % 5 === 0) {
            console.log("FizzBuzz"); // Print "FizzBuzz" for multiples of both 3 and 5
        // Check if the number is divisible by 3
        } else if (i % 3 === 0) {
            console.log("Fizz"); // Print "Fizz" for multiples of 3
        // Check if the number is divisible by 5
        } else if (i % 5 === 0) {
            console.log("Buzz"); // Print "Buzz" for multiples of 5
        } else {
            console.log(i); // Print the number if it's not divisible by 3 or 5
        }
    }
}

// Example usage: print numbers from 1 to 15 with FizzBuzz substitutions
fizzBuzz(15);
