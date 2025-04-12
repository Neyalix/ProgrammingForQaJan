function censoredWord(text, word) {
    
let result = text.replace(word, censored(word));

while (result.includes(word)) {
    result = result.replace(word, censored(word));

}

console.log(result);

    function censored(word) {
        let result = '';
        for (let i = 0; i < word.length; i++) {
            result += '*';
        }
        return result;
    }

}

censoredWord('A small sentence with some words small', 'small')