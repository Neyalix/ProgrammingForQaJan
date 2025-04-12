function vacation(input) {

    

    let group = input[0];
    let type = input[1];
    let day = input[2];

    let studentPrice = 0;
    let businessPrice = 0;
    let regularPrice = 0;

    let totalPirce = 0;
    if (day === 'Friday') {
        studentPrice = group * 8.45;
        if (group >=  30 ) {
            studentPrice *= 0.85;
            totalPirce = studentPrice;
        }
        businessPrice = group * 10.90;
        regularPrice = group * 15;
        if (group >= 10 && group <= 20) {
            regularPrice *= 0.90;
            totalPirce = regularPrice;
        }
    } else if(day === 'Saturday') {
        studentPrice = group * 9.80;
        if (group >=  30 ) {
            studentPrice *= 0.85;
            totalPirce = studentPrice;
        }
        businessPrice = group * 15.60;
        regularPrice = group * 20;
        if (group >= 10 && group <= 20) {
            regularPrice *= 0.90;
            totalPirce = regularPrice;
        }
    } else if(day === 'Saturday') {
        studentPrice = group * 10.45;
        if (group >=  30 ) {
            studentPrice *= 0.85;
            totalPirce = studentPrice;
        }
        businessPrice = group * 16;
        regularPrice = group * 22.50;
        if (group >= 10 && group <= 20) {
            regularPrice *= 0.90;
            totalPirce = regularPrice;
        }
    }
    console.log(totalPirce);
    





    

}

vacation([30, "Students", "Sunday"]);
vacation([40, "Regular", "Saturday"]);

