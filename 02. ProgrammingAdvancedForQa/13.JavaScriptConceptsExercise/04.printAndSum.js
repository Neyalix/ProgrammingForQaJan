function printAndSum(input) {
    let start = Number(input[0]);
    let end = Number(input[1]);
    let sum = 0;
    let nums = [];
    for (let i = start; i <= end; i++){

        sum += i;
        nums.push(i);
    }
    console.log(nums.join(' '));
    
    console.log(`Sum: ${sum}`);
    
}
    printAndSum([5, 10]);
    printAndSum([0, 26]);
    printAndSum([50, 60]);