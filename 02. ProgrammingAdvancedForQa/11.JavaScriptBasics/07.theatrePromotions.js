function promotion(dayTime, age) {
  let price = 0;

  if (age < 0 || age > 122) {
    console.log("Error!");
    return;
  }

  if (dayTime === "Weekday") {
    if (age >= 0 && age <= 18) {
      price = 12;
    } else if (age > 18 && age <= 64) {
      price = 18;
    } else if (age > 64 && age <= 122) {
      price = 12;
    }
  } else if (dayTime === "Weekend") {
    if (age >= 0 && age <= 18) {
      price = 15;
    } else if (age > 18 && age <= 64) {
      price = 20;
    } else if (age > 64 && age <= 122) {
      price = 15;
    }
  } else if (dayTime === "Holiday") {
    if (age >= 0 && age <= 18) {
      price = 5;
    } else if (age > 18 && age <= 64) {
      price = 12;
    } else if (age > 64 && age <= 122) {
      price = 10;
    }
  }
  console.log(`${price}$`);
}

promotion("Weekday", 42);
promotion("Holiday", -12);
promotion("Holiday", 15);
