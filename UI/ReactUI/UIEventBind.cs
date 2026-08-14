using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ReactUI;

[Token(Token = "0x2000CAD")]
public abstract class UIEventBind : UIVariableBind
{
	[Token(Token = "0x4006756")]
	[FieldOffset(Offset = "0x1C")]
	private UIEventTable eventTable;

	[Token(Token = "0x4006757")]
	[FieldOffset(Offset = "0x20")]
	private string paramEventID;

	[Token(Token = "0x4006758")]
	[FieldOffset(Offset = "0x24")]
	private UIVariable m_eventIDVariable;

	[Token(Token = "0x4006759")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<string, LinkedListNode<Component>> m_name2Node;

	[Token(Token = "0x400675A")]
	[FieldOffset(Offset = "0x2C")]
	private UIEventTable _003CEventTable_003Ek__BackingField;

	[Token(Token = "0x1700080D")]
	public UIEventTable EventTable
	{
		[Token(Token = "0x6006081")]
		[Address(RVA = "0x3157280", Offset = "0x3157280", VA = "0x3157280")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006082")]
		[Address(RVA = "0x3157288", Offset = "0x3157288", VA = "0x3157288")]
		private set
		{
		}
	}

	[Token(Token = "0x6006080")]
	[Address(RVA = "0x3157184", Offset = "0x3157184", VA = "0x3157184")]
	protected UIEventBind()
	{
	}

	[Token(Token = "0x6006083")]
	[Address(RVA = "0x3157290", Offset = "0x3157290", VA = "0x3157290")]
	internal SignalDelegateList Add(string name)
	{
		return null;
	}

	[Token(Token = "0x6006084")]
	[Address(RVA = "0x3157754", Offset = "0x3157754", VA = "0x3157754", Slot = "9")]
	protected override void OnValidate()
	{
	}

	[Token(Token = "0x6006085")]
	[Address(RVA = "0x3157AA4", Offset = "0x3157AA4", VA = "0x3157AA4", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6006086")]
	protected abstract void RefreshBind();

	[Token(Token = "0x6006087")]
	[Address(RVA = "0x3157B04", Offset = "0x3157B04", VA = "0x3157B04", Slot = "8")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6006088")]
	[Address(RVA = "0x3157B4C", Offset = "0x3157B4C", VA = "0x3157B4C", Slot = "4")]
	internal override void Init()
	{
	}

	[Token(Token = "0x6006089")]
	[Address(RVA = "0x3157848", Offset = "0x3157848", VA = "0x3157848")]
	private void Clear()
	{
	}

	[Token(Token = "0x600608A")]
	[Address(RVA = "0x3157C50", Offset = "0x3157C50", VA = "0x3157C50")]
	public UIVariable GetEventIDVar()
	{
		return null;
	}
}
