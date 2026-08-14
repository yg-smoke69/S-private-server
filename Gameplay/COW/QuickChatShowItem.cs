using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002814")]
public class QuickChatShowItem
{
	[Token(Token = "0x400F76B")]
	[FieldOffset(Offset = "0x8")]
	public float m_ShowTimstamp;

	[Token(Token = "0x400F76C")]
	[FieldOffset(Offset = "0xC")]
	public uint QuickChatID;

	[Token(Token = "0x400F76D")]
	[FieldOffset(Offset = "0x10")]
	public QuickChatView m_ShowChatView;

	[Token(Token = "0x400F76E")]
	[FieldOffset(Offset = "0x14")]
	public bool HasHelped;

	[Token(Token = "0x600F983")]
	[Address(RVA = "0x196CD78", Offset = "0x196CD78", VA = "0x196CD78")]
	public QuickChatShowItem()
	{
	}

	[Token(Token = "0x600F984")]
	[Address(RVA = "0x196CD80", Offset = "0x196CD80", VA = "0x196CD80")]
	public bool IsShow()
	{
		return default(bool);
	}

	[Token(Token = "0x600F985")]
	[Address(RVA = "0x196CEC4", Offset = "0x196CEC4", VA = "0x196CEC4")]
	public void OnDeque()
	{
	}
}
