using Il2CppDummyDll;

namespace GCommon.CommandPattern;

[Token(Token = "0x2003E80")]
public abstract class RecordCommand : Command
{
	[Token(Token = "0x6019704")]
	[Address(RVA = "0x30874AC", Offset = "0x30874AC", VA = "0x30874AC")]
	protected RecordCommand()
	{
	}

	[Token(Token = "0x6019705")]
	public abstract void Record();
}
