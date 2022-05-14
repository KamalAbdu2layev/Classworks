let arr = [1, 2, 3, 4, "hello", 5, true, 6, 7, null];

function myFunction(arr) {
    let count = 0;
    for (let index = 0; index < arr.length; index++) {
        if (typeof arr[index] == "number" && arr[index] % 2 == 0) {
            count++;
        }
    }
    return count;
}

// console.log(myFunction(arr));

// console.log(typeof null);

function Sum() {
    let sum = 0;
    for (let index = 0; index < arguments.length; index++) {
        if (typeof arguments[index] == "number") {
            sum += arguments[index];
        }
    }
    return sum;
}

// console.log(Sum(1, 2, 3, 4, 5, "6", false, null,6));

function Reverce(word){
    let reverceWord = "";
    for (let index = 0; index < word.length;  index++) {
        reverceWord += word[index];
    }
    return reverceWord;
}

console.log(Reverce("Hello"));