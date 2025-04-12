function sumDigits(input) {
    let nums = "" + input[0];
    let sum = 0;

    for (let i = 0; i < nums.length; i++) {

        let num = Number(nums[i]);
        sum += num;
        
    }

    console.log(sum);
    
}

sumDigits([245678]);
sumDigits([97561]);
sumDigits([543]);