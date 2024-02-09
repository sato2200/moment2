document.addEventListener('DOMContentLoaded', function() {

    var colorButton = document.getElementById('colorButton');
    var resetButton = document.getElementById('resetButton');
    var originalColor = document.body.style.backgroundColor; // Spara den ursprungliga bakgrundsfärgen

    // Händelselyssnare för klick på knappen för att ändra färg
    colorButton.addEventListener('click', function() {
        // Generera en slumpmässig RGB-färg
        var randomColor = '#' + Math.floor(Math.random()*16777215).toString(16);
        
        // Ändrar bakgrundsfärgen på sidan
        document.body.style.backgroundColor = randomColor;
    });

    //Händelselyssnare för klick på knappen för att återställa färgen
    resetButton.addEventListener('click', function() {
        document.body.style.backgroundColor = originalColor; // Återställ till ursprungsfärgen
    });
});