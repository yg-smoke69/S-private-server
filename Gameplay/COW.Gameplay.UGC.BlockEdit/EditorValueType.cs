using Il2CppDummyDll;

namespace COW.Gameplay.UGC.BlockEdit;

[Token(Token = "0x2000BA5")]
public enum EditorValueType
{
	[Token(Token = "0x4006207")]
	Const,
	[Token(Token = "0x4006208")]
	Block,
	[Token(Token = "0x4006209")]
	VarRef,
	[Token(Token = "0x400620A")]
	LocalVarDefine,
	[Token(Token = "0x400620B")]
	FuncDefine,
	[Token(Token = "0x400620C")]
	HudEventDefine,
	[Token(Token = "0x400620D")]
	FuncRef,
	[Token(Token = "0x400620E")]
	Null
}
