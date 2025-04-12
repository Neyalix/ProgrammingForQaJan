function countStringOccurrences(text, word) {
    
    let string = text.split(' ');
    let counter = 0;
    for (const element of string) {
        if (element === word) {
            counter++;
        }
    }
    
    console.log(counter);
    

}

countStringOccurrences('This is a word and it also is a sentence', 'is');
countStringOccurrences('softuni is great place for learning new programming languages', 'softuni');