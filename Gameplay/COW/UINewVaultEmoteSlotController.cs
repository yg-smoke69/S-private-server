using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20029FE")]
public class UINewVaultEmoteSlotController : UIBaseController, _Attribute
{
	[Token(Token = "0x4010285")]
	[FieldOffset(Offset = "0x28")]
	private int m_nIndex;

	[Token(Token = "0x4010286")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_unSlotIndex;

	[Token(Token = "0x4010287")]
	[FieldOffset(Offset = "0x30")]
	private uint m_unEmoteID;

	[Token(Token = "0x4010288")]
	[FieldOffset(Offset = "0x34")]
	private bool m_isChoose;

	[Token(Token = "0x4010289")]
	[FieldOffset(Offset = "0x38")]
	private UINewVaultEmoteSlotView m_View;

	[Token(Token = "0x401028A")]
	[FieldOffset(Offset = "0x3C")]
	private EmoteBaseInfo m_EmoteInfo;

	[Token(Token = "0x401028B")]
	[FieldOffset(Offset = "0x40")]
	private UINewVaultEmoteDragDropItem m_DragDropItem;

	[Token(Token = "0x401028C")]
	[FieldOffset(Offset = "0x44")]
	private Action<int, bool> m_actOnClick;

	[Token(Token = "0x401028D")]
	[FieldOffset(Offset = "0x48")]
	private Action m_actOnStartDrag;

	[Token(Token = "0x401028E")]
	[FieldOffset(Offset = "0x4C")]
	private Action m_actOnEndDrag;

	[Token(Token = "0x401028F")]
	[FieldOffset(Offset = "0x50")]
	private Color32 m_selectcolor;

	[Token(Token = "0x4010290")]
	[FieldOffset(Offset = "0x54")]
	private Color32 m_disselectcolor;

	[Token(Token = "0x6010F5B")]
	[Address(RVA = "0x2C21CFC", Offset = "0x2C21CFC", VA = "0x2C21CFC")]
	public UINewVaultEmoteSlotController()
	{
	}

	[Token(Token = "0x6010F5C")]
	[Address(RVA = "0x2C21DE0", Offset = "0x2C21DE0", VA = "0x2C21DE0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010F5D")]
	[Address(RVA = "0x2C21E88", Offset = "0x2C21E88", VA = "0x2C21E88", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010F5E")]
	[Address(RVA = "0x2C08414", Offset = "0x2C08414", VA = "0x2C08414")]
	public void RefreshBooyahState()
	{
	}

	[Token(Token = "0x6010F5F")]
	[Address(RVA = "0x2C0568C", Offset = "0x2C0568C", VA = "0x2C0568C")]
	public void Init(uint slotIndex, int index, Action<int, bool> act, Action startDrag, Action endDrag)
	{
	}

	[Token(Token = "0x6010F60")]
	[Address(RVA = "0x2C225A4", Offset = "0x2C225A4", VA = "0x2C225A4")]
	public void Clean()
	{
	}

	[Token(Token = "0x6010F61")]
	[Address(RVA = "0x2C22164", Offset = "0x2C22164", VA = "0x2C22164")]
	public void Refresh()
	{
	}

	[Token(Token = "0x6010F62")]
	[Address(RVA = "0x2C2278C", Offset = "0x2C2278C", VA = "0x2C2278C")]
	private void OnSlotClick()
	{
	}

	[Token(Token = "0x6010F63")]
	[Address(RVA = "0x2C0514C", Offset = "0x2C0514C", VA = "0x2C0514C")]
	public uint GetEmoteId()
	{
		return default(uint);
	}

	[Token(Token = "0x6010F64")]
	[Address(RVA = "0x2C04BB4", Offset = "0x2C04BB4", VA = "0x2C04BB4")]
	public int GetIndexInArray()
	{
		return default(int);
	}

	[Token(Token = "0x6010F65")]
	[Address(RVA = "0x2C050F4", Offset = "0x2C050F4", VA = "0x2C050F4")]
	public uint GetIndexInBag()
	{
		return default(uint);
	}

	[Token(Token = "0x6010F66")]
	[Address(RVA = "0x2C22848", Offset = "0x2C22848", VA = "0x2C22848")]
	public bool GetIsSelect()
	{
		return default(bool);
	}

	[Token(Token = "0x6010F67")]
	[Address(RVA = "0x2C05058", Offset = "0x2C05058", VA = "0x2C05058")]
	public void SetSelect(bool isSelect)
	{
	}

	[Token(Token = "0x6010F68")]
	[Address(RVA = "0x2C1E8D4", Offset = "0x2C1E8D4", VA = "0x2C1E8D4")]
	public void OnDragDropStart()
	{
	}

	[Token(Token = "0x6010F69")]
	[Address(RVA = "0x2C1EF4C", Offset = "0x2C1EF4C", VA = "0x2C1EF4C")]
	public void OnDragDropRelease(uint emoteID, bool needAction)
	{
	}

	[Token(Token = "0x6010F6A")]
	[Address(RVA = "0x2C1F5C4", Offset = "0x2C1F5C4", VA = "0x2C1F5C4")]
	public void OnDragOverSlot()
	{
	}

	[Token(Token = "0x6010F6B")]
	[Address(RVA = "0x2C228A0", Offset = "0x2C228A0", VA = "0x2C228A0", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6010F6C")]
	[Address(RVA = "0x2C22998", Offset = "0x2C22998", VA = "0x2C22998", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6010F6D")]
	[Address(RVA = "0x2C22A50", Offset = "0x2C22A50", VA = "0x2C22A50")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
