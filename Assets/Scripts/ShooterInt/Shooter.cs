using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using Cinemachine;
using StarterAssets;


    public class Shooter : MonoBehaviour
    {

        #region Shooter
        [SerializeField]
        private CinemachineVirtualCamera aimVirtualCam;
        private ShootInput playerInputs;
        private ThirdPersonController thirdPersonController;
        [SerializeField]
        private LayerMask aimColliderMask = new LayerMask();
        public Transform debugTransform;
        public GameObject bulletProjPrefab;
        public Transform spawnBulletPos;
        [SerializeField]
        private float normalSensitivity;
        [SerializeField]
        private float aimSensitivity = 0.2f;
        public Image crosshair;
        #endregion

        #region Animator
        /*public Animator anim;*/
        #endregion

        private void Awake()
        {
            bulletProjPrefab = Instantiate(bulletProjPrefab);
            bulletProjPrefab.SetActive(false);

            playerInputs = GetComponent<ShootInput>();
            thirdPersonController = GetComponent<ThirdPersonController>();
            /*anim = GetComponent<Animator>();*/
        }

        void Start()
        {

        }


        void Update()
        {
            Vector3 mouseWorldPosition = Vector3.zero;
            Vector2 screenCenter = new Vector2(Screen.width / 2f, Screen.height / 2f);

            Ray ray = Camera.main.ScreenPointToRay(screenCenter);
            if (Physics.Raycast(ray, out RaycastHit raycastHit, 999f, aimColliderMask))
            {
                debugTransform.position = raycastHit.point;
                mouseWorldPosition = raycastHit.point;
            }

            if (playerInputs.aim)
            {
                //crosshair.enabled = true;
                //aimVirtualCam.gameObject.SetActive(true);
                //thirdPersonController.SetSensitivity(aimSensitivity);
                //thirdPersonController.SetRotationOnMove(false);


                /*anim.SetLayerWeight(1, Mathf.Lerp(anim.GetLayerWeight(1), 1f, Time.deltaTime * 10));*/

                Vector3 worldAimTarget = mouseWorldPosition;
                worldAimTarget.y = transform.position.y;
                Vector3 aimDirection = (worldAimTarget - transform.position).normalized;

                transform.forward = Vector3.Lerp(transform.forward, aimDirection, Time.deltaTime * 20f);
            }
            else
            {
                //crosshair.enabled = false;
                //aimVirtualCam.gameObject.SetActive(false);
                //thirdPersonController.SetSensitivity(normalSensitivity);
                //thirdPersonController.SetRotationOnMove(true);
                /*anim.SetLayerWeight(1, Mathf.Lerp(anim.GetLayerWeight(1), 0f, Time.deltaTime * 10));*/
            }

            if (playerInputs.shoot)
            {
                Vector3 aimDir = (mouseWorldPosition - spawnBulletPos.position).normalized;
                Instantiate(bulletProjPrefab, spawnBulletPos.position, Quaternion.LookRotation(aimDir, Vector3.up)).SetActive(true);
                playerInputs.shoot = false;
            }

        }
    }

