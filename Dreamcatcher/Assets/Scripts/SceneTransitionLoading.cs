<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneTransitionLoading : MonoBehaviour
{
    public ChangeScene changeScene;
    public Animator transition;
    public float transitionTime;
    public void LoadNextLevel(int level)
    {
       StartCoroutine(loadLevel(level));
    }

    IEnumerator loadLevel(int levelIndex)
    {
        //play anim
        transition.SetTrigger("Start");

        //wait
        yield return new WaitForSeconds(transitionTime);

        //loadTheScene
        changeScene.MoveScenes(levelIndex);
    }
}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneTransitionLoading : MonoBehaviour
{
    public ChangeScene changeScene;
    public Animator transition;
    public float transitionTime;
    public void LoadNextLevel(int level)
    {
       StartCoroutine(loadLevel(level));
    }

    IEnumerator loadLevel(int levelIndex)
    {
        //play anim
        transition.SetTrigger("Start");

        //wait
        yield return new WaitForSeconds(transitionTime);

        //loadTheScene
        changeScene.MoveScenes(levelIndex);
    }
}
>>>>>>> 9eded08283690c77846f031d49ae377ccae83217
