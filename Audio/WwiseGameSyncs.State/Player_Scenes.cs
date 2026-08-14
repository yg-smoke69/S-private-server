using Il2CppDummyDll;

namespace WwiseGameSyncs.State;

[Token(Token = "0x20002C1")]
internal class Player_Scenes : StateBase
{
	[Token(Token = "0x40032E7")]
	[FieldOffset(Offset = "0x0")]
	public static Player_Scenes BornIsland;

	[Token(Token = "0x40032E8")]
	[FieldOffset(Offset = "0x4")]
	public static Player_Scenes Default;

	[Token(Token = "0x40032E9")]
	[FieldOffset(Offset = "0x8")]
	public static Player_Scenes None;

	[Token(Token = "0x40032EA")]
	[FieldOffset(Offset = "0xC")]
	public static Player_Scenes TrainingSocial;

	[Token(Token = "0x6000D57")]
	[Address(RVA = "0x336DCA4", Offset = "0x336DCA4", VA = "0x336DCA4")]
	private Player_Scenes(uint _value)
	{
	}
}
