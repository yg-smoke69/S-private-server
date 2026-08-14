using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

[Token(Token = "0x2003D39")]
public interface IStreamerFunc
{
	[Token(Token = "0x60187E8")]
	Transform GetTargetPlayer();

	[Token(Token = "0x60187E9")]
	AsyncOperation LoadSceneAsync(string sourcePath, LoadSceneMode mode);

	[Token(Token = "0x60187EA")]
	AssetBundle GetStreamSceneAB();

	[Token(Token = "0x60187EB")]
	byte[] GetStreamSceneABTexRefInfo();

	[Token(Token = "0x60187EC")]
	void OnLoadSceneFinish(string sourcePath, bool result);

	[Token(Token = "0x60187ED")]
	void RepeatAction(float interval, Action action);

	[Token(Token = "0x60187EE")]
	void NotifySceneEvent(StreamerType type, string name, bool loaded);
}
