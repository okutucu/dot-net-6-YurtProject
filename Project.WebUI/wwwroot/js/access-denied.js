let str = document.getElementById('access-denied').innerHTML.toString();
let i = 0;
document.getElementById('access-denied').innerHTML = "";

setTimeout(function() {
    let se = setInterval(function() {
        i++;
        document.getElementById('access-denied').innerHTML = str.slice(0, i) + "|";
        if (i == str.length) {
            clearInterval(se);
            document.getElementById('access-denied').innerHTML = str;
        }
    }, 10);
},0);