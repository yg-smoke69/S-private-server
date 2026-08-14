using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002CFF")]
internal abstract class UIInventoryItemControllerBase : UIBaseController
{
	[Token(Token = "0x4011262")]
	[FieldOffset(Offset = "0x28")]
	protected UIItem m_Item;

	[Token(Token = "0x4011263")]
	[FieldOffset(Offset = "0x2C")]
	protected bool m_DragIn;

	[Token(Token = "0x6012CFA")]
	[Address(RVA = "0x128568C", Offset = "0x128568C", VA = "0x128568C")]
	protected UIInventoryItemControllerBase()
	{
	}

	[Token(Token = "0x6012CFB")]
	[Address(RVA = "0x1285710", Offset = "0x1285710", VA = "0x1285710", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6012CFC")]
	[Address(RVA = "0x1285A60", Offset = "0x1285A60", VA = "0x1285A60", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6012CFD")]
	[Address(RVA = "0x1285BB4", Offset = "0x1285BB4", VA = "0x1285BB4")]
	public UIItem GetUIItem()
	{
		return null;
	}

	[Token(Token = "0x6012CFE")]
	[Address(RVA = "0x1285C0C", Offset = "0x1285C0C", VA = "0x1285C0C", Slot = "31")]
	public virtual AAHMJHHPECM GetItem()
	{
		return null;
	}

	[Token(Token = "0x6012CFF")]
	[Address(RVA = "0x1285C78", Offset = "0x1285C78", VA = "0x1285C78", Slot = "32")]
	public virtual int GetCount()
	{
		return default(int);
	}

	[Token(Token = "0x6012D00")]
	[Address(RVA = "0x1285CE4", Offset = "0x1285CE4", VA = "0x1285CE4", Slot = "33")]
	public virtual void OnDrapStart()
	{
	}

	[Token(Token = "0x6012D01")]
	[Address(RVA = "0x12862EC", Offset = "0x12862EC", VA = "0x12862EC")]
	public void ResetNoDrag()
	{
	}

	[Token(Token = "0x6012D02")]
	[Address(RVA = "0x128647C", Offset = "0x128647C", VA = "0x128647C", Slot = "34")]
	public virtual bool OnDrapRelease(UIInventoryItemDragDropContainer container)
	{
		return default(bool);
	}

	[Token(Token = "0x6012D03")]
	[Address(RVA = "0x1286890", Offset = "0x1286890", VA = "0x1286890", Slot = "35")]
	protected virtual bool HandleReleaseEvent(UIInventoryItemDragDropContainer container)
	{
		return default(bool);
	}

	[Token(Token = "0x6012D04")]
	[Address(RVA = "0x12868F4", Offset = "0x12868F4", VA = "0x12868F4", Slot = "36")]
	protected virtual void OnItemToggleChanged()
	{
	}

	[Token(Token = "0x6012D05")]
	public abstract UIToggle GetToggle();

	[Token(Token = "0x6012D06")]
	public abstract GameObject GetHighlightGO();

	[Token(Token = "0x6012D07")]
	public abstract GameObject GetDragGO();

	[Token(Token = "0x6012D08")]
	public abstract GameObject GetNonDragGO();

	[Token(Token = "0x6012D09")]
	public abstract GameObject GetDragRedGo();

	[Token(Token = "0x6012D0A")]
	[Address(RVA = "0x1286C44", Offset = "0x1286C44", VA = "0x1286C44")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x6012D0B")]
	[Address(RVA = "0x1286C4C", Offset = "0x1286C4C", VA = "0x1286C4C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
