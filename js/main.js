if(document.querySelector(".burger") != null){
    const burger = document.querySelector(".burger"); //Variable icon burger

    burger.addEventListener("click", () =>{
        burger.classList.toggle("active"); //Permet d'activer l'animation de l'icon burger
        document.querySelector(".nav_div").classList.toggle("active"); // Permet d'afficher / cacher le menu
    })
}