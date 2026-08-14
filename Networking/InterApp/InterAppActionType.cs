using Il2CppDummyDll;

namespace InterApp;

[Token(Token = "0x2003EF1")]
public class InterAppActionType
{
	[Token(Token = "0x2003EF2")]
	public delegate void ActDelegate(InterAppAction action);

	[Token(Token = "0x401A949")]
	[FieldOffset(Offset = "0x8")]
	public string Action;

	[Token(Token = "0x401A94A")]
	[FieldOffset(Offset = "0xC")]
	public string[] Parameters;

	[Token(Token = "0x401A94B")]
	[FieldOffset(Offset = "0x10")]
	public ActDelegate Act;

	[Token(Token = "0x6019A37")]
	[Address(RVA = "0x310C2EC", Offset = "0x310C2EC", VA = "0x310C2EC")]
	public InterAppActionType()
	{
	}
}
