using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200171A")]
public class CSShareSettingDescRes
{
	[Token(Token = "0x4009873")]
	[FieldOffset(Offset = "0x8")]
	public List<ShareSettingDesc> share_settings;

	[Token(Token = "0x6007D74")]
	[Address(RVA = "0x3099B80", Offset = "0x3099B80", VA = "0x3099B80")]
	public CSShareSettingDescRes()
	{
	}
}
