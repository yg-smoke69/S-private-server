using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200161A")]
public class CSGetSecretMissionDescRes
{
	[Token(Token = "0x4009530")]
	[FieldOffset(Offset = "0x8")]
	public List<SecretMissionDesc> descs;

	[Token(Token = "0x6007C64")]
	[Address(RVA = "0x30953D0", Offset = "0x30953D0", VA = "0x30953D0")]
	public CSGetSecretMissionDescRes()
	{
	}
}
