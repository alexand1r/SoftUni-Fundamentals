function storingObjects(arr) {
    objects = [];
    for (let i = 0; i < arr.length; i++) {
        let tokens = arr[i].split(' -> ');
        let name = tokens[0];
        let age = tokens[1];
        let grade = tokens[2];
        let object = [];
        object.name = name;
        object.age = age;
        object.grade = grade;
        objects.push(object);
    }
    for (let object of objects) {
        console.log(`Name: ${object.name}`);
        console.log(`Age: ${object.age}`);
        console.log(`Grade: ${object.grade}`);
    }
}

storingObjects(['Pesho -> 13 -> 6.00', 'Ivan -> 12 -> 5.57'])