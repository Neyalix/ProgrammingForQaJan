function formatGrade(input) {
    let result;
    let grade = input;
if (grade < 3.00) {
    result = `Fail (${Math.floor(grade)})`;
    
} else if (grade >= 3.00 && grade <= 3.50){
   result = `Poor (${grade.toFixed(2)})`;
    
} else if (grade >= 3.50 && grade < 4.50) {
    result = `Good (${grade.toFixed(2)})`;
} else if (grade >= 4.50 && grade < 5.50) {
    result = `Very good (${grade.toFixed(2)})`;
    
} else if (grade >= 5.50 && grade <= 6.00) {
   result = `Excellent (${grade.toFixed(2)})`;

}

console.log(result);

}

formatGrade(3.33);
formatGrade(4.50);
formatGrade(2.99);

