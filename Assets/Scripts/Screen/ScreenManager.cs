using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ebac.Core.Singleton;

namespace Screens{
    
    public class ScreenManager : Singleton<ScreenManager>{

        private ScreenBase _currentBase;
        public List<ScreenBase> screenBases;

        public ScreenType startScreen = ScreenType.Panel_Menu;

        private void Start() {
            HideAll();
            ShowByType(startScreen);
        }

        public void ShowByType(ScreenType type){

            _currentBase?.Hide();

            var nextScreen = screenBases.Find(i => i.screenType == type);

            _currentBase = nextScreen;
            nextScreen.Show();
        }

        public void HideAll(){
            screenBases.ForEach(i => i.Hide());
        }

    }
}