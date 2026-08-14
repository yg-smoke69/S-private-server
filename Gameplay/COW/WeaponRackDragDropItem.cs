using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002C38")]
public class WeaponRackDragDropItem : UIDragDropItem
{
	[Token(Token = "0x4010DE0")]
	[FieldOffset(Offset = "0x6C")]
	public WeaponSkinBaseInfo DragDropBasicInfo;

	[Token(Token = "0x4010DE1")]
	[FieldOffset(Offset = "0x70")]
	public UILobbyWeaponSlotController m_Slot;

	[Token(Token = "0x4010DE2")]
	[FieldOffset(Offset = "0x74")]
	public Action m_ActionOnStart;

	[Token(Token = "0x60126DD")]
	[Address(RVA = "0x21A4BF4", Offset = "0x21A4BF4", VA = "0x21A4BF4")]
	public WeaponRackDragDropItem()
	{
	}

	[Token(Token = "0x60126DE")]
	[Address(RVA = "0x21A4C78", Offset = "0x21A4C78", VA = "0x21A4C78", Slot = "7")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60126DF")]
	[Address(RVA = "0x21A4CE4", Offset = "0x21A4CE4", VA = "0x21A4CE4", Slot = "18")]
	protected override void OnDragDropStart()
	{
	}

	[Token(Token = "0x60126E0")]
	[Address(RVA = "0x21A4E3C", Offset = "0x21A4E3C", VA = "0x21A4E3C", Slot = "20")]
	protected override void OnDragDropRelease(GameObject surface)
	{
	}

	[Token(Token = "0x60126E1")]
	[Address(RVA = "0x21A52DC", Offset = "0x21A52DC", VA = "0x21A52DC", Slot = "17")]
	public override void OnDragOverObject(GameObject go)
	{
	}

	[Token(Token = "0x60126E2")]
	[Address(RVA = "0x21A5790", Offset = "0x21A5790", VA = "0x21A5790")]
	public void OnDragOut()
	{
	}

	[Token(Token = "0x60126E3")]
	[Address(RVA = "0x21A588C", Offset = "0x21A588C", VA = "0x21A588C")]
	public void OnDragOverTrigger()
	{
	}

	[Token(Token = "0x60126E4")]
	[Address(RVA = "0x21A59E8", Offset = "0x21A59E8", VA = "0x21A59E8", Slot = "11")]
	public override bool StartDragging()
	{
		return default(bool);
	}

	[Token(Token = "0x60126E5")]
	[Address(RVA = "0x21A5C14", Offset = "0x21A5C14", VA = "0x21A5C14")]
	public void OnApplicationPause(bool pauseState)
	{
	}

	[Token(Token = "0x60126E6")]
	[Address(RVA = "0x21A5C8C", Offset = "0x21A5C8C", VA = "0x21A5C8C")]
	public void _003C_003EiFixBaseProxy_Start()
	{
	}

	[Token(Token = "0x60126E7")]
	[Address(RVA = "0x21A5C94", Offset = "0x21A5C94", VA = "0x21A5C94")]
	public void _003C_003EiFixBaseProxy_OnDragDropStart()
	{
	}

	[Token(Token = "0x60126E8")]
	[Address(RVA = "0x21A5C9C", Offset = "0x21A5C9C", VA = "0x21A5C9C")]
	public void _003C_003EiFixBaseProxy_OnDragDropRelease(GameObject P0)
	{
	}

	[Token(Token = "0x60126E9")]
	[Address(RVA = "0x21A5CA4", Offset = "0x21A5CA4", VA = "0x21A5CA4")]
	public void _003C_003EiFixBaseProxy_OnDragOverObject(GameObject P0)
	{
	}

	[Token(Token = "0x60126EA")]
	[Address(RVA = "0x21A5CAC", Offset = "0x21A5CAC", VA = "0x21A5CAC")]
	public bool _003C_003EiFixBaseProxy_StartDragging()
	{
		return default(bool);
	}
}
