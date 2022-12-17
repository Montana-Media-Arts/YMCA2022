//let s;
function setup() {
	createCanvas(screen.width, screen.height);
	fullscreen();
	allSprites.collider = 'static';
	allSprites.shapeColor = color(255);
	walls = new Group();
	walls.w = 30;
	walls.h = 5000;

	let wallTop = new walls.Sprite(screen.width / 2, 1);
	wallTop.rotation = 90;

	new walls.Sprite(0, screen.height / 2);
	new walls.Sprite(screen.width, screen.height / 2);

	ball = new Sprite(width / 2, height - 200, 100, 'dynamic');
	ball.bounciness = 1;
	ball.friction = 0;

	paddle = new Sprite(width / 2, height - 50, 200, 20, 'dynamic');
	paddle.rotationLock = true;

	ball.collide(paddle, (ball, paddle) => {
		ball.direction += (ball.x - paddle.x) / 2;
		ball.speed = 8;
	});
}


function draw() {
	background(0,250,200); 
	fill(0);
	//textAlign(CENTER);
	//text('Bounces'+ 1, width / 2, height / 5);
	
		paddle.moveTowards(mouse.x, 750 - 50, 1);
		if (mouse.presses()) {
		ball.x = width / 2;
		ball.y = height - 200;
		ball.direction = 90 + random(-10, 10);
		ball.speed = 10;
		}
	
}



