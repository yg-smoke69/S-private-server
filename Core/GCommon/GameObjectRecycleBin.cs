using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2003ECB")]
public class GameObjectRecycleBin
{
	[Token(Token = "0x401A84B")]
	[FieldOffset(Offset = "0x8")]
	private Transform m_BinRoot;

	[Token(Token = "0x401A84C")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<int, GameObjectRecycleInfo> m_Caches;

	[Token(Token = "0x401A84D")]
	[FieldOffset(Offset = "0x10")]
	private ObjectPool<GameObjectRecycleInfo> m_InfoPool;

	[Token(Token = "0x401A84E")]
	[FieldOffset(Offset = "0x14")]
	public Action<GameObject> onRestore;

	[Token(Token = "0x401A84F")]
	[FieldOffset(Offset = "0x18")]
	public Action<GameObject> onRecycle;

	[Token(Token = "0x60198F7")]
	[Address(RVA = "0x32B4DC0", Offset = "0x32B4DC0", VA = "0x32B4DC0")]
	public GameObjectRecycleBin(Transform binRoot)
	{
	}

	[Token(Token = "0x60198F8")]
	[Address(RVA = "0x32B4E88", Offset = "0x32B4E88", VA = "0x32B4E88")]
	public void SetRecycleBinRoot(Transform binRoot)
	{
	}

	[Token(Token = "0x60198F9")]
	[Address(RVA = "0x32B50FC", Offset = "0x32B50FC", VA = "0x32B50FC")]
	public void Restore(GameObject item)
	{
	}

	[Token(Token = "0x60198FA")]
	[Address(RVA = "0x32B53B8", Offset = "0x32B53B8", VA = "0x32B53B8")]
	public void Recycle(GameObject item)
	{
	}

	[Token(Token = "0x60198FB")]
	[Address(RVA = "0x32B5748", Offset = "0x32B5748", VA = "0x32B5748")]
	public void Clear(GameObject item)
	{
	}

	[Token(Token = "0x60198FC")]
	[Address(RVA = "0x32B4F2C", Offset = "0x32B4F2C", VA = "0x32B4F2C")]
	public void ClearAll()
	{
	}
}
