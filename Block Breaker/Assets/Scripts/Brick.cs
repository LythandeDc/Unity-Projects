using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public AudioClip crack;

	private int maxHits;
	
	public Sprite[] hitSprites;
	
	private int timesHit;
	
	private LevelManager levelManager;
	
	public static int breackableCount = 0;
	
	private bool isBreakable;
	
	public GameObject smoke;

	// Use this for initialization
	void Start () {
		isBreakable = (this.tag == "Breakable");
		timesHit = 0;
		if(isBreakable){
			breackableCount++;
		}
		levelManager = GameObject.FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnCollisionEnter2D(Collision2D collision) {
		AudioSource.PlayClipAtPoint ( crack, transform.position);
		if(isBreakable){			
			HandleHits();	
		}
	}
	
	void HandleHits() {
		timesHit++;
		maxHits = hitSprites.Length + 1;
		if(maxHits <= timesHit){
			breackableCount--;
			levelManager.BrickDestroyed();
			GameObject smokePuff = (GameObject)Instantiate (smoke, gameObject.transform.position,Quaternion.identity);
			smokePuff.GetComponent<ParticleSystem>().startColor = gameObject.GetComponent<SpriteRenderer>().color;
			Destroy (gameObject);
		}else {
			LoadSprites();
		}
	}
	
	void LoadSprites(){
		int spritesIndex  = timesHit - 1;
		if(hitSprites[spritesIndex]){
			this.GetComponent<SpriteRenderer>().sprite = hitSprites[spritesIndex];
		}
	}
	
	
}
