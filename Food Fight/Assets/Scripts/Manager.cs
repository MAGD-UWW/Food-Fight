using UnityEngine;
using System.Collections;
using System.Collections.Generic;



public class Manager : MonoBehaviour {
    public PlayerOneManager Player1 { get; private set; } //Static code to reference to
    public PlayerTwoManager Player2 { get; private set; } //Static code to reference to
	public ChoiceManager Choice { get; private set; }
	public ExecutionManager Execution { get; private set; } 


    private List<IGameManager> _startSequence; //Creates Private list of Managers and loops on start(Blank Variable)

    void Awake() {
		Debug.Log ("Getting manager components");
        Player1 = GetComponent<PlayerOneManager>(); //Assigns component to the manager property
		Player2 = GetComponent<PlayerTwoManager>(); //Assigns component to the manager property
		Choice = GetComponent<ChoiceManager> (); //Assigns component to the manager property
		Execution = GetComponent<ExecutionManager> (); //Assigns component to the manager property

       
		_startSequence = new List<IGameManager>();
		_startSequence.Add (Player1);
		_startSequence.Add (Player2);
		_startSequence.Add (Choice);
		_startSequence.Add (Execution);


        StartCoroutine(StartupManagers());
    }
    private IEnumerator StartupManagers() {
        foreach (IGameManager manager in _startSequence) { //Creates private enum and goes through list calling Startup() method on each
            manager.Startup();
        }
        yield return null;

        int numModules = _startSequence.Count; //Two variables to keep track of which managers are running
        int numReady = 0;                      //1. Number of modules to check 2. How many are ready

        while (numReady < numModules) {
            int lastReady = numReady;
            numReady = 0;

            foreach (IGameManager manager in _startSequence) { //Check status of each manager. Increment numReady value if Manager starts
                if (manager.status == ManagerStatus.Started) {
                    numReady++;
                }
            }
            if (numReady > lastReady) {
                Debug.Log("Process: " + numReady + "/" + numModules);

                yield return null; //another blank return
            }           
        }
        Debug.Log("All managers have started up"); //When all managers are ready, log posts
    }
}
