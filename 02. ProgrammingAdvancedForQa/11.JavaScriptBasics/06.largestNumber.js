function biggerNumber(num1, num2, num3) {
    let result = 0;

    if (num1 >= num2 && num1 >= num3) {
        result += num1;
    } else if (num2 >= num1 && num2 >= num3) {
        result += num2
    } else {
        result += num3
    }

    console.log(`The largest number is ${result}.`)
}

biggerNumber(5, -3, 16);
biggerNumber(-3, -5, -22.5);