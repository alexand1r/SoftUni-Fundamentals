function productOf3Nums(arr) {
    let nums = arr.map(Number);
    let countNegative = 0;
    for (let num of nums) {
        if (num == 0) {
            console.log("Positive");
            break;
        }
        else if (num < 0)
            countNegative++;
    }
    if (countNegative % 2 == 1)
        console.log("Negative");
    else
        console.log("Positive");
}

productOf3Nums(['3', '2', '-1']);