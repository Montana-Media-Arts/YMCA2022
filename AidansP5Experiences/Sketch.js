//let s;
function setup() {
	createCanvas(800, 400);
  //   s = new Sprite();
	// s.height = 50;
	//s.width = 50;
}


function draw() {
	background(0,250,200); 
	fill(0);
	textAlign(CENTER);
	text('You are logged in!', width / 2, height / 2);
	//group.draw();
	
	
	//if(mouse.presses())  {
		
		let s = new Sprite(random(800), random(400), 30, 30);
		
		s.vel.x = random(-5, 5);
		s.vel.y = random(-5, 5);
		console.log(s.velocity.x +","+ s.velocity.y);
		
	//}
	
	
}



