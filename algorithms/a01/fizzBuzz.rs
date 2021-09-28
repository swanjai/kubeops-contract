use std::io;

fn main() {
    let mut input = String::new();

    println!("[FizzBuzz] Please enter your number.");
    io::stdin().read_line(&mut input).expect("Failed to get console input");
    let input = input.trim().parse::<i32>().expect("Failed to parse int");
    fizzbuzz(input);
}

fn fizzbuzz(i:i32) {
    match (i%3, i%5) {
        (0, 0) => println!("FizzBuzz"),
        (0, _) => println!("Fizz"),
        (_, 0) => println!("Buzz"),
        (_, _) => println!("{}", i)
    }
}