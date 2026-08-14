using System.Collections.Generic;
using Il2CppDummyDll;

namespace GCommon.CommandPattern;

[Token(Token = "0x2003E7F")]
public class MacroCommand : Command
{
	[Token(Token = "0x401A6AD")]
	[FieldOffset(Offset = "0x10")]
	private List<Command> m_ChildCommands;

	[Token(Token = "0x60196FE")]
	[Address(RVA = "0x3087028", Offset = "0x3087028", VA = "0x3087028")]
	public MacroCommand()
	{
	}

	[Token(Token = "0x60196FF")]
	[Address(RVA = "0x30870B4", Offset = "0x30870B4", VA = "0x30870B4")]
	public void AddCommand(Command command)
	{
	}

	[Token(Token = "0x6019700")]
	[Address(RVA = "0x308713C", Offset = "0x308713C", VA = "0x308713C", Slot = "16")]
	public override void Clear()
	{
	}

	[Token(Token = "0x6019701")]
	[Address(RVA = "0x30872E0", Offset = "0x30872E0", VA = "0x30872E0", Slot = "14")]
	public override void Execute()
	{
	}

	[Token(Token = "0x6019702")]
	[Address(RVA = "0x30873C4", Offset = "0x30873C4", VA = "0x30873C4", Slot = "15")]
	public override void UnExecute()
	{
	}

	[Token(Token = "0x6019703")]
	[Address(RVA = "0x30868E8", Offset = "0x30868E8", VA = "0x30868E8")]
	public void ExecuteMacro()
	{
	}
}
