using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


    public class EnemyAI : MonoBehaviour
    {

        [SerializeField] public GameObject player;
        [SerializeField] private Animator animator;


        [SerializeField] private float attackDelay = 2f;

        private NavMeshAgent nma;
        private float t;


        // Start is called before the first frame update
        void Start()
        {
            nma = GetComponent<NavMeshAgent>();
            nma.isStopped = false;
        }

        // Update is called once per frame
        void Update()
        {
            
            Movement();
            Animation();
            Attack();
            
        }

        private void Attack()
        {

            // SI JE SUIS A PORTEE
            if (isInRange())
            {

                // J'AUGMENTE MA VARIABLE DE TEMPS DE 1 PAR SECONDE
                t += Time.deltaTime;

                // SI MON TEMPS EST SUPERIEUR AU DELAY POUR ATTAQUER
                if(t >= attackDelay)
                {
                    // JE JOUE L'ANIMATION D'ATTAQUE
                    animator.SetTrigger("Attack");

                    // JE RESET LE TEMPS A ZERO
                    t = 0;
                }
                
            }
        }

        private void Animation()
        {
            animator.SetBool("InRange", isInRange());
        }

        private void Movement()
        {
            nma.SetDestination(player.transform.position);
        }

        private bool isInRange()
        {
            return nma.hasPath && nma.remainingDistance < nma.stoppingDistance;
        }





    }


