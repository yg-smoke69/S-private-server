using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200161E")]
public class CSGetMailListRes
{
	[Token(Token = "0x4009536")]
	[FieldOffset(Offset = "0x8")]
	public List<MailInfo> mails;

	[Token(Token = "0x6007C68")]
	[Address(RVA = "0x318741C", Offset = "0x318741C", VA = "0x318741C")]
	public CSGetMailListRes()
	{
	}
}
