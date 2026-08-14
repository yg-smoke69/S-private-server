using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001741")]
public class CSGetPayBundleWindowDescRes
{
	[Token(Token = "0x40099B6")]
	[FieldOffset(Offset = "0x8")]
	public List<PayBundleWindowDesc> pay_bundle_windows;

	[Token(Token = "0x40099B7")]
	[FieldOffset(Offset = "0xC")]
	public uint next_refresh_time;

	[Token(Token = "0x6007D9B")]
	[Address(RVA = "0x3188448", Offset = "0x3188448", VA = "0x3188448")]
	public CSGetPayBundleWindowDescRes()
	{
	}
}
