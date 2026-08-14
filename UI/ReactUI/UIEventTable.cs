using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ReactUI;

[Token(Token = "0x2000CB6")]
public sealed class UIEventTable : MonoBehaviour
{
	[Token(Token = "0x2000CB7")]
	public delegate void EventDelegate(object[] args);

	[Token(Token = "0x4006774")]
	[FieldOffset(Offset = "0xC")]
	private string[] events;

	[Token(Token = "0x4006775")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<string, SignalDelegateList> m_delegateMap;

	[Token(Token = "0x4006776")]
	[FieldOffset(Offset = "0x14")]
	private Dictionary<string, LinkedList<Component>> m_componentMap;

	[Token(Token = "0x1700080E")]
	public string[] Events
	{
		[Token(Token = "0x60060BE")]
		[Address(RVA = "0x3159FD0", Offset = "0x3159FD0", VA = "0x3159FD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60060BD")]
	[Address(RVA = "0x3159F08", Offset = "0x3159F08", VA = "0x3159F08")]
	public UIEventTable()
	{
	}

	[Token(Token = "0x60060BF")]
	[Address(RVA = "0x3159FD8", Offset = "0x3159FD8", VA = "0x3159FD8")]
	private Dictionary<string, SignalDelegateList> GetDelegateMap()
	{
		return null;
	}

	[Token(Token = "0x60060C0")]
	[Address(RVA = "0x315A1A0", Offset = "0x315A1A0", VA = "0x315A1A0")]
	public void Sort()
	{
	}

	[Token(Token = "0x60060C1")]
	[Address(RVA = "0x315A204", Offset = "0x315A204", VA = "0x315A204")]
	public ICollection<Component> FindReferenced(string eventName)
	{
		return null;
	}

	[Token(Token = "0x60060C2")]
	[Address(RVA = "0x315A2E8", Offset = "0x315A2E8", VA = "0x315A2E8")]
	public SignalHandle ListenEvent(string eventName, SignalDelegate callback)
	{
		return null;
	}

	[Token(Token = "0x60060C3")]
	[Address(RVA = "0x315A3E8", Offset = "0x315A3E8", VA = "0x315A3E8")]
	public void ClearEvent(string eventName)
	{
	}

	[Token(Token = "0x60060C4")]
	[Address(RVA = "0x315A498", Offset = "0x315A498", VA = "0x315A498")]
	public void ClearAllEvents()
	{
	}

	[Token(Token = "0x60060C5")]
	[Address(RVA = "0x315761C", Offset = "0x315761C", VA = "0x315761C")]
	internal LinkedListNode<Component> Add(string name, Component P_1)
	{
		return null;
	}

	[Token(Token = "0x60060C6")]
	[Address(RVA = "0x315754C", Offset = "0x315754C", VA = "0x315754C")]
	internal void Remove(string name, LinkedListNode<Component> P_1)
	{
	}

	[Token(Token = "0x60060C7")]
	[Address(RVA = "0x3157460", Offset = "0x3157460", VA = "0x3157460")]
	public SignalDelegateList GetDelegateByName(string name)
	{
		return null;
	}

	[Token(Token = "0x60060C8")]
	[Address(RVA = "0x315A63C", Offset = "0x315A63C", VA = "0x315A63C")]
	private void OnValidate()
	{
	}
}
