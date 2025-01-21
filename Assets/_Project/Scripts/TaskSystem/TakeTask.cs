using UnityEngine; 
using System.Collections.Generic;

namespace Task
{
    public class TakeTask : MonoBehaviour
    {
        [SerializeField] private ListTaskSo _listTaskSo;
        [SerializeField] private List<UITaskData> _uiTaskData;

        public int _indexCurrentTask;

        [SerializeField] private GameObject _tasks—ompleted;

        private void OnEnable()
        {
            CheckCountTask();
        }

        private void Awake()
        { 
            GiveTaskPotion();
            InitIndexTask();
            PlayerPrefs.GetInt("_currentTask", _indexCurrentTask); 
        }

        //public void Update()
        //{
        //    if (Input.GetKey(KeyCode.Space))
        //    {
        //        _indexCurrentTask = 0;
        //         PlayerPrefs.SetInt("_currentTask", _indexCurrentTask);
        //    }
        //}
        private void InitIndexTask()
        {
            for (int i = 0; i < _listTaskSo.ListTasks.Count; i++)
            {
                _listTaskSo.ListTasks[i].IndexTask(i);
            }
        } 

        private void GiveTaskPotion()
        { 
            int _saveIndex = PlayerPrefs.GetInt("_currentTask");
            var task = _listTaskSo.ListTasks[_saveIndex]; 

            for (int i = 0; i < task.listTasks.Count; i++)
            {
                _uiTaskData[i]._description.text = task.listTasks[i].DescriptionItem;
                _uiTaskData[i]._spritePotion.sprite = task.listTasks[i].AvatarItem;
                _uiTaskData[i]._spritePotionComplete.sprite = task.listTasks[i].AvatarItem;
                _uiTaskData[i]._itemType = task.listTasks[i].ItemTypeEnum;
                _uiTaskData[i]._countPotion.text = task.listTasks[i].Count.ToString();
            }
        }

        private void CheckCountTask()
        {
            if (_listTaskSo.ListTasks.Count > _indexCurrentTask + 1)
            {  
                _tasks—ompleted.SetActive(false); 
            }
            else
            {
                _tasks—ompleted.SetActive(true);
            }
        }

        public void PlusIndexList(int index)
        { 
            if (_listTaskSo.ListTasks.Count > _indexCurrentTask + 1)
            {
                Debug.Log("2"); 
                _indexCurrentTask += index;
               PlayerPrefs.SetInt("_currentTask", _indexCurrentTask); 
                GiveTaskPotion();
            } 
            else
            {
                CheckCountTask();
            }
        } 
    }
}

