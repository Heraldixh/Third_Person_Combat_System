using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State 
{
  /*
   * The enter function is called when a new state is entered.(Equivalent to Start() method)
   */
    public abstract void Enter();
    
  /*
   * We will execute code every frame while State entered.(Equivalent of Update() method),(Inside the bracket we have to capture the time that serves the frame to occur)
   */
    public abstract void Tick(float deltaTime);

    /*
     * Called when the State is exited. Used to tidy up and transition to the next state.
     */
    public abstract void Exit();
}
