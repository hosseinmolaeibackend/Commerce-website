var MainSlider  = document.getElementById("MainImage");
      var Images  = document.querySelectorAll("img");
      var Index = 0;
      for (let i = 0; i < Images.length; i++) {
            Images[i].addEventListener("click",()=>{
                  MainSlider.src=Images[i].src;
                  Index=i;
                  Images[i].style=" border: #4CC9F0 2px solid !important; ";
                  for (let j = 0; j < Images.length; j++) {
                       if(j!=Index){
                         Images[j].style=" border: #fff 2px solid !important; ";
                        }
                   }
              });
      }

      var Heart=document.getElementById("heart");
      Heart.addEventListener("click",()=>{
      Heart.style="color: #ff0400;";
      });