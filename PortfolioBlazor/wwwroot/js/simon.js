var w, h, g, my = {};
function simonMain() {
    var version = '0.5';
    my.winRoundN = 15
    my.btnOffOpacity = 0.3
    var s = '';
    s += '<style>'
    s += '.simon-button { position: absolute; border:none; width: 48%; height: 48%; overflow: hidden; box-shadow: 0 5px 5px 0 rgba(0,0,0,1);}'
    s += '.simon-1 { top: 0; left: 0; background: #34e89e; }'
    s += '.simon-2 { top: 0; right: 0; background: #ef3b36; }'
    s += '.simon-3 { bottom: 0; right: 0; background: #1cb5e0; }'
    s += '.simon-4 { bottom: 0; left: 0; background: #ffc371; }'
    s += '</style>'
    my.sndHome = (document.domain == 'localhost') ? '/mathsisfun/images/sounds/' : '/images/sounds/'
    s += '<audio id="sndWin" src="' + my.sndHome + 'fanfare.mp3" preload="auto"></audio>';
    s += '<audio id="sndAuto" src="' + my.sndHome + 'snap.mp3" preload="auto"></audio>';
    s += '<audio id="sndFlip" src="' + my.sndHome + 'pop.mp3" preload="auto"></audio>';
    s += '<audio id="sndYes" src="' + my.sndHome + 'up.mp3" preload="auto"></audio>';
    my.snds = [];
    my.soundQ = true
    for (var i = 0; i < 4; i++) {
        s += '<audio id="chime' + i + '" src="' + my.sndHome + 'simon' + (i + 1) + '.mp3" preload="auto"></audio>';
    }
    s += '<div id="main" style="position:relative; width:100%;  margin:auto; display:block; ">';
    s += '<div style="position: relative; border-radius: 50%; margin: auto; padding: 5vmin; width: 75vmin; height: 75vmin; background: rgba(0,0,49,0.6); ">'
    s += '<div style="position: relative; border-radius: 50%; width: 100%; height: 100%; overflow: hidden;">'
    s += '<button class="simon-button simon-1" id="0"></button>'
    s += '<button class="simon-button simon-2" id="1"></button>'
    s += '<button class="simon-button simon-3" id="2"></button>'
    s += '<button class="simon-button simon-4" id="3"></button>'
    s += '<div id="circ" style="position: absolute; margin: 30% 30%; border-radius: 50%; border: 3px solid #111; width: 38%;   height: 38%; background: radial-gradient(ellipse at center, rgba(0, 0, 0, 0) 0%, rgba(0, 0, 0, 0) 60%, #777777 80%), #004; color: #fff; box-shadow: 2px 2px 10px 0 rgba(0, 0, 0, 0.5);" onclick="circDo()">'
    s += '</div>'
    s += '</div>'
    s += '<div id="msg" style="display: flex; align-items: center; justify-content: center; text-align:center; position:absolute; left: 40%; top:40%; font: 9vmin Arial; width:20%; height:20%; color:white; pointer-events: none;"></div>'
    s += '</div>'
    s += '<canvas id="canvas1" style=" width:' + w + 'px; height:' + h + 'px; left: 0px; top: 0px; border: none; pointer-events: none; z-index:2;"></canvas>';
    s += optPopHTML();
    s += '<div style="text-align: right;">';
    s += '</div>';
    s += '</div>';
    s += '</div>';
    document.write(s);
    var el = document.getElementById('canvas1');
    var ratio = 3;
    el.width = w * ratio;
    el.height = h * ratio;
    el.style.width = w + "px";
    el.style.height = h + "px";
    g = el.getContext("2d");
    g.setTransform(ratio, 0, 0, ratio, 0, 0);
    my.buttons = document.getElementsByClassName('simon-button')
    my.strictQ = false
    for (var button = 0; button < my.buttons.length; button++) {
        var btn = my.buttons[button]
        btn.onmousedown = buttonClick;
        btn.style.opacity = my.btnOffOpacity
    }
    msg('Press', '#bcf')
}
function circHi(onQ) {
    var div = document.getElementById('circ')
    if (onQ) {
        div.style.border = "3px solid #7ab"
        div.style.background = "radial-gradient(ellipse at center, rgba(0, 0, 0, 0) 0%, rgba(0, 0, 0, 0) 60%, #777777 80%), #008"
    } else {
        div.style.border = "3px solid #111"
        div.style.background = "radial-gradient(ellipse at center, rgba(0, 0, 0, 0) 0%, rgba(0, 0, 0, 0) 60%, #777777 80%), #004"
    }
}
function circDo() {
    console.log('circDo')
    newGame()
}
function Game() {
    this.playerTurn = false;
    this.pattern = [];
    this.steps = 1;
}
function newGame() {
    my.game = new Game();
    msg('1')
    newRound()
}
function Round() {
    var p = my.game.pattern
    var last0 = p[p.length - 1]
    var last1 = p[p.length - 2]
    var OKQ = true
    var next = 0
    do {
        OKQ = true
        next = Math.floor(Math.random() * 4)
        if (p.length < 2) {
            if (next == last0)
                OKQ = false
        }
        if (p.length < 5) {
            if (next == last0 && next == last1)
                OKQ = false
        }
        console.log('Round', p.length, next, OKQ)
    } while (!OKQ) p.push(next);
    this.patternLength = my.game.steps;
    this.pattern = my.game.pattern;
    this.playerPattern = [];
    this.counter = 0;
    this.speed = 500 - this.patternLength * 10;
}
function newRound() {
    my.round = new Round();
    showPattern();
    console.log(my.round.pattern);
}
function showPattern() {
    my.game.playerTurn = false;
    for (var x = 0; x < my.round.patternLength; x++) {
        setTimeout(buttonGlow.bind(null, my.round.pattern[x], my.round.speed * 0.5), my.round.speed * x);
    }
    setTimeout(function () {
        my.game.playerTurn = true;
    }, my.round.speed * my.round.patternLength);
}
function buttonClick(button) {
    if (my.game.playerTurn) {
        var buttonIndex = button.target.id;
        my.round.playerPattern.push(parseInt(buttonIndex));
        buttonGlow(button);
        check();
    }
}
function check() {
    if (my.round.playerPattern[my.round.counter] === my.round.pattern[my.round.counter]) {
        my.round.counter++;
        if (my.round.counter === my.round.patternLength) {
            my.game.playerTurn = false;
            if (my.game.steps === my.winRoundN) {
                msg('Well Done', 'gold')
                winAnim()
                setTimeout(newGame, 4000);
            } else {
                my.game.steps++;
                circHi(true)
                setTimeout(function () {
                    soundPlay('sndYes')
                    msg(my.game.steps)
                    circHi(false)
                }, 500);
                setTimeout(newRound, 1500);
            }
        }
    } else {
        if (my.strictQ) {
            msg('Nope', 'pink')
            setTimeout(newGame, 2000);
        } else {
            my.game.playerTurn = false;
            my.round.counter = 0;
            my.round.playerPattern = [];
            msg('?')
            setTimeout(function () {
                msg(my.game.steps)
                showPattern();
            }, 1500);
        }
    }
}
function buttonGlow(button, delay, fadeSpeed) {
    var pressed = button.target === undefined ? button : button.target.id;
    my.buttons[pressed].style.opacity = 1;
    soundPlay('chime' + pressed, true);
    setTimeout(fade.bind(null, pressed, fadeSpeed !== undefined ? fadeSpeed : 100), delay !== undefined ? delay : 100);
}
function toggleStrict() {
    my.strictQ = !my.strictQ;
    strictIcon.innerHTML = my.strictQ ? '<i class="fa fa-check"></i>' : '<i class="fa fa-times"></i>';
}
function fade(buttonIndex, fadeSpeed) {
    my.buttons[buttonIndex].style.opacity -= 0.1;
    if (my.buttons[buttonIndex].style.opacity > my.btnOffOpacity) {
        setTimeout(fade.bind(null, buttonIndex), fadeSpeed);
    }
}
function winAnim() {
    var ms = 130
    var rounds = 5
    for (var button = 0; button < my.buttons.length; button++) {
        for (var i = 0; i < rounds; i++) {
            setTimeout(buttonGlow.bind(null, button), ms * (button + 4 * i));
        }
    }
}
function msg(s, clr) {
    clr = typeof clr !== 'undefined' ? clr : 'white'
    var div = document.getElementById('msg')
    div.innerHTML = s
    div.style.color = clr
}
function soundBtnHTML() {
    var onClr = 'blue'
    var offClr = '#bbb'
    var s = ''
    s += '<style> '
    s += ' .speaker { height: 30px; width: 30px; position: relative; overflow: hidden; display: inline-block; vertical-align:top; } '
    s += ' .speaker span { display: block; width: 9px; height: 9px; background-color:' + onClr + '; margin: 10px 0 0 1px; }'
    s += ' .speaker span:after { content: ""; position: absolute; width: 0; height: 0; border-style: solid; border-color: transparent ' + onClr + ' transparent transparent; border-width: 10px 16px 10px 15px; left: -13px; top: 5px; }'
    s += ' .speaker span:before { transform: rotate(45deg); border-radius: 0 60px 0 0; content: ""; position: absolute; width: 5px; height: 5px; border-style: double; border-color:' + onClr + '; border-width: 7px 7px 0 0; left: 18px; top: 9px; transition: all 0.2s ease-out; }'
    s += ' .speaker:hover span:before { transform: scale(.8) translate(-3px, 0) rotate(42deg); }'
    s += ' .speaker.mute span:before { transform: scale(.5) translate(-15px, 0) rotate(36deg); opacity: 0; }'
    s += ' .speaker.mute span { background-color:' + offClr + '; }'
    s += ' .speaker.mute span:after {border-color: transparent ' + offClr + ' transparent ' + offClr + ';}'
    s += ' </style>'
    s += '<div id="sound" onClick="soundToggle()" class="speaker"><span></span></div>'
    return s
}
function soundPlay(name, simulQ) {
    if (!my.soundQ)
        return
    simulQ = typeof simulQ !== 'undefined' ? simulQ : true
    if (simulQ) {
        if (name.length > 0) {
            var div = document.getElementById(name)
            if (div.currentTime > 0 && div.currentTime < div.duration) {
                console.log('soundPlay cloned', div.currentTime, div.duration)
                div.cloneNode(true).play()
            } else {
                div.play()
            }
        }
    } else {
        my.snds.push(name)
        soundPlayQueue()
    }
}
function soundPlayQueue() {
    var div = document.getElementById(my.snds[0])
    div.play()
    div.onended = function () {
        my.snds.shift();
        if (my.snds.length > 0)
            soundPlayQueue();
    }
        ;
}
function soundToggle() {
    var btn = 'sound'
    if (my.soundQ) {
        my.soundQ = false
        document.getElementById(btn).classList.add("mute")
    } else {
        my.soundQ = true
        document.getElementById(btn).classList.remove("mute")
    }
}
function radioHTML(prompt, id, lbls, checkId, func) {
    var s = '';
    s += '<div style="position:relative; margin:auto; background-color:lightblue;  margin: 5px 0 1px 0; padding: 5px 0 5px 0;">';
    s += '<div style="font: bold 16px Arial;">';
    s += prompt;
    s += '</div>';
    s += '<div style="display:inline-block; border: 1px solid white; border-radius:5px; padding:3px; margin:3px; background-xnor:rgba(255,255,255,0.5);">';
    for (var i = 0; i < lbls.length; i++) {
        var lbl = lbls[i]
        var idi = id + i;
        var chkStr = (lbl.id == checkId) ? ' checked ' : '';
        s += '<input id="' + idi + '" type="radio" name="' + id + '" value="' + lbl.id + '" onclick="' + func + '(' + i + ');" autocomplete="off" ' + chkStr + ' >';
        s += '<label for="' + idi + '">' + lbl.name + ' </label>';
    }
    s += '</div>';
    s += '</div>';
    return s;
}
function optPopHTML() {
    var s = '';
    s += '<div id="optpop" style="position:absolute; left:-500px; top:20px; width:320px; padding: 5px; border-radius: 9px; font:14px Arial; background-color: #bcd; box-shadow: 10px 10px 5px 0px rgba(40,40,40,0.75); transition: all linear 0.3s; opacity:0; text-align: center; ">';
    s += '<div style="float:right; margin: 0 0 5px 10px; font:16px Arial;">';
    s += '<button onclick="optYes()" style="z-index:2; font: 22px Arial;" class="btn" >&#x2714;</button>';
    s += '</div>';
    s += '</div>';
    return s;
}
function optPop() {
    var pop = document.getElementById('optpop');
    pop.style.transitionDuration = "0.3s";
    pop.style.opacity = 1;
    pop.style.zIndex = my.zIndex + 1
    pop.style.left = (w - 340) / 2 + 'px';
}
function optYes() {
    var pop = document.getElementById('optpop');
    pop.style.opacity = 0;
    pop.style.zIndex = 1;
    pop.style.left = '-999px';
    stockPassBtnUpdate()
    console.log('optYes', my.suitRule, my.stockPerN, my.stockPassMax, my.tabDropKingQ, my.tabShowFrontQ, my.autoFdnQ)
}
function optNo() {
    var pop = document.getElementById('optpop');
    pop.style.opacity = 0;
    pop.style.zIndex = 1;
    pop.style.left = '-999px';
}
function tabDropKingToggle() {
    my.tabDropKingQ = !my.tabDropKingQ;
    toggleBtn("tabDropKingQ", my.tabDropKingQ);
}
function toggleBtn(btn, onq) {
    if (onq) {
        document.getElementById(btn).classList.add("hi");
        document.getElementById(btn).classList.remove("lo");
    } else {
        document.getElementById(btn).classList.add("lo");
        document.getElementById(btn).classList.remove("hi");
    }
}
CanvasRenderingContext2D.prototype.roundRect = function (x, y, w, h, r) {
    if (w < 2 * r)
        r = w / 2;
    if (h < 2 * r)
        r = h / 2;
    this.beginPath();
    this.moveTo(x + r, y);
    this.arcTo(x + w, y, x + w, y + h, r);
    this.arcTo(x + w, y + h, x, y + h, r);
    this.arcTo(x, y + h, x, y, r);
    this.arcTo(x, y, x + w, y, r);
    this.closePath();
    return this;
}
