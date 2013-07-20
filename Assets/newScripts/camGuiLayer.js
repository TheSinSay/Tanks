    public var test : GUILayer;
    test = Camera.main.GetComponent(GUILayer);
    var btnTextures:Texture2D[];
    
    function Update() {
    //Screen.fullscreen = true;
    /////Если нажата кнопка мыши
        if(test.HitTest(Input.mousePosition) != null && test.HitTest(Input.mousePosition).tag=="PlayBtn" && Input.GetMouseButtonDown(0)) {
        test.HitTest(Input.mousePosition).guiTexture.texture = btnTextures[0];
        }
    /////Если отжата кнопка мыши
        if(test.HitTest(Input.mousePosition) != null && test.HitTest(Input.mousePosition).tag=="PlayBtn" && Input.GetMouseButtonUp(0)) {
        test.HitTest(Input.mousePosition).guiTexture.texture = btnTextures[1];
        var ha:GameInterface=transform.GetComponent("GameInterface");
        ha.pressedBtnPause=false;
        }
        /////Если нажата кнопка мыши
        if(test.HitTest(Input.mousePosition) != null && test.HitTest(Input.mousePosition).tag=="PauseBtn" && Input.GetMouseButtonDown(0)) {
        test.HitTest(Input.mousePosition).guiTexture.texture = btnTextures[2];
        }
    /////Если отжата кнопка мыши
        if(test.HitTest(Input.mousePosition) != null && test.HitTest(Input.mousePosition).tag=="PauseBtn" && Input.GetMouseButtonUp(0)) {
        test.HitTest(Input.mousePosition).guiTexture.texture = btnTextures[3];
        var ot:GameInterface=transform.GetComponent("GameInterface");
        ot.pressedBtnPause=true;
        }
        /////Если нажата кнопка мыши
        if(test.HitTest(Input.mousePosition) != null && test.HitTest(Input.mousePosition).tag=="RestBtn" && Input.GetMouseButtonDown(0)) {
        test.HitTest(Input.mousePosition).guiTexture.texture = btnTextures[4];
        }
    /////Если отжата кнопка мыши
        if(test.HitTest(Input.mousePosition) != null && test.HitTest(Input.mousePosition).tag=="RestBtn" && Input.GetMouseButtonUp(0)) {
        test.HitTest(Input.mousePosition).guiTexture.texture = btnTextures[5];
        Application.LoadLevel(0);
        }
    }
//If (GUI.Button (Rect (10,10,100,20), "fullscreen"))
//
//Screen.fullScreen = !Screen.fullScreen;