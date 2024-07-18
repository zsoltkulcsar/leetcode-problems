function maximumNumber(num, change) {
    let numArray = num.split('');
    let mutated = false;

    for (let i = 0; i < numArray.length; i++) {
        const currentDigit = parseInt(numArray[i]);
        const newDigit = change[currentDigit];

        if (newDigit > currentDigit) {
            numArray[i] = newDigit.toString();
            mutated = true;
        } else if (mutated && newDigit < currentDigit) {
            break;
        } else if (mutated && newDigit == currentDigit) {
            numArray[i] = newDigit.toString();
        }
    }

    return numArray.join('');
}

console.log(maximumNumber("132", [9,8,5,0,3,6,4,2,6,8])); // Output: "832"
console.log(maximumNumber("021", [9,4,3,5,7,2,1,9,0,6])); // Output: "934"
console.log(maximumNumber("5", [1,4,7,5,3,2,5,6,9,4])); // Output: "5"