using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015F6")]
public class CSGetVeteranConfigDescRes
{
	[Token(Token = "0x40094AB")]
	[FieldOffset(Offset = "0x8")]
	public List<VeteranAwardDesc> veteran_award;

	[Token(Token = "0x40094AC")]
	[FieldOffset(Offset = "0xC")]
	public List<VeteranTermCtrlDesc> veteran_term_ctrl;

	[Token(Token = "0x40094AD")]
	[FieldOffset(Offset = "0x10")]
	public VeteranConfigDesc veteran_config;

	[Token(Token = "0x6007C40")]
	[Address(RVA = "0x3096088", Offset = "0x3096088", VA = "0x3096088")]
	public CSGetVeteranConfigDescRes()
	{
	}
}
