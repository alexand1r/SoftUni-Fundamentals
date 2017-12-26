function setValuestoIndexes(arr) {
    let n = Number(arr[0]);
    let nums = {};
    for (let i = 1; i <= 3; i++) {
        let line = arr[i].split(' - ').map(Number);
        let index = Number(line[0]);
        let value = Number(line[1]);
        nums[index] = value;
    }
    for (let i = 0; i < n; i++){
        if (nums[i] == null)
            nums[i] = 0;
    }
    for (let i = 0; i < n; i++){
        console.log(nums[i]);
    }
}

setValuestoIndexes(['3', '0 - 5', '1 - 6', '2 - 7']);
setValuestoIndexes(['2', '0 - 5', '0 - 6', '0 - 7']);