using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMove : MonoBehaviour
{
    //this is a variable in c#
    //PUBLIC means that this variable can be used by other scripts
    //think of instance variables from gamemaker
    //FLOAT means that this is a number with a decimal
    //SPEED is the name we give the variabl
    public float speed;

    //this is another variable
    //it's of the type TMP_Text (or: textmeshpro text component)
    //myText is the name we gave it
    public TMP_Text myText;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //in unity we have CLASSES for different kinds of behavior
        //INPUT is one such class the input class contains a bunch of stuff we might need to use the keyboard, mouse, gamepads, etc.
        //GETKEY is a function that the input class has. it checks to see if a key is being pressed
        //it takes one parameter: the key that we're checking for
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //TRANSFORM here refers to this gameobject's (that this script is attached to) transform
            //the transform is the component that tracks a gameobject's position, rotation, and scale
            //the transform component has a function called TRANSLATE (remember translating shapes in geometry?)
            //translate is allowing us to move our player. it takes one parameter: the direction and distance we want to move
            //VECTOR3 is a kind of point! it contains a position and direction
            //here, we can use a built-in direction: up!
            //we multiply "up" by time.deltatime and speed
            //TIME.DELTATIME is the time since the last frame; basically we're making our game frame-independant - our character will move at the same speed, regardless of our framerate
            transform.Translate(Vector3.up * Time.deltaTime * speed);
            //whenever you see a period between two words in C#, that's called an ACCESSOR
            //this allows us to use, read, or change a function or variable that belongs to the class we're referencing
            //here, i can change the text of the textmeshpro component, thus changing what we see
            myText.text = "UP!";
        } else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed);
            myText.text = "DOWN!";
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
            myText.text = "LEFT!";
        } else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
            myText.text = "RIGHT!";
        }

    }
}
