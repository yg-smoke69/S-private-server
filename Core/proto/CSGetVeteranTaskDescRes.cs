using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017D0")]
public class CSGetVeteranTaskDescRes
{
	[Token(Token = "0x4009B7B")]
	[FieldOffset(Offset = "0x8")]
	public List<ClientVeteranTaskDesc> task_descs;

	[Token(Token = "0x4009B7C")]
	[FieldOffset(Offset = "0x10")]
	public ulong veteran_expire_time;

	[Token(Token = "0x4009B7D")]
	[FieldOffset(Offset = "0x18")]
	public List<VeteranBigPrizeDesc> big_prizes;

	[Token(Token = "0x6007E2A")]
	[Address(RVA = "0x30961E4", Offset = "0x30961E4", VA = "0x30961E4")]
	public CSGetVeteranTaskDescRes()
	{
	}
}
