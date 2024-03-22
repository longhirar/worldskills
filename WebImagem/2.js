
document.querySelector('#main-imagem').addEventListener('click', (ev) => {
    console.log(ev.button)
    var imagem = document.querySelector('#main-imagem');
    var nextzoom = parseFloat(imagem.getAttribute('data-zoom')) +0.1;
    imagem.style.transform = `scale(${nextzoom})`;
    imagem.setAttribute('data-zoom', nextzoom);
})

document.querySelector('#main-imagem').oncontextmenu = (e) => {
    var imagem = document.querySelector('#main-imagem');
    var nextzoom = parseFloat(imagem.getAttribute('data-zoom')) -0.1;
    nextzoom = nextzoom <= 0.1 ? 0.1 : nextzoom
    imagem.style.transform = `scale(${nextzoom})`;
    imagem.setAttribute('data-zoom', nextzoom);
    return false;
}

document.querySelector('#img-upload').addEventListener('change', () => {
    document.querySelector('#main-imagem').src = document.querySelector('#img-upload').files[0].name
});