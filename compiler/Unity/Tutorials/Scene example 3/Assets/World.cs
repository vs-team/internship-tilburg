#pragma warning disable 162,108,618
using Casanova.Prelude;
using System.Linq;
using System;
using System.Collections.Generic;
using UnityEngine;
namespace Game {public class World : MonoBehaviour{
public static int frame;
void Update () { Update(Time.deltaTime, this); 
 frame++; }
public bool JustEntered = true;


public void Start()
	{
		Zombies = (

Enumerable.Empty<Zombie>()).ToList<Zombie>();
		Landscapes = (

(new Cons<Landscape>(new Landscape(new UnityEngine.Vector3(0f,0f,0f)),(new Cons<Landscape>(new Landscape(new UnityEngine.Vector3(0f,0f,-80f)),(new Cons<Landscape>(new Landscape(new UnityEngine.Vector3(0f,0f,-160f)),(new Empty<Landscape>()).ToList<Landscape>())).ToList<Landscape>())).ToList<Landscape>())).ToList<Landscape>()).ToList<Landscape>();
		Jeep = new Truck();
		
}
		public Truck Jeep;
	public List<Landscape> __Landscapes;
	public List<Landscape> Landscapes{  get { return  __Landscapes; }
  set{ __Landscapes = value;
 foreach(var e in value){if(e.JustEntered){ e.JustEntered = false;
}
} }
 }
	public List<Zombie> Zombies;
	public List<Landscape> ___a00;
	public Landscape ___headOfA00;
	public UnityEngine.Transform ___headOfATransform00;
	public UnityEngine.Vector3 ___headOfAPosition00;
	public System.Single count_down1;

System.DateTime init_time = System.DateTime.Now;
	public void Update(float dt, World world) {
var t = System.DateTime.Now;		this.Rule2(dt, world);

		Jeep.Update(dt, world);
		for(int x0 = 0; x0 < Landscapes.Count; x0++) { 
			Landscapes[x0].Update(dt, world);
		}
		for(int x0 = 0; x0 < Zombies.Count; x0++) { 
			Zombies[x0].Update(dt, world);
		}
		this.Rule0(dt, world);
		this.Rule1(dt, world);
	}

	public void Rule2(float dt, World world) 
	{
	Zombies = (

(Zombies).Select(__ContextSymbol2 => new { ___a21 = __ContextSymbol2 })
.Where(__ContextSymbol3 => !(__ContextSymbol3.___a21.Destroyed))
.Select(__ContextSymbol4 => __ContextSymbol4.___a21)
.ToList<Zombie>()).ToList<Zombie>();
	}
	




	int s0=-1;
	public void Rule0(float dt, World world){ 
	switch (s0)
	{

	case -1:
	___a00 = (

(Landscapes).Select(__ContextSymbol5 => new { ___e00 = __ContextSymbol5 })
.Where(__ContextSymbol6 => __ContextSymbol6.___e00.Checkpoint.isEntered)
.Select(__ContextSymbol7 => __ContextSymbol7.___e00)
.ToList<Landscape>()).ToList<Landscape>();
	UnityEngine.Debug.Log(("a.count before if ") + (___a00.Count));
	if(((___a00.Count) > (0)))
	{

	goto case 1;	}else
	{

	s0 = -1;
return;	}
	case 1:
	UnityEngine.Debug.Log(("a.count ") + (___a00.Count));
	___headOfA00 = ___a00.Head();
	___headOfATransform00 = ___headOfA00.transform;
	___headOfAPosition00 = ___headOfATransform00.position;
	Landscapes = new Cons<Landscape>(new Landscape(new UnityEngine.Vector3(0f,0f,(___headOfAPosition00.z) - (240f))), (Landscapes)).ToList<Landscape>();
	s0 = -1;
return;	
	default: return;}}
	

	int s1=-1;
	public void Rule1(float dt, World world){ 
	switch (s1)
	{

	case -1:
	count_down1 = 2f;
	goto case 2;
	case 2:
	if(((count_down1) > (0f)))
	{

	count_down1 = ((count_down1) - (dt));
	s1 = 2;
return;	}else
	{

	goto case 0;	}
	case 0:
	Zombies = new Cons<Zombie>(new Zombie(Jeep.Position), (Zombies)).ToList<Zombie>();
	s1 = -1;
return;	
	default: return;}}
	





}
public class Landscape{
public int frame;
public bool JustEntered = true;
private UnityEngine.Vector3 StartP;
	public int ID;
public Landscape(UnityEngine.Vector3 StartP)
	{JustEntered = false;
 frame = World.frame;
		UnityLandscape = UnityLandscape.Instantiate(StartP);
		
}
		public UnityCheckpoint Checkpoint{  get { return UnityLandscape.Checkpoint; }
 }
	public UnityEngine.Vector3 Position{  get { return UnityLandscape.Position; }
  set{UnityLandscape.Position = value; }
 }
	public UnityLandscape UnityLandscape;
	public UnityEngine.Animation animation{  get { return UnityLandscape.animation; }
 }
	public UnityEngine.AudioSource audio{  get { return UnityLandscape.audio; }
 }
	public UnityEngine.Camera camera{  get { return UnityLandscape.camera; }
 }
	public UnityEngine.Collider collider{  get { return UnityLandscape.collider; }
 }
	public UnityEngine.Collider2D collider2D{  get { return UnityLandscape.collider2D; }
 }
	public UnityEngine.ConstantForce constantForce{  get { return UnityLandscape.constantForce; }
 }
	public System.Boolean enabled{  get { return UnityLandscape.enabled; }
  set{UnityLandscape.enabled = value; }
 }
	public UnityEngine.GameObject gameObject{  get { return UnityLandscape.gameObject; }
 }
	public UnityEngine.GUIElement guiElement{  get { return UnityLandscape.guiElement; }
 }
	public UnityEngine.GUIText guiText{  get { return UnityLandscape.guiText; }
 }
	public UnityEngine.GUITexture guiTexture{  get { return UnityLandscape.guiTexture; }
 }
	public UnityEngine.HideFlags hideFlags{  get { return UnityLandscape.hideFlags; }
  set{UnityLandscape.hideFlags = value; }
 }
	public UnityEngine.HingeJoint hingeJoint{  get { return UnityLandscape.hingeJoint; }
 }
	public UnityEngine.Light light{  get { return UnityLandscape.light; }
 }
	public System.String name{  get { return UnityLandscape.name; }
  set{UnityLandscape.name = value; }
 }
	public UnityEngine.ParticleEmitter particleEmitter{  get { return UnityLandscape.particleEmitter; }
 }
	public UnityEngine.ParticleSystem particleSystem{  get { return UnityLandscape.particleSystem; }
 }
	public UnityEngine.Renderer renderer{  get { return UnityLandscape.renderer; }
 }
	public UnityEngine.Rigidbody rigidbody{  get { return UnityLandscape.rigidbody; }
 }
	public UnityEngine.Rigidbody2D rigidbody2D{  get { return UnityLandscape.rigidbody2D; }
 }
	public System.String tag{  get { return UnityLandscape.tag; }
  set{UnityLandscape.tag = value; }
 }
	public UnityEngine.Transform transform{  get { return UnityLandscape.transform; }
 }
	public System.Boolean useGUILayout{  get { return UnityLandscape.useGUILayout; }
  set{UnityLandscape.useGUILayout = value; }
 }
	public void Update(float dt, World world) {
frame = World.frame;

		this.Rule0(dt, world);

	}





	int s0=-1;
	public void Rule0(float dt, World world){ 
	switch (s0)
	{

	case -1:
	if(!(Checkpoint.isEntered))
	{

	s0 = -1;
return;	}else
	{

	goto case 1;	}
	case 1:
	Checkpoint.isEntered = Checkpoint.isEntered;
	s0 = 0;
return;
	case 0:
	Checkpoint.isEntered = false;
	s0 = -1;
return;	
	default: return;}}
	






}
public class Truck{
public int frame;
public bool JustEntered = true;
	public int ID;
public Truck()
	{JustEntered = false;
 frame = World.frame;
		Velocity = new UnityEngine.Vector3(0f,0f,0f);
		TruckScript = TruckScript.Instantiate();
		
}
		public UnityEngine.Vector3 Position{  get { return TruckScript.Position; }
  set{TruckScript.Position = value; }
 }
	public UnityEngine.Vector3 Rotation{  get { return TruckScript.Rotation; }
  set{TruckScript.Rotation = value; }
 }
	public TruckScript TruckScript;
	public UnityEngine.Vector3 Velocity;
	public UnityEngine.Animation animation{  get { return TruckScript.animation; }
 }
	public UnityEngine.AudioSource audio{  get { return TruckScript.audio; }
 }
	public UnityEngine.Camera camera{  get { return TruckScript.camera; }
 }
	public UnityEngine.Collider collider{  get { return TruckScript.collider; }
 }
	public UnityEngine.Collider2D collider2D{  get { return TruckScript.collider2D; }
 }
	public UnityEngine.ConstantForce constantForce{  get { return TruckScript.constantForce; }
 }
	public System.Boolean enabled{  get { return TruckScript.enabled; }
  set{TruckScript.enabled = value; }
 }
	public UnityEngine.GameObject gameObject{  get { return TruckScript.gameObject; }
 }
	public UnityEngine.GUIElement guiElement{  get { return TruckScript.guiElement; }
 }
	public UnityEngine.GUIText guiText{  get { return TruckScript.guiText; }
 }
	public UnityEngine.GUITexture guiTexture{  get { return TruckScript.guiTexture; }
 }
	public UnityEngine.HideFlags hideFlags{  get { return TruckScript.hideFlags; }
  set{TruckScript.hideFlags = value; }
 }
	public UnityEngine.HingeJoint hingeJoint{  get { return TruckScript.hingeJoint; }
 }
	public UnityEngine.Light light{  get { return TruckScript.light; }
 }
	public System.String name{  get { return TruckScript.name; }
  set{TruckScript.name = value; }
 }
	public UnityEngine.ParticleEmitter particleEmitter{  get { return TruckScript.particleEmitter; }
 }
	public UnityEngine.ParticleSystem particleSystem{  get { return TruckScript.particleSystem; }
 }
	public UnityEngine.Renderer renderer{  get { return TruckScript.renderer; }
 }
	public UnityEngine.Rigidbody rigidbody{  get { return TruckScript.rigidbody; }
 }
	public UnityEngine.Rigidbody2D rigidbody2D{  get { return TruckScript.rigidbody2D; }
 }
	public System.String tag{  get { return TruckScript.tag; }
  set{TruckScript.tag = value; }
 }
	public UnityEngine.Transform transform{  get { return TruckScript.transform; }
 }
	public System.Boolean useGUILayout{  get { return TruckScript.useGUILayout; }
  set{TruckScript.useGUILayout = value; }
 }
	public void Update(float dt, World world) {
frame = World.frame;

		this.Rule0(dt, world);
		this.Rule1(dt, world);
		this.Rule2(dt, world);
	}





	int s0=-1;
	public void Rule0(float dt, World world){ 
	switch (s0)
	{

	case -1:
	Position = ((Position) + (((Velocity) * (dt))));
	s0 = -1;
return;	
	default: return;}}
	

	int s1=-1;
	public void Rule1(float dt, World world){ 
	switch (s1)
	{

	case -1:
	if(UnityEngine.Input.GetKey(KeyCode.W))
	{

	goto case 17;	}else
	{

	goto case 13;	}
	case 17:
	Velocity = ((Velocity) + (new UnityEngine.Vector3(0f,0f,-1f)));
	s1 = 13;
return;
	case 13:
	if(((((UnityEngine.Input.GetKey(KeyCode.A)) && (((Velocity.z) > (0f))))) && (((Velocity.x) > (-20f)))))
	{

	goto case 14;	}else
	{

	goto case 10;	}
	case 14:
	Velocity = ((Velocity) + (new UnityEngine.Vector3(-0.2f,0f,0f)));
	s1 = 10;
return;
	case 10:
	if(((((UnityEngine.Input.GetKey(KeyCode.D)) && (((Velocity.z) > (0f))))) && (((20f) > (Velocity.x)))))
	{

	goto case 11;	}else
	{

	goto case 7;	}
	case 11:
	Velocity = ((Velocity) + (new UnityEngine.Vector3(0.2f,0f,0f)));
	s1 = 7;
return;
	case 7:
	if(((UnityEngine.Input.GetKey(KeyCode.Space)) && (((2.99f) > (Velocity.z)))))
	{

	goto case 8;	}else
	{

	goto case 4;	}
	case 8:
	Velocity = ((Velocity) + (new UnityEngine.Vector3(0f,0f,3f)));
	s1 = 4;
return;
	case 4:
	if(((Velocity.z) > (0.19f)))
	{

	goto case 5;	}else
	{

	goto case 1;	}
	case 5:
	Velocity = ((Velocity) + (new UnityEngine.Vector3(0f,0f,0.2f)));
	s1 = 1;
return;
	case 1:
	if(((((Velocity.z) > (-0.19f))) && (((0.19f) > (Velocity.z)))))
	{

	goto case 2;	}else
	{

	s1 = -1;
return;	}
	case 2:
	Velocity = Vector3.zero;
	s1 = -1;
return;	
	default: return;}}
	

	int s2=-1;
	public void Rule2(float dt, World world){ 
	switch (s2)
	{

	case -1:
	Rotation = Rotation;
	Velocity.x = 0f;
	s2 = -1;
return;	
	default: return;}}
	





}
public class Zombie{
public int frame;
public bool JustEntered = true;
private UnityEngine.Vector3 pos;
	public int ID;
public Zombie(UnityEngine.Vector3 pos)
	{JustEntered = false;
 frame = World.frame;
		UnityZombie = UnityZombie.Instantiate(pos);
		JeepPos = pos;
		
}
		public System.Boolean Destroyed{  get { return UnityZombie.Destroyed; }
  set{UnityZombie.Destroyed = value; }
 }
	public UnityEngine.Vector3 JeepPos;
	public UnityEngine.Vector3 Position{  get { return UnityZombie.Position; }
  set{UnityZombie.Position = value; }
 }
	public UnityEngine.Quaternion Rotation{  get { return UnityZombie.Rotation; }
  set{UnityZombie.Rotation = value; }
 }
	public UnityZombie UnityZombie;
	public UnityEngine.Animation animation{  get { return UnityZombie.animation; }
 }
	public UnityEngine.AudioSource audio{  get { return UnityZombie.audio; }
 }
	public UnityEngine.Camera camera{  get { return UnityZombie.camera; }
 }
	public UnityEngine.Collider collider{  get { return UnityZombie.collider; }
 }
	public UnityEngine.Collider2D collider2D{  get { return UnityZombie.collider2D; }
 }
	public UnityEngine.ConstantForce constantForce{  get { return UnityZombie.constantForce; }
 }
	public UnityEngine.Vector3 currenta{  get { return UnityZombie.currenta; }
  set{UnityZombie.currenta = value; }
 }
	public System.Boolean enabled{  get { return UnityZombie.enabled; }
  set{UnityZombie.enabled = value; }
 }
	public UnityEngine.GameObject gameObject{  get { return UnityZombie.gameObject; }
 }
	public UnityEngine.GUIElement guiElement{  get { return UnityZombie.guiElement; }
 }
	public UnityEngine.GUIText guiText{  get { return UnityZombie.guiText; }
 }
	public UnityEngine.GUITexture guiTexture{  get { return UnityZombie.guiTexture; }
 }
	public UnityEngine.HideFlags hideFlags{  get { return UnityZombie.hideFlags; }
  set{UnityZombie.hideFlags = value; }
 }
	public UnityEngine.HingeJoint hingeJoint{  get { return UnityZombie.hingeJoint; }
 }
	public UnityEngine.Light light{  get { return UnityZombie.light; }
 }
	public System.String name{  get { return UnityZombie.name; }
  set{UnityZombie.name = value; }
 }
	public UnityEngine.ParticleEmitter particleEmitter{  get { return UnityZombie.particleEmitter; }
 }
	public UnityEngine.ParticleSystem particleSystem{  get { return UnityZombie.particleSystem; }
 }
	public UnityEngine.Renderer renderer{  get { return UnityZombie.renderer; }
 }
	public UnityEngine.Rigidbody rigidbody{  get { return UnityZombie.rigidbody; }
 }
	public UnityEngine.Rigidbody2D rigidbody2D{  get { return UnityZombie.rigidbody2D; }
 }
	public System.Single speed{  get { return UnityZombie.speed; }
  set{UnityZombie.speed = value; }
 }
	public System.String tag{  get { return UnityZombie.tag; }
  set{UnityZombie.tag = value; }
 }
	public UnityEngine.Vector3 targeta{  get { return UnityZombie.targeta; }
  set{UnityZombie.targeta = value; }
 }
	public UnityEngine.Transform transform{  get { return UnityZombie.transform; }
 }
	public System.Boolean useGUILayout{  get { return UnityZombie.useGUILayout; }
  set{UnityZombie.useGUILayout = value; }
 }
	public void Update(float dt, World world) {
frame = World.frame;		this.Rule0(dt, world);
		this.Rule2(dt, world);
		this.Rule1(dt, world);
		this.Rule3(dt, world);
	}

	public void Rule0(float dt, World world) 
	{
	JeepPos = world.Jeep.Position;
	}
	

	public void Rule2(float dt, World world) 
	{
		currenta = Position;
	targeta = JeepPos;
	}
	



	int s1=-1;
	public void Rule1(float dt, World world){ 
	switch (s1)
	{

	case -1:
	if(((Position) == (JeepPos)))
	{

	goto case 1;	}else
	{

	goto case 2;	}
	case 1:
	Rotation = new UnityEngine.Quaternion(0f,0f,0f,0f);
	Destroyed = false;
	s1 = -1;
return;
	case 2:
	Rotation = Rotation;
	Destroyed = false;
	s1 = -1;
return;	
	default: return;}}
	

	int s3=-1;
	public void Rule3(float dt, World world){ 
	switch (s3)
	{

	case -1:
	if(((Position) == (JeepPos)))
	{

	goto case 6;	}else
	{

	goto case 7;	}
	case 6:
	Position = new UnityEngine.Vector3(0f,0f,0f);
	speed = 0f;
	Destroyed = false;
	s3 = -1;
return;
	case 7:
	Position = Position;
	speed = ((1f) * (dt));
	Destroyed = false;
	s3 = -1;
return;	
	default: return;}}
	





}
}                     