using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002518")]
internal class ChatWhisperNameData
{
	[Token(Token = "0x400E61B")]
	[FieldOffset(Offset = "0x8")]
	public FriendAccountInfo m_FriendInfo;

	[Token(Token = "0x400E61C")]
	[FieldOffset(Offset = "0xC")]
	public bool m_IsSelect;

	[Token(Token = "0x400E61D")]
	[FieldOffset(Offset = "0x10")]
	public EWhipserContainerShowTab m_CurTab;

	[Token(Token = "0x600D76C")]
	[Address(RVA = "0x172602C", Offset = "0x172602C", VA = "0x172602C")]
	public ChatWhisperNameData()
	{
	}
}
