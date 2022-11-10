using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace BattleLords.FightSystem
{ 
    public class GameController : MonoBehaviour
    {
        [SerializeField] private GameObject Player;
        [SerializeField] private GameObject Enemy;
        [SerializeField] private Slider PlayerHealth;
        [SerializeField] private Slider EnemyHealth;
        [SerializeField] private Button AttackBtn;
        [SerializeField] private Button HealBtn;
        [SerializeField] private Button StoreBtn;

        private bool IsPlayerTurn = true;

        void Awake()
        {
            StoreBtn.interactable = false;
        }

        private void Attack(GameObject target, float damageAmount)
        {

            if (target == Player)
            {
                PlayerHealth.value -= damageAmount;
                
            }
            else
            {
                EnemyHealth.value -= damageAmount;
            }

            if (PlayerHealth.value <= 0 || EnemyHealth.value <= 0)
            {
                EndFight();
            } else
            {
                ChangeTurn();
            }

        }

        private void Heal(GameObject target, float healAmount)
        {
            if (target == Player)
            {
                PlayerHealth.value += healAmount;
            }
            else
            {
                EnemyHealth.value += healAmount;
            }

            ChangeTurn();

        }

        public void AttackButton()
        {
            Attack(Enemy, 10);

        }

        public void HealButton()
        {
            Heal(Player, 5);
        }


        private IEnumerator EnemyTurn()
        {
            yield return new WaitForSeconds(2);
            int random = Random.Range(1, 3);
            if (random == 1)
            {
                Attack(Player, 10);
            }
            else
            {
                Heal(Enemy, 5);

            }
        }

        private void ChangeTurn()
        {
            IsPlayerTurn = !IsPlayerTurn;

            if (IsPlayerTurn)
            {
                AttackBtn.interactable = true;
                HealBtn.interactable = true;

            }
            else
            {
                AttackBtn.interactable = false;
                HealBtn.interactable = false;
                StartCoroutine(EnemyTurn());
            }

        }

        private void EndFight( )
        {
            Camera.main.GetComponent<AudioSource>().Stop();
            AttackBtn.interactable = false;
            HealBtn.interactable = false;
            StoreBtn.interactable = true;

        }

        public void GotoStore()
        {
            SceneManager.LoadScene("Store");
        }

    }
}
