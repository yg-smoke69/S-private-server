using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200196B")]
public class CSDigitalUniverseBStarCraftInfoInitReq
{
	[Token(Token = "0x4009FC6")]
	[FieldOffset(Offset = "0x8")]
	public List<DigitalUniverseBStarCraftPlayerInitInfo> account_infos;

	[Token(Token = "0x6007FC4")]
	[Address(RVA = "0x317F658", Offset = "0x317F658", VA = "0x317F658")]
	public CSDigitalUniverseBStarCraftInfoInitReq()
	{
	}
}
