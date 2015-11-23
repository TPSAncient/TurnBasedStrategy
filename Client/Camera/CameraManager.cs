﻿using System.Collections.Generic;
using Core.Data.Common;
using Core.System;
using UnityEngine;

namespace Client.Camera
{
    public class CameraManager : MonoBehaviour
    {
        private UnityEngine.Camera _mainCamera;

        private GameManager _gameManager;

        #region Unity Methods

        void Awake()
        {
            _mainCamera = UnityEngine.Camera.main;
            _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        }

        // Update is called once per frame
        void Update()
        {
            MoveCamera();
            RotateCamera();
            KeyboardMoveCamera();
            SelectObject();
        }

        #endregion

        private void MoveCamera()
        {
            float xpos = Input.mousePosition.x;
            float ypos = Input.mousePosition.y;
            Vector3 movement = new Vector3(0, 0, 0);

            //horizontal camera movement
            if (xpos >= 0 && xpos < ResourceManager.ScrollWidth)
            {
                movement.x -= ResourceManager.ScrollSpeed;
            }
            else if (xpos <= Screen.width && xpos > Screen.width - ResourceManager.ScrollWidth)
            {
                movement.x += ResourceManager.ScrollSpeed;
            }
            //vertical camera movement
            if (ypos >= 0 && ypos < ResourceManager.ScrollWidth)
            {
                movement.z -= ResourceManager.ScrollSpeed;
            }
            else if (ypos <= Screen.height && ypos > Screen.height - ResourceManager.ScrollWidth)
            {
                movement.z += ResourceManager.ScrollSpeed;
            }

            MovmentAndScrolling(movement);
        }

        private void KeyboardMoveCamera()
        {
            Vector3 movement = new Vector3(0, 0, 0);

            if (Input.GetKey(KeyCode.A))
            {
                // Move left
                movement.x -= ResourceManager.ScrollSpeed;
            }

            if (Input.GetKey(KeyCode.D))
            {
                // Move Right
                movement.x += ResourceManager.ScrollSpeed;
            }

            if (Input.GetKey(KeyCode.W))
            {
                // Move Forward
                movement.z += ResourceManager.ScrollSpeed;
            }

            if (Input.GetKey(KeyCode.S))
            {
                // Move Backward
                movement.z -= ResourceManager.ScrollSpeed;
            }

            MovmentAndScrolling(movement);
        }

        private void RotateCamera()
        {
            Vector3 origin = _mainCamera.transform.eulerAngles;
            Vector3 destination = origin;

            //detect rotation amount if ALT is being held and the Right mouse button is down
            if ((Input.GetKey(KeyCode.LeftAlt) || Input.GetKey(KeyCode.RightAlt)) && Input.GetMouseButton(1))
            {
                destination.x -= Input.GetAxis("Mouse Y") * ResourceManager.RotateAmount;
                destination.y += Input.GetAxis("Mouse X") * ResourceManager.RotateAmount;
            }

            //if a change in position is detected perform the necessary update
            if (destination != origin)
            {
                _mainCamera.transform.eulerAngles = Vector3.MoveTowards(origin, destination, Time.deltaTime * ResourceManager.RotateSpeed);
            }
        }

        private void MovmentAndScrolling(Vector3 movement)
        {
            //make sure movement is in the direction the camera is pointing
            //but ignore the vertical tilt of the camera to get sensible scrolling
            movement = _mainCamera.transform.TransformDirection(movement);
            movement.y = 0;

            //away from ground movement
            movement.y -= ResourceManager.ScrollSpeed * Input.GetAxis("Mouse ScrollWheel");

            //calculate desired camera position based on received input
            Vector3 origin = _mainCamera.transform.position;
            Vector3 destination = origin;
            destination.x += movement.x;
            destination.y += movement.y;
            destination.z += movement.z;

            //limit away from ground movement to be between a minimum and maximum distance
            if (destination.y > ResourceManager.MaxCameraHeight)
            {
                destination.y = ResourceManager.MaxCameraHeight;
            }
            else if (destination.y < ResourceManager.MinCameraHeight)
            {
                destination.y = ResourceManager.MinCameraHeight;
            }

            //if a change in position is detected perform the necessary update
            if (destination != origin)
            {
                _mainCamera.transform.position = Vector3.MoveTowards(origin, destination, Time.deltaTime * ResourceManager.ScrollSpeed);
            }
        }

        private readonly List<WorldObject> _selectedWorldObjects = new List<WorldObject>();

        private void SelectObject()
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                Ray ray = UnityEngine.Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit, 100))
                {
                    var data = SingleSelection(hit.transform.GetComponent<WorldObject>());
                    if (data != null && data.DataType == DataType.City)
                    {
                        _gameManager.UIManager.OpenOverViewPanel(data);
                        _gameManager.UIManager.OpenCityBuildingView();
                    }
                    else
                    {
                        _gameManager.UIManager.CloseOverViewPanel();
                        _gameManager.UIManager.CloseCityBuildingView();
                    }
                    
                }
            }
        }
        
        private IData SingleSelection(WorldObject worldObject)
        {
            foreach (var selectedWorldObject in _selectedWorldObjects)
            {
                selectedWorldObject.IsWorldObjectSelected = false;
            }
            _selectedWorldObjects.Clear();

            WorldObject selected = worldObject;

            selected.IsWorldObjectSelected = true;
            _selectedWorldObjects.Add(selected);
            return _gameManager.SelectManager.GetData(selected.Tag, selected.SelectedObjectType);
        }
    }
}
