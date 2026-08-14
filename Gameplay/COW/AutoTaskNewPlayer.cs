using System;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E66")]
public class AutoTaskNewPlayer : AutoPopupTask
{
	[Token(Token = "0x400BF5A")]
	[FieldOffset(Offset = "0x8")]
	private UINewPlayerV2Controller m_NewPlayerUI;

	[Token(Token = "0x400BF5B")]
	private const int SHOWED = 1;

	[Token(Token = "0x400BF5C")]
	private const int UNSHOWED = 0;

	[Token(Token = "0x400BF5D")]
	private const string NEWPLAYER = "NEWPLAYER";

	[Token(Token = "0x400BF5E")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<int> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600920B")]
	[Address(RVA = "0x10F7298", Offset = "0x10F7298", VA = "0x10F7298")]
	public AutoTaskNewPlayer()
	{
	}

	[Token(Token = "0x600920C")]
	[Address(RVA = "0x10F72A0", Offset = "0x10F72A0", VA = "0x10F72A0", Slot = "4")]
	public override int[] NeedHttpRequests()
	{
		return null;
	}

	[Token(Token = "0x600920D")]
	[Address(RVA = "0x10F7388", Offset = "0x10F7388", VA = "0x10F7388", Slot = "5")]
	public override bool Do()
	{
		return default(bool);
	}

	[Token(Token = "0x600920E")]
	[Address(RVA = "0x10F7B08", Offset = "0x10F7B08", VA = "0x10F7B08", Slot = "6")]
	public override bool IsDone()
	{
		return default(bool);
	}

	[Token(Token = "0x600920F")]
	[Address(RVA = "0x10F7C08", Offset = "0x10F7C08", VA = "0x10F7C08")]
	private static bool _003CDo_003Em__0(int i)
	{
		return default(bool);
	}
}
