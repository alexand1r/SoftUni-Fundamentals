function objecsToJSON(arr) {
    objects = {};
    for (let i = 0; i < arr.length; i++) {
        let tokens = arr[i].split(' -> ');
        let key = tokens[0];
        let value = tokens[1];
        if (!isNaN(value))
            value = parseInt(value);
        objects[key] = value;
    }

    let toString = JSON.stringify(objects);
    console.log(toString);
}

objecsToJSON(['name -> Angel', 'surname -> Georgiev', 'age ->20']);