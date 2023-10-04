import data from "./data.js";

const root = document.querySelector(".main");

for (let i = 0; i < data.length; i++) {
  const section = document.createElement("section");
  section.classList.add("main__section", data[i].class.section);
  section.innerHTML = `
          <img class="section__image" src=${data[i].image} alt=${data[i].altImage} />
          <h2 class="heading">${data[i].name}</h2>
          <p class="paragraph">${data[i].text}</p>
          <button class="button ${data[i].class.button}">Learn More</button>
        `;
  root.appendChild(section);
}
