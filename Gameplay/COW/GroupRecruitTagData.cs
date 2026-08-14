using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200014B")]
public class GroupRecruitTagData : CSVBaseData
{
	[Token(Token = "0x400085D")]
	[FieldOffset(Offset = "0x8")]
	public uint m_ID;

	[Token(Token = "0x400085E")]
	[FieldOffset(Offset = "0xC")]
	public string m_LocKey;

	[Token(Token = "0x400085F")]
	[FieldOffset(Offset = "0x10")]
	public uint m_RecruitType;

	[Token(Token = "0x60007C8")]
	[Address(RVA = "0x1210434", Offset = "0x1210434", VA = "0x1210434")]
	public GroupRecruitTagData()
	{
	}

	[Token(Token = "0x60007C9")]
	[Address(RVA = "0x12104B8", Offset = "0x12104B8", VA = "0x12104B8", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60007CA")]
	[Address(RVA = "0x12105E0", Offset = "0x12105E0", VA = "0x12105E0", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
