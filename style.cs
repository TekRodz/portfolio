*, *::before, *::after {
  margin: 0;
  padding: 0;
  font-size: 3vh;
  box-sizing: border-box;
  font-family: "niveau-grotesk";
}

header {
  display: flex;
  background-image: url("img/background_home.jpg");
  background-size: cover;
  height: 100vh;
  width: 100%;
  align-items: center;
  justify-content: center;
}
header h1 {
  font-size: 13vh;
  color: white;
  font-family: "hero-new";
  font-weight: bold;
  text-align: center;
}

.home_section article, .project_page article {
  height: 100vh;
  display: flex;
  flex-direction: row;
  justify-content: space-evenly;
}
.home_section article img, .project_page article img {
  height: 75%;
  align-items: center;
  margin: 10vh;
}
.home_section article div, .project_page article div {
  text-align: center;
}
.home_section article hr, .project_page article hr {
  margin-top: 15vh;
  width: 45%;
  height: 2vh;
}
.home_section article p, .project_page article p {
  margin: 8vh auto;
  text-align: justify;
  width: 50%;
  font-size: 3vh;
}
.home_section article button, .project_page article button {
  padding: 1vh 3vh;
  font-size: 4vh;
  background-color: #611618;
  color: white;
  font-family: "hero-new";
  font-weight: bold;
  border: none;
}
.home_section .presentation img, .project_page .presentation img {
  margin-left: 25vh;
}
.home_section .presentation hr, .project_page .presentation hr {
  margin-left: 8vh;
}
.home_section .skills img, .project_page .skills img {
  margin-right: 25vh;
}
.home_section .skills hr, .project_page .skills hr {
  margin-left: 15vh;
}
.home_section h2, .project_page h2 {
  padding: 2vh 6vw;
  border-top: 4px solid #C30E0E;
  border-bottom: 4px solid #C30E0E;
  font-family: "hero-new";
}
.home_section .project img, .project_page .project img {
  margin: 0;
  margin-top: 10vh;
  height: auto;
  width: 20vw;
}
.home_section .project p, .project_page .project p {
  position: relative;
  top: -25vh;
  width: inherit;
  background-color: #611618;
  text-align: center;
  width: 25vw;
}
.home_section .project p a, .project_page .project p a {
  color: white;
  font-size: 4vh;
  font-family: "hero-new";
  text-decoration: none;
}
@media (max-width: 1528px) {
  .home_section article, .project_page article {
    height: auto;
    flex-direction: column;
    align-items: center;
  }
  .home_section article img, .project_page article img {
    width: 50vw;
  }
  .home_section .presentation img, .project_page .presentation img {
    margin: 10vh auto;
  }
  .home_section .skills img, .project_page .skills img {
    margin: 10vh auto;
  }
}
.home_section .project img, .project_page .project img {
  width: 80vw;
}

footer {
  display: grid;
  grid-template-columns: repeat(3, 1fr);
  background-color: #212121;
  padding: 2vh 0;
}
footer p, footer a {
  display: flex;
  align-items: center;
  justify-content: center;
  font-size: 3vh;
  color: white;
}
footer a {
  text-decoration: none;
}
footer a:hover {
  color: #C30E0E;
  transition: all 0.5s;
}
footer div {
  display: flex;
  justify-content: space-evenly;
}
footer div img {
  width: 4vw;
}

@media (max-width: 1000px) {
  footer {
    display: flex;
    flex-direction: column;
  }
  footer div img {
    margin: 2vh;
    width: 4vh;
  }
}
.skills article {
  display: flex;
  flex-direction: column;
  align-items: center;
}
.skills hr {
  height: 1vh;
  width: 75%;
  margin-top: 4vh;
}
.skills h3 {
  margin-top: 4vh;
  font-size: 4vh;
}
.skills p {
  margin-top: 4vh;
  width: 65%;
  text-align: justify;
  margin-bottom: 4vh;
}
.skills ul {
  list-style: disc;
  display: block;
  margin-bottom: 4vh;
}

.subtitle {
  margin-top: 4vh;
}

.project_page {
  background-color: #474747;
  color: white;
}

.img_project_portrait {
  display: grid;
  grid-template-columns: repeat(4, 1fr);
  grid-template-rows: repeat(2, 1fr);
  grid-gap: 1vw;
  justify-content: center;
  padding-bottom: 4vh;
}
.img_project_portrait img {
  margin: auto;
  width: 15vw;
}
.img_project_portrait .img_1, .img_project_portrait .img_4 {
  width: 20vw;
}
.img_project_portrait .img_1 {
  grid-column: 1/3;
  grid-row: 1/1;
}
.img_project_portrait .img_4 {
  grid-column: 3/5;
  grid-row: 1/1;
}

.img_project_landscape {
  display: grid;
  grid-template-columns: repeat(2, 1fr);
  grid-template-rows: repeat(2, 1fr);
  grid-gap: 1vh;
  justify-content: center;
  padding-bottom: 4vh;
}
.img_project_landscape img {
  margin: auto;
  width: 40vw;
}

@media (max-width: 425px) {
  .project_page img {
    margin: 4vh auto;
    width: 60vw;
  }

  .img_project_portrait, .img_project_landscape {
    display: flex;
    flex-direction: column;
  }
  .img_project_portrait img, .img_project_portrait .img_1, .img_project_portrait .img_4, .img_project_landscape img, .img_project_landscape .img_1, .img_project_landscape .img_4 {
    margin: 4vh auto;
    width: 60vw;
  }
}
nav {
  position: sticky;
  position: -webkit-sticky;
  top: 0;
  background-color: #212121;
  color: white;
  display: grid;
  grid-template-columns: 25% 75%;
}

h2 {
  font-size: 5vh;
  text-align: center;
  font-weight: bold;
  font-family: "hero-new";
}

ul {
  display: flex;
  list-style: none;
  justify-content: space-evenly;
  flex-direction: row;
  align-items: center;
}
ul a {
  color: white;
  text-decoration: none;
}
ul .actual_page {
  border-bottom: 4px solid #C30E0E;
}

@media (max-width: 1000px) {
  h2 {
    font-size: 5vw;
  }

  ul a {
    font-size: 3vw;
  }
}
hr {
  background-color: #C30E0E;
  border: none;
}

/*# sourceMappingURL=style.cs.map */
