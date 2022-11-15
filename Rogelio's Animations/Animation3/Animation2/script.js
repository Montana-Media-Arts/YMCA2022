const cvs = document.querySelector("canvas");
const c = cvs.getContext("2d");

cvs.width = window.innerWidth;
cvs.height = window.innerHeight;

window.addEventListener("resize", function() {
  cvs.width = window.innerWidth;
  cvs.height = window.innerHeight;
});

let mouse = {
  x: undefined,
  y: undefined
};

window.addEventListener("mousemove", function(e) {
  mouse.x = event.x;
  mouse.y = event.y;
});

class Diamond {
  constructor(x, y, dx, dy, width) {
    this.x = x;
    this.y = y;
    this.dx = dx;
    this.dy = dy;
    this.width = width;
    this.minWidth = width;
    this.maxWidth = width * 3;

    let colorArray = ["#335c67", "#fff3b0", "#e09f3e", "#9e2a2b", "#540b0e"];

    this.color = colorArray[Math.floor(Math.random() * colorArray.length)];
  }

  draw = () => {
    c.beginPath();
    c.moveTo(this.x, this.y);
    c.lineTo(this.x - this.width / 2, this.y);
    c.lineTo(this.x, this.y + this.width / 2);
    c.lineTo(this.x + this.width / 2, this.y);
    c.lineTo(this.x, this.y - this.width / 2);
    c.lineTo(this.x - this.width / 2, this.y);
    c.closePath();

    c.fillStyle = this.color;
    c.fill();

    this.update();
  };

  update = () => {
    if (
      this.x + this.width / 2 >= window.innerWidth ||
      this.x - this.width / 2 <= 0
    ) {
      this.dx = -this.dx;
    }

    if (
      this.y + this.width / 2 >= window.innerHeight ||
      this.y - this.width / 2 <= 0
    ) {
      this.dy = -this.dy;
    }

    this.x += this.dx;
    this.y += this.dy;

    // interactivity
    if (
      mouse.x - this.x < 80 &&
      mouse.x - this.x > -80 &&
      mouse.y - this.y < 80 &&
      mouse.y - this.y > -80 &&
      this.width < this.maxWidth
    ) {
      this.width += 1;
      this.x -= 1;
      this.y -= 1;
    } else if (this.width > this.minWidth) {
      this.width -= 1;
      this.x += 1;
      this.y += 1;
    }
  };
}

let diamondArray = [];

for (let i = 0; i < 400; i++) {
  let width = Math.random() * 30 + 5;
  let x = Math.random() * window.innerWidth;
  let dx = (Math.random() - 0.5) * 2;
  let y = Math.random() * window.innerHeight;
  let dy = (Math.random() - 0.5) * 2;
  diamondArray.push(new Diamond(x, y, dx, dy, width));
}

function animate() {
  requestAnimationFrame(animate);
  c.clearRect(0, 0, window.innerWidth, window.innerHeight);

  diamondArray.forEach(diamond => {
    diamond.draw();
  });
}

animate();

	