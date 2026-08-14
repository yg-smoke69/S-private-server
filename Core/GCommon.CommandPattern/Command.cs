using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GCommon.CommandPattern;

[Token(Token = "0x2003E78")]
public abstract class Command : CommandPoolCallback, _Attribute
{
	[Token(Token = "0x60196DC")]
	[Address(RVA = "0x3086258", Offset = "0x3086258", VA = "0x3086258")]
	protected Command()
	{
	}

	[Token(Token = "0x60196DD")]
	public abstract void Execute();

	[Token(Token = "0x60196DE")]
	public abstract void UnExecute();

	[Token(Token = "0x60196DF")]
	[Address(RVA = "0x3086268", Offset = "0x3086268", VA = "0x3086268", Slot = "16")]
	public virtual void Clear()
	{
	}
}
