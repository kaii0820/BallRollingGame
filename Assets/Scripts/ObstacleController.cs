using System.Collections;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    // UIController を参照する
    public UIController UIController;

    // Trigger との接触時に呼ばれる Callback
    private void OnTriggerEnter(Collider hit)
    {
        // 接触対象はPlayerタグかどうか
        if (hit.CompareTag("Player"))
        {
            // Rigidbody を停止させる
            hit.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;

            // ゲームオーバーを表示する
            UIController.ShowGameOverLabel();
        }
    }
}