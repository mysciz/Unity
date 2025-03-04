using Unity.Mathematics;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
   public float move_speed = 0.1f;
   public float scale_speed = 50f;
   private Vector2 dir;
   private Vector2 range;
   void Start(){
      dir = new Vector2(transform.position.x, transform.position.y);
      range = new Vector2(transform.position.x , 50f*transform.position.x);
   }
   void Update(){
     float In = Input.GetAxis("Vertical");
     if(In!= 0){
      Vector2 newp= new Vector2(transform.position.x + In*move_speed*dir.x, transform.position.y + In*move_speed*dir.y);
     if(math.abs(newp.x) >= math.abs(range.x) && math.abs(newp.y) <= math.abs(range.y)){
        transform.position = newp;
        Debug.Log(In*move_speed);
        float scale = transform.localScale.x + In*scale_speed*5f;
        Debug.Log(In*scale_speed);
        transform.localScale = new Vector3(scale, scale, 1);
     }
     }
     if(Input.GetKeyDown(KeyCode.Q)){
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
     }

    // Debug.Log(transform.position.x + " " + transform.position.y+ " " + transform.localScale.x);
   }
}