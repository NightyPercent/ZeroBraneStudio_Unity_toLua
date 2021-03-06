﻿using UnityEngine;

public static class LuaConst
{
	public static string luaDir = Application.dataPath + ClientDefine.luaPath;
    public static string toluaDir = Application.dataPath + "/ToLua/Lua";

#if UNITY_STANDALONE
    public static string osDir = "Win";
#elif UNITY_ANDROID
    public static string osDir = "Android";            
#elif UNITY_IPHONE
    public static string osDir = "iOS";        
#else
    public static string osDir = "";        
#endif

    public static string luaResDir = string.Format("{0}/{1}/Lua", Application.persistentDataPath, osDir);      //手机运行时lua文件下载目录    

#if UNITY_EDITOR_WIN || NITY_STANDALONE_WIN    
	public static string zbsDir = ClientDefine.zbsDir;        //ZeroBraneStudio目录       
#elif UNITY_EDITOR_OSX || UNITY_STANDALONE_OSX
	public static string zbsDir = ClientDefine.zbsDir;
#else
    public static string zbsDir = luaResDir + "/mobdebug/";
#endif    

    public static bool openLuaSocket = true;            //是否打开Lua Socket库
    public static bool openLuaDebugger = true;         //是否连接ZeroBraneStudio调试
}