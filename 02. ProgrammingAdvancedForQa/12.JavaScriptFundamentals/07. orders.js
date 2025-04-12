function orders(product, count) {
  let coffee = 1.5;
  let water = 1.0;
  let coke = 1.4;
  let snacks = 2.0;
  let result = 0;

  switch (product) {
    case "coffee":
      result += coffee * count;
      break;
    case "water":
      result += water * count;
      break;
    case "coke":
      result += coke * count;
      break;
    case "snacks":
      result += snacks * count;
      break;
  }
  console.log(result.toFixed(2));
}

orders("water", 5);
orders("coffee", 2);
