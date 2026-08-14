using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017DA")]
public class CSGetCustomEventProcessSettingRes
{
	[Token(Token = "0x4009B91")]
	[FieldOffset(Offset = "0x8")]
	public List<CustomEventProcessSettingDesc> process_setting;

	[Token(Token = "0x6007E34")]
	[Address(RVA = "0x3183B14", Offset = "0x3183B14", VA = "0x3183B14")]
	public CSGetCustomEventProcessSettingRes()
	{
	}
}
