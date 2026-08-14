using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A9B")]
public class GetOppositeSexModelRes
{
	[Token(Token = "0x400A6B7")]
	[FieldOffset(Offset = "0x8")]
	public List<OppositeSexModelDesc> opposite_sex_models;

	[Token(Token = "0x60080F8")]
	[Address(RVA = "0x30A1FE8", Offset = "0x30A1FE8", VA = "0x30A1FE8")]
	public GetOppositeSexModelRes()
	{
	}
}
