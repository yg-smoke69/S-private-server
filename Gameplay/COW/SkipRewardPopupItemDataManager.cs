using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002E35")]
internal class SkipRewardPopupItemDataManager : SingletonModule<SkipRewardPopupItemDataManager>
{
	[Token(Token = "0x4011ABF")]
	[FieldOffset(Offset = "0xC")]
	private HashSet<uint> m_SkpiRewardPopupItemIdSet;

	[Token(Token = "0x6013538")]
	[Address(RVA = "0x20F0294", Offset = "0x20F0294", VA = "0x20F0294")]
	public SkipRewardPopupItemDataManager()
	{
	}

	[Token(Token = "0x6013539")]
	[Address(RVA = "0x20F0358", Offset = "0x20F0358", VA = "0x20F0358", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x601353A")]
	[Address(RVA = "0x20F0884", Offset = "0x20F0884", VA = "0x20F0884")]
	public bool HasItemId(uint itemId)
	{
		return default(bool);
	}

	[Token(Token = "0x601353B")]
	[Address(RVA = "0x20F0950", Offset = "0x20F0950", VA = "0x20F0950", Slot = "7")]
	protected override void OnCleanup()
	{
	}
}
