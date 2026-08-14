using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200138D")]
public class AvatarDispatchQuest
{
	[Token(Token = "0x40089EA")]
	[FieldOffset(Offset = "0x8")]
	public uint quest_line;

	[Token(Token = "0x40089EB")]
	[FieldOffset(Offset = "0xC")]
	public uint quest_id;

	[Token(Token = "0x40089EC")]
	[FieldOffset(Offset = "0x10")]
	public EProfile.DispatchQuestState state;

	[Token(Token = "0x40089ED")]
	[FieldOffset(Offset = "0x18")]
	public long start_time;

	[Token(Token = "0x6007A89")]
	[Address(RVA = "0x317B174", Offset = "0x317B174", VA = "0x317B174")]
	public AvatarDispatchQuest()
	{
	}
}
