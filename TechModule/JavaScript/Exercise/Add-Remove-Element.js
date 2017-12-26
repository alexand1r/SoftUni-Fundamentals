function addRemoveElement(arr) {
    let result = [];
    for (let i = 0; i < arr.length; i++) {
        let tokens = arr[i].split(' ');
        let command = tokens[0];
        let num = parseInt(tokens[1]);
        if (command == "add")
            result.push(num);
        else if (command == "remove"
            && num > -1 && num < result.length)
            result.splice(num, 1);
    }
    console.log(result.join("\n"));
}

addRemoveElement(['add 3', 'add 5', 'remove 1', 'add 2']);