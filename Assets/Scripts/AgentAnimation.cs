using UnityEngine;

public class AgentAnimation : MonoBehaviour
{
    protected Animator agentAnimator;

    private void Awake()
    {
        agentAnimator = GetComponent<Animator>();
    }

    public void SetWalkAnimation(bool val)
    {
        agentAnimator.SetBool("moving", val);
    }

    public void AnimatePlayer(float velocity)
    {
        SetWalkAnimation(velocity > 0);
    }

    public void PlayDeathAnimation()
    {
        agentAnimator.SetTrigger("Death");
    }
}