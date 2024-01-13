document.getElementById('enterButton').addEventListener('click', function() {
    document.getElementById('welcomeScreen').style.display = 'none';
    document.getElementById('mainContent').style.display = 'block';
});

const typewriteElement = document.getElementById('typewrite');
const text = 'aqui tu presentación';

function typeWrite(text, i, fncallback){
    if (i < text.length){
        typewriteElement.innerHTML = text.subtring(0,i + 1) + '<span aria-hidden="true"></span>';
        setTimeout(function(){
            typeWrite(text, i + 1, fncallback)
        }, 100);
    }
        else if (typeof fncallback== 'function'){
            setTimeout(fncallback, 700);
        }
    }
typeWrite(text, 0, function(){
    
})
