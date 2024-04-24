using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace fpfsimpledialoguesystem
{
    public class PlayerMover : MonoBehaviour
    {
        [SerializeField]
        public float speed;
        
        void Update()
        {
            transform.Translate(transform.forward * speed * Time.deltaTime);
        }
    }
}
