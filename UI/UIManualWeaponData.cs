using System.Collections.Generic;
using COW;
using Il2CppDummyDll;
using proto;

[Token(Token = "0x2002E50")]
public class UIManualWeaponData : UIManualDataBase
{
	[Token(Token = "0x4011B25")]
	[FieldOffset(Offset = "0x38")]
	public uint m_SubTitleId;

	[Token(Token = "0x4011B26")]
	[FieldOffset(Offset = "0x3C")]
	public List<ManualWeaponReward> m_ManualWeaponRewardStatuses;

	[Token(Token = "0x4011B27")]
	[FieldOffset(Offset = "0x40")]
	public List<uint> m_UnlockWeapons;

	[Token(Token = "0x60135F6")]
	[Address(RVA = "0x148ABBC", Offset = "0x148ABBC", VA = "0x148ABBC")]
	public UIManualWeaponData()
	{
	}

	[Token(Token = "0x60135F7")]
	[Address(RVA = "0x148AC7C", Offset = "0x148AC7C", VA = "0x148AC7C", Slot = "4")]
	public override void Init()
	{
	}
}
