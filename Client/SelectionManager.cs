using Client.Data;
using Core.Data.Common;
using UnityEngine;

namespace Client
{
    public class SelectionManager : MonoBehaviour
    {
        private GameManager _gameManager;

        void Update()
        {
            SelectObject();
        }

        public static GameObject AddSelectionManagerCompnent(GameObject goTo, GameManager gameManager)
        {
            goTo.SetActive(false);

            SelectionManager selectionManager = goTo.AddComponent<SelectionManager>() as SelectionManager;
            selectionManager._gameManager = gameManager;
            goTo.SetActive(true);

            return goTo;
        }

        private WorldObject _worldObject = new WorldObject();

        private void SelectObject()
        {


            if (Input.GetKey(KeyCode.Mouse0))
            {
                Ray ray = UnityEngine.Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit, 100))
                {
                    var data = SingleSelection(hit.transform.GetComponent<WorldObject>());


                    if (data != null)
                    {
                        _gameManager.UIManager.UICityViewGO.SetActive(false);
                    }

                }
            }
        }

        private IData SingleSelection(WorldObject worldObject)
        {
            _worldObject.IsWorldObjectSelected = false;

            worldObject.IsWorldObjectSelected = true;
            _worldObject = worldObject;
            return _gameManager.SystemManager.SelectManager.GetData(worldObject.TagName, worldObject.DataType);
        }
    }
}