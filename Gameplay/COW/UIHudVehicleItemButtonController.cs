using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20028A8")]
internal abstract class UIHudVehicleItemButtonController : UIHudButtonBaseController
{
	[Token(Token = "0x400FA34")]
	[FieldOffset(Offset = "0x2C")]
	protected UISprite m_CDProgress;

	[Token(Token = "0x400FA35")]
	[FieldOffset(Offset = "0x30")]
	protected GameObject m_CDMask;

	[Token(Token = "0x400FA36")]
	[FieldOffset(Offset = "0x34")]
	protected PPPNNCOCOOI m_TargetSlot;

	[Token(Token = "0x400FA37")]
	[FieldOffset(Offset = "0x38")]
	protected float m_CdEndTime;

	[Token(Token = "0x400FA38")]
	[FieldOffset(Offset = "0x3C")]
	private float m_CdTime;

	[Token(Token = "0x400FA39")]
	[FieldOffset(Offset = "0x40")]
	private float m_LeftTime;

	[Token(Token = "0x17001205")]
	protected bool IsInCd
	{
		[Token(Token = "0x600FF8B")]
		[Address(RVA = "0x1A6E920", Offset = "0x1A6E920", VA = "0x1A6E920")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600FF80")]
	[Address(RVA = "0x1A6C0DC", Offset = "0x1A6C0DC", VA = "0x1A6C0DC")]
	protected UIHudVehicleItemButtonController()
	{
	}

	[Token(Token = "0x600FF81")]
	[Address(RVA = "0x1A6C3F4", Offset = "0x1A6C3F4", VA = "0x1A6C3F4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FF82")]
	[Address(RVA = "0x1A6C730", Offset = "0x1A6C730", VA = "0x1A6C730", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600FF83")]
	[Address(RVA = "0x1A6CC48", Offset = "0x1A6CC48", VA = "0x1A6CC48", Slot = "37")]
	protected virtual void OnPlayerGetOnVehicle(object[] ps)
	{
	}

	[Token(Token = "0x600FF84")]
	[Address(RVA = "0x1A6DFA4", Offset = "0x1A6DFA4", VA = "0x1A6DFA4")]
	protected void OnLocalVehicleEquipChange(object[] ps)
	{
	}

	[Token(Token = "0x600FF85")]
	[Address(RVA = "0x1A6E2FC", Offset = "0x1A6E2FC", VA = "0x1A6E2FC")]
	protected void OnLocalVehicleUseItem(object[] ps)
	{
	}

	[Token(Token = "0x600FF86")]
	[Address(RVA = "0x1A6CA2C", Offset = "0x1A6CA2C", VA = "0x1A6CA2C")]
	protected void CheckAndUpdateVisibility()
	{
	}

	[Token(Token = "0x600FF87")]
	[Address(RVA = "0x1A6E120", Offset = "0x1A6E120", VA = "0x1A6E120")]
	protected void CheckAndUpdateVisibility(LevelVehicle veh)
	{
	}

	[Token(Token = "0x600FF88")]
	[Address(RVA = "0x1A6CD18", Offset = "0x1A6CD18", VA = "0x1A6CD18", Slot = "38")]
	protected virtual bool ShouldHide()
	{
		return default(bool);
	}

	[Token(Token = "0x600FF89")]
	[Address(RVA = "0x1A6E48C", Offset = "0x1A6E48C", VA = "0x1A6E48C", Slot = "39")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x600FF8A")]
	[Address(RVA = "0x1A6E6F0", Offset = "0x1A6E6F0", VA = "0x1A6E6F0", Slot = "40")]
	protected virtual void UpdateCd(MKOHELJKKDL item)
	{
	}

	[Token(Token = "0x600FF8C")]
	[Address(RVA = "0x1A6EA30", Offset = "0x1A6EA30", VA = "0x1A6EA30")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FF8D")]
	[Address(RVA = "0x1A6EA38", Offset = "0x1A6EA38", VA = "0x1A6EA38")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
