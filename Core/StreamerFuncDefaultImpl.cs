using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

[Token(Token = "0x2003D3B")]
public class StreamerFuncDefaultImpl : _Attribute
{
	[Token(Token = "0x60187F1")]
	[Address(RVA = "0x21D9694", Offset = "0x21D9694", VA = "0x21D9694")]
	public StreamerFuncDefaultImpl()
	{
	}

	[Token(Token = "0x60187F2")]
	[Address(RVA = "0x21DB4CC", Offset = "0x21DB4CC", VA = "0x21DB4CC", Slot = "4")]
	public Transform GetTargetPlayer()
	{
		return null;
	}

	[Token(Token = "0x60187F3")]
	[Address(RVA = "0x21DB4D4", Offset = "0x21DB4D4", VA = "0x21DB4D4", Slot = "5")]
	public AsyncOperation LoadSceneAsync(string sourcePath, LoadSceneMode mode)
	{
		return null;
	}

	[Token(Token = "0x60187F4")]
	[Address(RVA = "0x21DB4DC", Offset = "0x21DB4DC", VA = "0x21DB4DC", Slot = "6")]
	public AssetBundle GetStreamSceneAB()
	{
		return null;
	}

	[Token(Token = "0x60187F5")]
	[Address(RVA = "0x21DB4E4", Offset = "0x21DB4E4", VA = "0x21DB4E4", Slot = "7")]
	public byte[] GetStreamSceneABTexRefInfo()
	{
		return null;
	}

	[Token(Token = "0x60187F6")]
	[Address(RVA = "0x21DB4EC", Offset = "0x21DB4EC", VA = "0x21DB4EC", Slot = "8")]
	public void OnLoadSceneFinish(string sourcePath, bool result)
	{
	}

	[Token(Token = "0x60187F7")]
	[Address(RVA = "0x21DB4F0", Offset = "0x21DB4F0", VA = "0x21DB4F0", Slot = "9")]
	public void RepeatAction(float interval, Action action)
	{
	}

	[Token(Token = "0x60187F8")]
	[Address(RVA = "0x21DB4F4", Offset = "0x21DB4F4", VA = "0x21DB4F4", Slot = "10")]
	public void NotifySceneEvent(StreamerType type, string name, bool loaded)
	{
	}
}
