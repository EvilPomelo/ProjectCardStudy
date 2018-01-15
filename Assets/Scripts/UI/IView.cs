using UnityEngine;

public abstract class IView
{
        public void Start()
        {
                
        }

        public void Destory()
        {
        }

        public void Show()
        {
        }

        public void Hide()
        {
        }

        public void Click(GameObject sender,object param)
        {
        }

        public void Press(GameObject sender, object param)
        {
        }

        public void Drag(GameObject sender, object param)
        {
                
        }

        protected abstract void OnStart();
        protected abstract void OnShow();
        protected abstract void OnHide();
        protected abstract void OnClick();
        protected abstract void OnPress();
        protected abstract void OnDrag();
}