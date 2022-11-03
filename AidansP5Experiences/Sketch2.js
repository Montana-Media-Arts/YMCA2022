let pink;
function preload()
{
	pink = new Sprite(400, 150, 50, 100);
	//add animation
	pink.addAni('idle','assets/Idle001.png', 4);
	pink.ani.offset.y = 18;
	pink.addAni('moving', 'assets/Walk001.png', 6);
	console.log(pink.x);
}
function setup() {
	createCanvas(screen.width, screen.height);
	
}


function draw() {
	background(0); 
	fill(255,255,255);
	//textAlign(CENTER);
	//text('You are logged in!', width / 2, height / 2);
	
	frameRate(30);
	if (mouse.x < pink.x - 10) {
		
		pink.ani = 'moving';
		pink.mirror.x = true; 
		pink.vel.x = -2;
	} else if (mouse.x > pink.x + 10) {
		// if mouse is to the right
		pink.ani = 'moving';
		pink.mirror.x = false; 
		pink.vel.x = 2;
	} else {
		
		pink.ani = 'idle';
		pink.vel.x = 0;
	}
	
}



