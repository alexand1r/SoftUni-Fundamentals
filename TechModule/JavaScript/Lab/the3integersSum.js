function the3intSum(arr) {
    let nums = arr[0].split(' ').map(Number);
    console.log(
        check(nums[0], nums[1], nums[2]) ||
        check(nums[1], nums[2], nums[0]) ||
        check(nums[0], nums[2], nums[1]) ||
        'No');

    function check(num1, num2, sum) {
        if (num1 > num2)
            [num1, num2] = [num2, num1];
        if (num1 + num2 != sum)
            return false;
        return `${num1} + ${num2} = ${sum}`;
    }
}

the3intSum(['20 20 30']);