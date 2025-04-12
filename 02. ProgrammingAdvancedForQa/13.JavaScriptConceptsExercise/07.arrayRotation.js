function arrRotation(input, rotation) {
    let rotationCount = rotation % input.length; // Prevent unnecessary full rotations

    for (let i = 0; i < rotationCount; i++) {
        let firstElement = input.shift(); // Remove first element
        input.push(firstElement); // Add it to the end
    }

    console.log(input.join(' '));
    
    
}

arrRotation([51, 47, 32, 61, 21], 2)