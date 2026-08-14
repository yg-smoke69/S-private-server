using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002DF9")]
public class MentorTitleDataManager : SingletonModule<MentorTitleDataManager>
{
	[Token(Token = "0x40119F7")]
	[FieldOffset(Offset = "0xC")]
	private List<MentorTitleData> m_MentorTitleList;

	[Token(Token = "0x6013444")]
	[Address(RVA = "0x2274810", Offset = "0x2274810", VA = "0x2274810")]
	public MentorTitleDataManager()
	{
	}

	[Token(Token = "0x6013445")]
	[Address(RVA = "0x22748A0", Offset = "0x22748A0", VA = "0x22748A0", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6013446")]
	[Address(RVA = "0x2274900", Offset = "0x2274900", VA = "0x2274900")]
	private void ProcessInfo()
	{
	}

	[Token(Token = "0x6013447")]
	[Address(RVA = "0x2274AC0", Offset = "0x2274AC0", VA = "0x2274AC0", Slot = "7")]
	protected override void OnCleanup()
	{
	}
}
