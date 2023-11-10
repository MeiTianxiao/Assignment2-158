function showImage(button) {
    var popupImage = document.getElementById('popupImage');
    popupImage.src = button.getAttribute('https://photo.tuchong.com/3827175/f/1166022209.jpg');
    popupImage.style.display = 'block';
}

function hideImage(button) {
    var popupImage = document.getElementById('popupImage');
    popupImage.style.display = 'none';
}