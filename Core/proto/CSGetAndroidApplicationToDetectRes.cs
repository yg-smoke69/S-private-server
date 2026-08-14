using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001718")]
public class CSGetAndroidApplicationToDetectRes
{
	[Token(Token = "0x4009871")]
	[FieldOffset(Offset = "0x8")]
	public List<AndroidApplicationToDetectDesc> android_apps_to_detect_res;

	[Token(Token = "0x6007D72")]
	[Address(RVA = "0x3181960", Offset = "0x3181960", VA = "0x3181960")]
	public CSGetAndroidApplicationToDetectRes()
	{
	}
}
