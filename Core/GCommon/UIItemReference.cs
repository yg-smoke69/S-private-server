using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x200414D")]
public class UIItemReference : MonoBehaviour
{
	[Token(Token = "0x401B660")]
	[FieldOffset(Offset = "0xC")]
	public List<UIItemVariable> Items;

	[Token(Token = "0x401B661")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<string, UIItemVariable> m_ItemDict;

	[Token(Token = "0x601AAE9")]
	[Address(RVA = "0x2CA3EF4", Offset = "0x2CA3EF4", VA = "0x2CA3EF4")]
	public UIItemReference()
	{
	}

	[Token(Token = "0x601AAEA")]
	public T GetItem<T>(string itemName) where T : Object
	{
		return (T)null;
	}

	[Token(Token = "0x601AAEB")]
	[Address(RVA = "0x2CA3F80", Offset = "0x2CA3F80", VA = "0x2CA3F80")]
	private void CacheItem()
	{
	}

	[Token(Token = "0x601AAEC")]
	[Address(RVA = "0x2CA4310", Offset = "0x2CA4310", VA = "0x2CA4310")]
	private bool HasCached()
	{
		return default(bool);
	}
}
