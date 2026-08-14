using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002DE5")]
internal class InviteTypeSettingDataManager : SingletonModule<InviteTypeSettingDataManager>
{
	[Token(Token = "0x40119BF")]
	[FieldOffset(Offset = "0xC")]
	private List<InviteTypeSettingData> m_InviteTypeSettingDataList;

	[Token(Token = "0x60133C6")]
	[Address(RVA = "0x1EE1F1C", Offset = "0x1EE1F1C", VA = "0x1EE1F1C")]
	public InviteTypeSettingDataManager()
	{
	}

	[Token(Token = "0x60133C7")]
	[Address(RVA = "0x1EE1FE0", Offset = "0x1EE1FE0", VA = "0x1EE1FE0", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x60133C8")]
	[Address(RVA = "0x1EE20A0", Offset = "0x1EE20A0", VA = "0x1EE20A0", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x60133C9")]
	[Address(RVA = "0x1EE21C4", Offset = "0x1EE21C4", VA = "0x1EE21C4")]
	public List<uint> GetInviteTypes(uint gameMode, uint matchMode)
	{
		return null;
	}
}
