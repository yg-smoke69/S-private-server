using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A9C")]
public class GetPatchOptionalResManagerUpdateRes
{
	[Token(Token = "0x400A6B8")]
	[FieldOffset(Offset = "0x8")]
	public List<PatchOptionalResManagerUpdateDesc> patch_optional_res_manager_updates;

	[Token(Token = "0x60080F9")]
	[Address(RVA = "0x30A2074", Offset = "0x30A2074", VA = "0x30A2074")]
	public GetPatchOptionalResManagerUpdateRes()
	{
	}
}
