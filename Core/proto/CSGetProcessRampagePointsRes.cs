using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017ED")]
public class CSGetProcessRampagePointsRes
{
	[Token(Token = "0x4009BB4")]
	[FieldOffset(Offset = "0x8")]
	public List<RampagePoints> rampage_points;

	[Token(Token = "0x6007E47")]
	[Address(RVA = "0x3094B6C", Offset = "0x3094B6C", VA = "0x3094B6C")]
	public CSGetProcessRampagePointsRes()
	{
	}
}
