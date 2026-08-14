using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200009F")]
public class AssistantAudioData : CSVBaseData
{
	[Token(Token = "0x400037E")]
	[FieldOffset(Offset = "0x8")]
	public string VoiceIDName;

	[Token(Token = "0x400037F")]
	[FieldOffset(Offset = "0xC")]
	public string Line;

	[Token(Token = "0x4000380")]
	[FieldOffset(Offset = "0x10")]
	public string Langsuffix;

	[Token(Token = "0x4000381")]
	[FieldOffset(Offset = "0x14")]
	public uint CharacterID;

	[Token(Token = "0x4000382")]
	[FieldOffset(Offset = "0x18")]
	public int TriggerType;

	[Token(Token = "0x4000383")]
	[FieldOffset(Offset = "0x1C")]
	public ResourceID VoiceID;

	[Token(Token = "0x6000407")]
	[Address(RVA = "0x14CE3C4", Offset = "0x14CE3C4", VA = "0x14CE3C4")]
	public AssistantAudioData()
	{
	}

	[Token(Token = "0x6000408")]
	[Address(RVA = "0x14CE448", Offset = "0x14CE448", VA = "0x14CE448", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000409")]
	[Address(RVA = "0x14CE548", Offset = "0x14CE548", VA = "0x14CE548", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
