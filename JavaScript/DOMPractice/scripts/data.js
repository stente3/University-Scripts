const sedan = {
  name: "Sedans",
  image: "../assets/images/icon-sedans.svg",
  altImage: "Sedan-Icon",
  text: "Choose a sedan for its affordability and excellent fuel economy. Ideal for cruising in the city or on your next road trip.",
  class: {
    section: "main__section--sedan",
    button: "button--sedan",
  },
};

const suv = {
  name: "Suvs",
  image: "../assets/images/icon-suvs.svg",
  altImage: "Suv-Icon",
  text: "Take an SUV for its spacious interior, power, and versatility. Perfect for your next family vacation and off-road adventures.",
  class: {
    section: "main__section--suv",
    button: "button--suv",
  },
};

const luxury = {
  name: "Luxury",
  image: "../assets/images/icon-luxury.svg",
  altImage: "Suv-Luxury",
  text: "Cruise in the best car brands without the bloated prices. Enjoy the enhanced comfort of a luxury rental and arrive in style.",
  class: {
    section: "main__section--luxury",
    button: "button--luxury",
  },
};

const sections = [sedan, suv, luxury];

export default sections;
