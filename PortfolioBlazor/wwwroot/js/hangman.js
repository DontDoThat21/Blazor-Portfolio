//props to https://github.com/sydturn/Hangman/blob/master/word_list.txt

var words = [
    "dinosaur",
    "pickle",
    "elephant",
    "fruit",
    "basket",
    "orange",
    "yellow",
    "green",
    "blue",
    "teacher",
    "school",
    "piglet",
    "avocado",
    "armadillo",
    "peach",
    "tree",
    "alphabet",
    "weevil",
    "professor",
    "english",
    "turtle",
    "duckling",
    "peaches",
    "creams",
    "ointment",
    "dictionary",
    "swallow",
    "fluffy",
    "purple",
    "monkey",
    "dishwasher",
    "kitchen",
    "bathroom",
    "closet",
    "towelette",
    "peacock",
    "silver",
    "labrador",
    "fishes",
    "monitor",
    "tower",
    "elephant",
    "selfless",
    "egotistical",
    "demeaning",
    "selfish",
    "swedish",
    "chocolate",
    "spelling",
    "tourist",
    "attraction",
    "affection",
    "pangaea",
    "soup",
    "caramel",
    "zelda",
    "video",
    "nintendo",
    "scotland",
    "orangutan",
    "cutlery",
    "celery",
    "ferret",
    "gecko",
    "random",
    "waffles",
    "pancakes",
    "syrup",
    "canadian",
    "colour",
    "international",
    "human",
    "binder",
    "bound",
    "killer",
    "mop",
    "bucket",
    "afro",
    "afghanistan",
    "pakistan",
    "republic",
    "wheel",
    "muppet",
    "speaker",
    "woof",
    "sound",
    "analytic",
    "artistic",
    "quantum",
    "science",
    "classes",
    "early",
    "late",
    "english",
    "words",
    "spider",
    "terror",
    "emotions",
    "violin",
    "piano",
    "music",
    "sharing",
    "superficial",
    "purple",
    "basket",
    "sleepless",
    "darkness",
    "sheep",
    "acres",
    "adult",
    "advice",
    "arrangement",
    "attempt",
    "August",
    "Autumn",
    "border",
    "breeze",
    "brick",
    "calm",
    "canal",
    "Casey",
    "cast",
    "chose",
    "claws",
    "coach",
    "constantly",
    "contrast",
    "cookies",
    "customs",
    "damage",
    "Danny",
    "deeply",
    "depth",
    "discussion",
    "doll",
    "donkey",
    "Egypt",
    "Ellen",
    "essential",
    "exchange",
    "exist",
    "explanation",
    "facing",
    "film",
    "finest",
    "fireplace",
    "floating",
    "folks",
    "fort",
    "garage",
    "grabbed",
    "grandmother",
    "habit",
    "happily",
    "Harry",
    "heading",
    "hunter",
    "Illinois",
    "image",
    "independent",
    "instant",
    "January",
    "kids",
    "label",
    "Lee",
    "lungs",
    "manufacturing",
    "Martin",
    "mathematics",
    "melted",
    "memory",
    "mill",
    "mission",
    "monkey",
    "Mount",
    "mysterious",
    "neighborhood",
    "Norway",
    "nuts",
    "occasionally",
    "official",
    "ourselves",
    "palace",
    "Pennsylvania",
    "Philadelphia",
    "plates",
    "poetry",
    "policeman",
    "positive",
    "possibly",
    "practical",
    "pride",
    "promised",
    "recall",
    "relationship",
    "remarkable",
    "require",
    "rhyme",
    "rocky",
    "rubbed",
    "rush",
    "sale",
    "satellites",
    "satisfied",
    "scared",
    "selection",
    "shake",
    "shaking",
    "shallow",
    "shout",
    "silly",
    "simplest",
    "slight",
    "slip",
    "slope",
    "soap",
    "solar",
    "species",
    "spin",
    "stiff",
    "swung",
    "tales",
    "thumb",
    "tobacco",
    "toy",
    "trap",
    "treated",
    "tune",
    "University",
    "vapor",
    "vessels",
    "wealth",
    "wolf",
    "zoo"
]

let answer = '';
let maxWrong = '6';
let mistakes = 0;
let guessed = [];

function randomWord() {
    answer = words[Math.floor(Math.random() * words.length)];
}

function generateButtons() {
    let buttonsHTML = 'abcdefghijklmnopqrstuvwxyz'.split('').map(letter =>
        `
      <button
        class="btn btn-lg btn-primary m-2"
        id='` + letter + `'
        onClick="handleGuess('` + letter + `')"
      >
        ` + letter + `
      </button>
    `).join('');

    document.getElementById('keyboard').innerHTML = buttonsHTML;
}

function handleGuess(chosenLetter) {
    guessed.indexOf(chosenLetter) === -1 ? guessed.push(chosenLetter) : null;
    document.getElementById(chosenLetter).setAttribute('disabled', true);

    if (answer.indexOf(chosenLetter) >= 0) {
        guessedWord();
        checkIfGameWon();
    } else if (answer.indexOf(chosenLetter) === -1) {
        mistakes++;
        updateMistakes();
        checkIfGameLost();
        updateHangmanPicture();
    }
}

function updateHangmanPicture() {
    document.getElementById('hangmanPic').src = './images/' + mistakes + '.jpg';
}

function checkIfGameWon() {
    if (wordStatus === answer) {
        document.getElementById('keyboard').innerHTML = 'You Won!!!';
    }
}

function checkIfGameLost() {
    if (mistakes === maxWrong) {
        document.getElementById('wordSpotlight').innerHTML = 'The answer was: ' + answer;
        document.getElementById('keyboard').innerHTML = 'You Lost!!!';
    }
}

function guessedWord() {
    wordStatus = answer.split('').map(letter => (guessed.indexOf(letter) >= 0 ? letter : " _ ")).join('');

    document.getElementById('wordSpotlight').innerHTML = wordStatus;
}

function updateMistakes() {
    document.getElementById('mistakes').innerHTML = mistakes;
}

function reset() {

    try {
        mistakes = 0;
        guessed = [];
        document.getElementById('hangmanPic').src = './images/0.jpg';

        randomWord();
        guessedWord();
        updateMistakes();
        generateButtons();

    } catch (e) {

    }
}

document.getElementById('maxWrong').innerHTML = maxWrong;

randomWord();
generateButtons();
guessedWord();