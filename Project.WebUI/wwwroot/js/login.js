
/* ---- particles.js config ---- */

particlesJS("particles-js", {
    "particles": {
        "number": {
            "value": 60,
            "density": {
                "enable": true,
                "value_area": 1000
            }
        },
        "color": {
            "value":  ["#344455", "#ffffff"]
        },
        "shape": {
            "type": "edge",
            "stroke": {
                "width": 0,
                "color": "#000000"
            },
            "polygon": {
                "nb_sides": 5
            },
            "image": {
                "src": "img/github.svg",
                "width": 100,
                "height": 100
            }
        },
        "opacity": {
            "value": 0.5,
            "random": false,
            "anim": {
                "enable": false,
                "speed": 1,
                "opacity_min": 0.1,
                "sync": false
            }
        },
        "size": {
            "value": 4,
            "random": true,
            "anim": {
                "enable": false,
                "speed": 40,
                "size_min": 0.1,
                "sync": false
            }
        },
        "line_linked": {
            "enable": true,
            "distance": 50,
            "color": "#fff",
            "opacity": 0.5,
            "width": 1
        },
        "move": {
            "enable": true,
            "speed": 3,
            "direction": "none",
            "random": false,
            "straight": false,
            "out_mode": "out",
            "bounce": false,
            "attract": {
                "enable": false,
                "rotateX": 600,
                "rotateY": 1200
            }
        }
    },
    "retina_detect": true
});


/* ---- stats.js config ---- */
const togglePassword = document.getElementById('showPass');
const passwordInput = document.getElementById('login_password');

togglePassword.addEventListener('click',() => {
    const type = passwordInput.getAttribute('type') === 'password' ? 'text' : 'password';
    passwordInput.setAttribute('type',type);
})

const loginForm = document.querySelector('form');
loginForm.addEventListener('submit', (e) => {
    e.preventDefault();
})