using GCommon.CommandPattern;
using Il2CppDummyDll;

namespace COW.Gameplay.UGC.BlockEdit;

[Token(Token = "0x2000B7B")]
public class BlockEditCommandFactory
{
	[Token(Token = "0x4006145")]
	[FieldOffset(Offset = "0x8")]
	private CommandFactory m_CommandFactory;

	[Token(Token = "0x4006146")]
	[FieldOffset(Offset = "0xC")]
	public GraphData Graph;

	[Token(Token = "0x6005706")]
	[Address(RVA = "0x37AFA9C", Offset = "0x37AFA9C", VA = "0x37AFA9C")]
	public BlockEditCommandFactory()
	{
	}

	[Token(Token = "0x6005707")]
	public T CreateCommand<T>() where T : Command, new()
	{
		return null;
	}

	[Token(Token = "0x6005708")]
	public void ReleaseCommand<T>(T command) where T : Command
	{
	}

	[Token(Token = "0x6005709")]
	[Address(RVA = "0x37AFB18", Offset = "0x37AFB18", VA = "0x37AFB18")]
	public void Clear(string typeFullName)
	{
	}

	[Token(Token = "0x600570A")]
	[Address(RVA = "0x37AFB9C", Offset = "0x37AFB9C", VA = "0x37AFB9C")]
	public void ClearAll()
	{
	}
}
