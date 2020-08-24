//use std::time::Instant;

fn main() {
    //let start =  Instant::now();
    let max = 10000000 
    let mut sum = 0i64;
    for i in 1..max {
        if i % 3 == 0 || i % 5 == 0 {
            sum += i;
        }
    }

    //let end =  Instant::now();

    println!("{}",sum);   
    //println!("{:?}", end.duration_since(start)); 
}
