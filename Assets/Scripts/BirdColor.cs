using UnityEngine;

public class BirdColor : MonoBehaviour
{
    public AnimationClip blueAnimation;
    public AnimationClip redAnimation;
    public AnimationClip yellowAnimation;

    void Start()
    {
        Animator animator = GetComponent<Animator>();

        AnimationClip[] animations =
        {
            blueAnimation,
            redAnimation,
            yellowAnimation
        };

        int randomIndex = Random.Range(0, animations.Length);
        AnimationClip selectedAnimation = animations[randomIndex];

        RuntimeAnimatorController originalController =
            animator.runtimeAnimatorController;

        AnimationClip originalAnimation =
            originalController.animationClips[0];

        AnimatorOverrideController newController =
            new AnimatorOverrideController(originalController);

        newController[originalAnimation] = selectedAnimation;
        animator.runtimeAnimatorController = newController;

    }
}