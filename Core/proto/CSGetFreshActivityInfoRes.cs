using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017B7")]
public class CSGetFreshActivityInfoRes
{
	[Token(Token = "0x4009B3A")]
	[FieldOffset(Offset = "0x8")]
	public uint day;

	[Token(Token = "0x4009B3B")]
	[FieldOffset(Offset = "0xC")]
	public List<ActivityInfo> activitys;

	[Token(Token = "0x4009B3C")]
	[FieldOffset(Offset = "0x10")]
	public ulong expire_time;

	[Token(Token = "0x6007E11")]
	[Address(RVA = "0x31850C0", Offset = "0x31850C0", VA = "0x31850C0")]
	public CSGetFreshActivityInfoRes()
	{
	}
}
