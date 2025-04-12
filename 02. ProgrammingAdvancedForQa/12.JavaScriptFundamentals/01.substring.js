function substring(string, startIndex, count) {

    let result;

    result = string.substring(startIndex, (count + startIndex))

    console.log(result);      
    
}

substring('ASentence', 1, 8);
substring('SkipWord', 4, 7);

