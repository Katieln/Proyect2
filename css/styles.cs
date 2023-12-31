* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
}

body {
  background-image: url(https://images.unsplash.com/photo-1590523741831-ab7e8b8f9c7f?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Mnx8cGxheWFzfGVufDB8fDB8fHww&w=1000&q=80);
}

h1 {
  color: rgb(144, 0, 255);
  text-shadow: 2px 2px rgba(200, 125, 254, 0.573);
}

header {
  background-color: rgba(104, 68, 246, 0.1882352941);
  padding: 10px;
  gap: 10px;
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
}
header .logo {
  background-color: rgba(207, 194, 252, 0.812);
  padding: 20px;
  border-radius: 20px;
  gap: 10px;
  display: flex;
  flex-direction: column;
  justify-content: space-around;
  align-items: center;
}
header .logo h1 {
  color: rgb(139, 6, 255);
  text-shadow: 3px 3px 6px blueviolet;
  font-family: "dancing script";
  font-size: 40px;
}
header .logo-img {
  border-radius: 40px;
  height: 200px;
}

nav ul {
  background-color: rgba(178, 203, 253, 0.6470588235);
  list-style: none;
  padding: 10px;
  border-radius: 10px;
}
nav ul li {
  background-color: rgba(243, 254, 255, 0.487);
  padding: 8px;
  margin: 10px;
  border-radius: 10px;
}
nav ul li a {
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  text-decoration: none;
  color: black;
  text-shadow: 3px 3px 3px white;
  font-family: "indie flower";
  font-size: 25px;
}
nav ul li a:hover {
  color: rgb(157, 0, 255);
  text-shadow: 2px 2px 4px rgb(92, 92, 171);
  font-size: 30px;
}

@media (min-width: 480px) {
  header {
    background-color: rgba(188, 197, 255, 0.392);
    display: flex;
    flex-direction: row;
    justify-content: space-around;
    align-items: center;
  }
}
@media (min-width: 1024px) {
  header {
    background-color: rgba(68, 0, 255, 0.12);
    display: flex;
    flex-direction: row;
    justify-content: space-around;
    align-items: center;
  }
  nav ul {
    display: flex;
    flex-direction: row;
    justify-content: center;
    align-items: center;
  }
}
section {
  background-color: rgba(76, 152, 206, 0.203);
  padding: 5px;
  width: 100%;
}

.container {
  max-width: 100%;
  background-color: rgba(162, 207, 255, 0.121);
  display: flex;
  flex-direction: row;
  justify-content: space-around;
  align-items: stretch;
  padding: 10px;
}
.container .row {
  width: 100%;
  background-color: rgba(163, 181, 243, 0.3176470588);
  padding: 20px;
  gap: 10px;
  display: flex;
  flex-direction: row;
  justify-content: space-around;
  align-items: stretch;
}
.container .row .card {
  margin: 5px;
  width: 200px;
  height: 350px;
  border: 10px solid rgba(167, 183, 225, 0.27);
  padding: 5px;
  display: flex;
  flex-direction: column;
  justify-content: space-around;
  align-items: stretch;
  gap: 10px;
  background-color: rgba(18, 134, 229, 0.3607843137);
}
.container .row .card-img-top {
  height: 50%;
  object-fit: cover;
  display: flex;
  flex-direction: column;
  justify-content: space-between;
  align-items: center;
}
.container .row .card-body {
  height: 50%;
  background-color: rgba(223, 217, 255, 0.3450980392);
  display: flex;
  flex-direction: column;
  justify-content: space-around;
  align-items: center;
  color: rgb(34, 34, 34);
  text-shadow: 2px 3px 3px rgb(240, 240, 240);
  font-family: "indie flower";
  font-size: 60px;
}
.container .row .card-body .btn {
  background-color: rgb(72, 212, 255);
  color: white;
  text-shadow: 2px 2px 3px rgb(188, 201, 249);
  font-family: arial;
  font-size: 18px;
  border: 3px solid rgba(45, 99, 156, 0.144);
}

footer {
  background-color: rgba(79, 150, 244, 0.453);
  width: 100%;
  max-height: 6%;
  padding: 5px;
  position: fixed;
  bottom: 0;
  font-size: 10px;
  box-sizing: border-box;
  display: flex;
  flex-direction: row;
  justify-content: space-around;
  align-items: center;
}
footer .red {
  display: flex;
  flex-direction: row;
  justify-content: center;
  align-items: center;
  background-color: rgba(176, 215, 231, 0.545);
  border-radius: 15px;
  height: 48px;
  flex-shrink: 0;
  width: 45%;
  padding: 10px;
  gap: 10px;
  margin: 10px;
}
footer .red .icon {
  height: 37px;
}
footer .redes {
  flex-shrink: 0;
  box-sizing: border-box;
  max-height: 50px;
  padding: 5px;
  border-radius: 10px;
  width: 60%;
  background-color: rgba(218, 248, 255, 0.591);
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  color: black;
  text-shadow: 2px 2px 2px white;
  font-family: "borel";
  font-size: 10px;
  font-size: 70%;
}
footer .redes h4 {
  margin-top: 12px;
  font-size: 10px;
}

@media (min-width: 480px) {
  footer {
    height: 10%;
    display: flex;
    flex-direction: row;
    justify-content: space-around;
    align-items: center;
  }
  footer .red {
    display: flex;
    flex-direction: row;
    justify-content: space-around;
    align-items: center;
    background-color: rgba(196, 242, 255, 0.554);
    width: 40%;
    height: 70px;
    text-decoration: none;
  }
  footer .red .redes {
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    height: 100px;
    width: 63%;
    background-color: rgba(204, 239, 244, 0.597);
    font-size: 11px;
    padding: 20px;
    color: black;
    text-shadow: 2px 2px 2px white;
    font-family: "borel";
    font-size: 10px;
  }
  footer .red .redes h4 {
    margin-top: 20px;
    font-size: 15px;
  }
}
.text-home {
  background-color: rgba(132, 156, 243, 0.425);
  padding: 15px;
  transform: skewY(5deg);
}
.text-home h2 {
  background-color: rgba(0, 255, 255, 0.4);
}
.text-home p {
  background-color: rgba(0, 170, 255, 0.625);
}

aside {
  background-color: rgba(172, 205, 249, 0.835);
  padding: 10px;
  margin: 10px;
  margin-bottom: 58px;
}
aside .blog {
  margin: 15px;
}

* {
  box-sizing: border-box;
}

.container-pr {
  max-width: 100%;
  object-fit: contain;
  background-color: rgba(125, 198, 238, 0.298);
}
.container-pr .row-pr {
  display: flex;
  flex-direction: column;
  justify-content: space-around;
  align-items: center;
  gap: 10px;
  width: 100%;
  object-fit: contain;
}
.container-pr .card-pr {
  display: flex;
  flex-direction: column;
  justify-content: space-around;
  align-items: stretch;
  width: 300px;
  border: 10px solid rgba(167, 208, 225, 0.473);
  background-color: rgba(85, 0, 255, 0.199);
  object-fit: contain;
}
.container-pr .card-img-pr {
  height: 40%;
  object-fit: contain;
  margin: 10px;
}
.container-pr .card-img-pr-1 {
  border-radius: 10px;
  height: 80%;
  margin: 10px;
}

.container-ct {
  background-color: rgba(0, 89, 255, 0.214);
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  border: 3px 3px 3px red;
  width: 100%;
}
.container-ct table {
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  border: 3px 3px 3px red;
  margin: 30px;
  width: 100%;
}
.container-ct tr {
  width: 80%;
  background-color: rgba(108, 232, 220, 0.521);
  padding: 10px;
  margin: 20px;
  gap: 10px;
  border: 3px 3px 3px red;
}
.container-ct tr th {
  padding: 5px;
  border: 3px 3px 3px red;
  width: 80%;
}
.container-ct tr td {
  background-color: rgba(81, 112, 221, 0.302);
  margin: 10px;
  padding: 10px;
  border: 2px 2px 3px black;
  width: 80%;
}

.gps {
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  width: 100%;
}
.gps-img {
  margin: 20px;
}

@media (min-width: 1024px) {
  .vestidos {
    width: 100%;
  }
  .vestidos .container-pr {
    max-width: 100%;
    display: flex;
    flex-direction: row;
    justify-content: space-around;
    align-items: stretch;
  }
  .vestidos .container-pr .row-pr {
    background-color: rgba(255, 188, 188, 0.611);
    width: 100%;
    display: flex;
    flex-direction: row;
    justify-content: space-around;
    align-items: center;
  }
  .vestidos .container-pr .row-pr .card-pr {
    height: 350px;
    display: flex;
    flex-direction: column;
    justify-content: space-around;
    align-items: stretch;
  }
}
.viajes-img {
  width: 90%;
}
.viajes-img-1 {
  height: 500px;
}

.cont-viajes {
  background-color: rgba(0, 255, 255, 0.276);
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  text-align: center;
  padding: 20px;
  padding-left: 30px;
}

.box-viajes {
  background-color: rgba(89, 103, 232, 0.349);
  padding: 20px;
  margin: 20px;
}

.viajes-img-1 {
  width: 90%;
  height: auto;
}

@media (min-width: 1024px) {
  .viajes-img {
    height: 400px;
    width: auto;
  }
  .viajes-img-1 {
    width: 30%;
    height: auto;
  }
  .cont-viajes-1 {
    background-color: rgba(0, 255, 255, 0.276);
    display: flex;
    flex-direction: row;
    justify-content: space-around;
    align-items: center;
    text-align: center;
    padding: 20px;
    padding-left: 30px;
  }
}
.auto {
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  background-color: rgba(0, 255, 255, 0.439);
  padding: 20px;
  gap: 30px;
}
.auto-img {
  width: 100%;
}

.pelis {
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  background-color: rgba(250, 235, 215, 0.509);
  padding: 20px;
}
.pelis-img {
  width: 100%;
}

.contacto {
  margin-bottom: 70px;
}

/*# sourceMappingURL=styles.cs.map */
