using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace COW;

[Token(Token = "0x20003BD")]
public class StreamerFuncImpl : _Attribute
{
	[Token(Token = "0x600105A")]
	[Address(RVA = "0x288F0E0", Offset = "0x288F0E0", VA = "0x288F0E0")]
	public StreamerFuncImpl()
	{
	}

	[Token(Token = "0x600105B")]
	[Address(RVA = "0x288F0E8", Offset = "0x288F0E8", VA = "0x288F0E8", Slot = "4")]
	public Transform GetTargetPlayer()
	{
		return null;
	}

	[Token(Token = "0x600105C")]
	[Address(RVA = "0x288F3C0", Offset = "0x288F3C0", VA = "0x288F3C0", Slot = "5")]
	public AsyncOperation LoadSceneAsync(string sourcePath, LoadSceneMode mode)
	{
		return null;
	}

	[Token(Token = "0x600105D")]
	[Address(RVA = "0x288F6C4", Offset = "0x288F6C4", VA = "0x288F6C4", Slot = "6")]
	public AssetBundle GetStreamSceneAB()
	{
		return null;
	}

	[Token(Token = "0x600105E")]
	[Address(RVA = "0x288F834", Offset = "0x288F834", VA = "0x288F834", Slot = "7")]
	public byte[] GetStreamSceneABTexRefInfo()
	{
		return null;
	}

	[Token(Token = "0x600105F")]
	[Address(RVA = "0x288F930", Offset = "0x288F930", VA = "0x288F930", Slot = "8")]
	public void OnLoadSceneFinish(string sourcePath, bool result)
	{
	}

	[Token(Token = "0x6001060")]
	[Address(RVA = "0x288FB40", Offset = "0x288FB40", VA = "0x288FB40", Slot = "9")]
	public void RepeatAction(float interval, Action action)
	{
	}

	[Token(Token = "0x6001061")]
	[Address(RVA = "0x288FC64", Offset = "0x288FC64", VA = "0x288FC64", Slot = "10")]
	public void NotifySceneEvent(StreamerType type, string name, bool loaded)
	{
	}
}
