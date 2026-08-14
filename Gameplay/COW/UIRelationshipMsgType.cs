using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20031FD")]
public enum UIRelationshipMsgType
{
	[Token(Token = "0x4013078")]
	NONE,
	[Token(Token = "0x4013079")]
	CreateRelation,
	[Token(Token = "0x401307A")]
	DismissRelation,
	[Token(Token = "0x401307B")]
	DeclineRelation,
	[Token(Token = "0x401307C")]
	RefuseDismissRelation,
	[Token(Token = "0x401307D")]
	CreateRelationReq,
	[Token(Token = "0x401307E")]
	DismissRelationReq,
	[Token(Token = "0x401307F")]
	CreateRelationInvalid,
	[Token(Token = "0x4013080")]
	DismissRelationInvalid
}
