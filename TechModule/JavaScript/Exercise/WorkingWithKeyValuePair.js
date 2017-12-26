function keyValuePair(arr) {
    let dict = {};
    for (let i = 0; i < arr.length - 1; i++) {
        let tokens = arr[i].split(' ');
        let key = tokens[0];
        let value = tokens[1];
        dict[key] = value;
    }
    let wanted = arr[arr.length - 1];
    console.log(dict[wanted] || "None");
}

keyValuePair(['key value', 'key eulav', 'test tset', 'key']);
keyValuePair(['3 bla', '3 alb', '2']);