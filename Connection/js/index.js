var intervalo;
var x; 
function scrollDireita(x){
  intervalo = setInterval(function(){ document.getElementById('scroller'+x).scrollLeft += 1 }  , 5);
};
function scrollEsquerda(x){
  intervalo = setInterval(function(){ document.getElementById('scroller'+x).scrollLeft -= 1 }  , 5);
};
function clearScroll(){
  clearInterval(intervalo);
};
