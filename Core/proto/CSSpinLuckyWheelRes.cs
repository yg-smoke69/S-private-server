using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018B8")]
public class CSSpinLuckyWheelRes
{
	[Token(Token = "0x4009DAA")]
	[FieldOffset(Offset = "0x8")]
	public List<CSLuckyWheelDiscountInfo> discount_info_list;

	[Token(Token = "0x6007F11")]
	[Address(RVA = "0x3099D68", Offset = "0x3099D68", VA = "0x3099D68")]
	public CSSpinLuckyWheelRes()
	{
	}
}
