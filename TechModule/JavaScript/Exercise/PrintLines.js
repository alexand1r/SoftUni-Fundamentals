function printLines(arr) {
    for (let line of arr)
        if (line != "Stop")
            console.log(line);
        else
            break;
}