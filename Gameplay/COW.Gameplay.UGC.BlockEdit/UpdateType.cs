using Il2CppDummyDll;

namespace COW.Gameplay.UGC.BlockEdit;

[Token(Token = "0x2000BA6")]
public enum UpdateType
{
	[Token(Token = "0x4006210")]
	None,
	[Token(Token = "0x4006211")]
	Type,
	[Token(Token = "0x4006212")]
	VarRefType,
	[Token(Token = "0x4006213")]
	VarRefClone,
	[Token(Token = "0x4006214")]
	CollectCustomString,
	[Token(Token = "0x4006215")]
	RegisterToGraph,
	[Token(Token = "0x4006216")]
	UnregisterFromGraph,
	[Token(Token = "0x4006217")]
	CheckBlockLegality,
	[Token(Token = "0x4006218")]
	GetCount,
	[Token(Token = "0x4006219")]
	FuncRefType,
	[Token(Token = "0x400621A")]
	FuncRefAddItem,
	[Token(Token = "0x400621B")]
	FuncRefRemoveItem,
	[Token(Token = "0x400621C")]
	FuncRefGraphRef,
	[Token(Token = "0x400621D")]
	CheckRefHasDefine,
	[Token(Token = "0x400621E")]
	CheckFuncReturn,
	[Token(Token = "0x400621F")]
	CheckLocalVarRefInRange,
	[Token(Token = "0x4006220")]
	CollectVarRef,
	[Token(Token = "0x4006221")]
	CollectLocalVarDefine,
	[Token(Token = "0x4006222")]
	CollectFuncCaller
}
